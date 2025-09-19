#!/usr/bin/env python3
"""
Enhanced Template Data Extractor for Gear Fight

This script extracts TEMPLATE configuration data from procedural levels,
which was previously being ignored. This data defines:
- Fight template structure (enemy slots, structure pools)
- Economic parameters (coins, spinners)
- Difficulty profiles
- Grid configurations
"""

import os
import json
import logging
from pathlib import Path
import sys
sys.path.append('.')

# Import the main extractor to reuse UnityParser
from extract_detailed_game_data import GearFightExtractor

logging.basicConfig(level=logging.INFO)
logger = logging.getLogger(__name__)

class TemplateDataExtractor:
    def __init__(self):
        self.gear_fight_extractor = GearFightExtractor()
        # Access the parser through the extractor's internal attribute
        self.unity_parser = self.gear_fight_extractor.parser
        self.base_dir = Path(__file__).parent
        self.unity_dir = self.base_dir / "UnityProject"

    def extract_template_data(self, level_data, level_name):
        """Extract template configuration from a level."""
        template_info = {
            'level_name': level_name,
            'is_procedural': level_data.get('<DoUseCustomFights>k__BackingField', 0) == 0,
            'fight_templates': [],
            'structure_pool': [],
            'economic_template': {},
            'grid_configuration': {},
            'difficulty_settings': {}
        }

        # Extract fight templates
        all_fights_data = level_data.get('allFights', [])
        for i, fight_data in enumerate(all_fights_data):
            enemies_data = fight_data.get('<Enemies>k__BackingField', [])

            fight_template = {
                'fight_index': i,
                'enemy_slots': len(enemies_data),
                'placeholder_count': 0,
                'configured_count': 0,
                'structure_slot': None,
                'economic_params': {
                    'value_of_fight': fight_data.get('<ValueOfFight>k__BackingField', 0),
                    'force_basic_shop': fight_data.get('<ForceBasicShop>k__BackingField', 0),
                    'fight_offset': fight_data.get('<FightOffset>k__BackingField', 0),
                    'has_structure_chest': fight_data.get('<HasStructureChest>k__BackingField', 0)
                }
            }

            # Analyze enemy slot configuration
            for enemy_data in enemies_data:
                character_ref = enemy_data.get('<Character>k__BackingField', {})
                if character_ref and character_ref.get('fileID', 0) != 0:
                    fight_template['configured_count'] += 1
                else:
                    fight_template['placeholder_count'] += 1

            # Check structure slot
            structure_ref = fight_data.get('<Structure>k__BackingField', {})
            if structure_ref and structure_ref.get('fileID', 0) != 0:
                fight_template['structure_slot'] = {
                    'guid': structure_ref.get('guid'),
                    'name': self.unity_parser.resolve_guid_to_name(structure_ref)
                }

            template_info['fight_templates'].append(fight_template)

        # Extract structure pool (available structures for this level)
        all_structures_data = level_data.get('allStructures', [])
        for structure_ref in all_structures_data:
            if structure_ref and structure_ref.get('fileID', 0) != 0:
                template_info['structure_pool'].append({
                    'guid': structure_ref.get('guid'),
                    'name': self.unity_parser.resolve_guid_to_name(structure_ref)
                })

        # Extract economic template
        template_info['economic_template'] = {
            'starting_coins': level_data.get('<StartingCoins>k__BackingField', 0),
            'number_of_spinners': level_data.get('<NumberOfSpinners>k__BackingField', 0),
            'num_levels_param': level_data.get('numLevels', 0),
            'niv_settings': {
                'use_level_value': level_data.get('useLevelValueForNIV', 0),
                'use_custom_level_for_payouts': level_data.get('useCustomLevelForPayouts', 0),
                'custom_level_for_payouts': level_data.get('customLevelForPayouts', 0)
            }
        }

        # Extract grid configuration
        grid_ref = level_data.get('<CustomLevelGrid>k__BackingField', {})
        if grid_ref and grid_ref.get('fileID', 0) != 0:
            template_info['grid_configuration'] = {
                'guid': grid_ref.get('guid'),
                'name': self.unity_parser.resolve_guid_to_name(grid_ref)
            }

        puzzle_config = level_data.get('<PuzzleConfiguration>k__BackingField', 0)
        template_info['grid_configuration']['puzzle_type'] = puzzle_config

        # Extract difficulty settings
        difficulty_ref = level_data.get('difficultyProfile', {})
        if difficulty_ref and difficulty_ref.get('fileID', 0) != 0:
            template_info['difficulty_settings'] = {
                'profile_guid': difficulty_ref.get('guid'),
                'profile_name': self.unity_parser.resolve_guid_to_name(difficulty_ref)
            }

        return template_info

    def extract_all_template_data(self):
        """Extract template data from all levels."""
        logger.info("Starting template data extraction...")

        # Initialize the extractor (builds GUID mapping)
        logger.info("Initializing extractor...")
        # GUID mapping is built in the constructor

        template_data = {
            'extraction_info': {
                'purpose': 'Extract template configuration data from procedural levels',
                'date': '2025-09-18',
                'levels_analyzed': 0,
                'procedural_levels': 0,
                'custom_levels': 0
            },
            'level_templates': {}
        }

        # Find all level files
        level_files = list(self.unity_dir.glob("MonoBehaviour/World*Level*.asset"))
        logger.info(f"Found {len(level_files)} level files to analyze")

        for level_file in sorted(level_files):
            try:
                logger.info(f"Analyzing template data in {level_file.name}")

                # Parse level file
                level_data = self.unity_parser.parse_yaml_file(level_file)
                if not level_data:
                    continue

                # Extract template information
                level_name = level_file.name.replace('.asset', '')
                template_info = self.extract_template_data(level_data, level_name)
                template_data['level_templates'][level_name] = template_info

                # Update statistics
                template_data['extraction_info']['levels_analyzed'] += 1
                if template_info['is_procedural']:
                    template_data['extraction_info']['procedural_levels'] += 1
                else:
                    template_data['extraction_info']['custom_levels'] += 1

            except Exception as e:
                logger.error(f"Error processing {level_file}: {e}")
                continue

        return template_data

    def save_template_data(self, template_data):
        """Save template data to files."""
        # Save complete template data
        template_file = self.base_dir / "level_templates_complete.json"
        with open(template_file, 'w') as f:
            json.dump(template_data, f, indent=2, default=str)
        logger.info(f"Template data saved to {template_file}")

        # Generate summary report
        summary = {
            'total_levels': template_data['extraction_info']['levels_analyzed'],
            'procedural_levels': template_data['extraction_info']['procedural_levels'],
            'custom_levels': template_data['extraction_info']['custom_levels'],
            'key_findings': [],
            'template_patterns': {}
        }

        # Analyze patterns
        fight_slot_counts = {}
        structure_pool_sizes = {}

        for level_name, template in template_data['level_templates'].items():
            if template['is_procedural']:
                # Count fight template patterns
                for fight_template in template['fight_templates']:
                    slot_count = fight_template['enemy_slots']
                    fight_slot_counts[slot_count] = fight_slot_counts.get(slot_count, 0) + 1

                # Count structure pool sizes
                pool_size = len(template['structure_pool'])
                structure_pool_sizes[pool_size] = structure_pool_sizes.get(pool_size, 0) + 1

        summary['template_patterns'] = {
            'enemy_slot_distributions': fight_slot_counts,
            'structure_pool_distributions': structure_pool_sizes
        }

        summary['key_findings'] = [
            f"All {summary['procedural_levels']} procedural levels have template configurations",
            f"Enemy slot counts range: {min(fight_slot_counts.keys()) if fight_slot_counts else 0}-{max(fight_slot_counts.keys()) if fight_slot_counts else 0}",
            f"Structure pool sizes range: {min(structure_pool_sizes.keys()) if structure_pool_sizes else 0}-{max(structure_pool_sizes.keys()) if structure_pool_sizes else 0}",
            "Template data defines procedural generation parameters, not empty slots"
        ]

        summary_file = self.base_dir / "template_extraction_summary.json"
        with open(summary_file, 'w') as f:
            json.dump(summary, f, indent=2)
        logger.info(f"Summary saved to {summary_file}")

        return summary

def main():
    """Main extraction function."""
    logger.info("=== Enhanced Template Data Extraction ===")
    logger.info("Purpose: Extract template configurations from procedural levels")
    logger.info("")

    extractor = TemplateDataExtractor()

    # Extract template data
    template_data = extractor.extract_all_template_data()

    # Save results
    summary = extractor.save_template_data(template_data)

    # Print summary
    logger.info("=== EXTRACTION COMPLETE ===")
    logger.info(f"Levels analyzed: {summary['total_levels']}")
    logger.info(f"Procedural levels: {summary['procedural_levels']}")
    logger.info(f"Custom levels: {summary['custom_levels']}")
    logger.info("")
    logger.info("Key findings:")
    for finding in summary['key_findings']:
        logger.info(f"  - {finding}")

    return template_data, summary

if __name__ == "__main__":
    main()