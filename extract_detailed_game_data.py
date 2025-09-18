#!/usr/bin/env python3
"""
Gear Fight Complete Data Extractor - Clean Modular Architecture
Extracts ALL Unity data with maintainable, well-structured code

Based on comprehensive analysis from LEVEL_SYSTEM_DETAILED_DOCS
"""

import yaml
import json
import re
import logging
from pathlib import Path
from datetime import datetime
from typing import Dict, List, Any, Optional

# Configure logging
logging.basicConfig(level=logging.INFO, format='%(levelname)s: %(message)s')
logger = logging.getLogger(__name__)


class UnityParser:
    """Core Unity YAML parsing utilities"""

    def __init__(self, unity_path: str = "UnityProject/MonoBehaviour"):
        self.unity_path = Path(unity_path)
        self.guid_map = {}
        self._build_guid_map()

    def _build_guid_map(self) -> None:
        """Build GUID to asset name mapping from .meta files"""
        logger.info("Building GUID mapping...")

        for meta_file in self.unity_path.glob("*.asset.meta"):
            try:
                content = meta_file.read_text()
                if match := re.search(r'guid:\s*([a-f0-9]+)', content):
                    self.guid_map[match.group(1)] = meta_file.stem
            except Exception as e:
                logger.error(f"Error reading {meta_file}: {e}")

        logger.info(f"Mapped {len(self.guid_map)} GUIDs")

    def parse_asset(self, filepath: Path) -> Optional[Dict[str, Any]]:
        """Parse Unity asset file and return data"""
        try:
            content = filepath.read_text(encoding='utf-8')

            # Find MonoBehaviour section
            if 'MonoBehaviour:' not in content:
                return None

            # Extract and clean YAML
            yaml_content = content[content.find('MonoBehaviour:'):]

            # Remove Unity's k__BackingField syntax
            yaml_content = re.sub(r'<(.+?)>k__BackingField', r'\1', yaml_content)

            data = yaml.safe_load(yaml_content)
            return data.get('MonoBehaviour', data) if isinstance(data, dict) else data

        except Exception as e:
            logger.error(f"Error parsing {filepath}: {e}")
            return None

    def resolve_reference(self, ref: Any) -> Dict[str, Any]:
        """Resolve Unity reference to name and GUID"""
        if not ref:
            return {'name': None, 'guid': None, 'is_null': True}

        guid = None
        if isinstance(ref, dict):
            guid = ref.get('guid')
            if ref.get('fileID') == 0:  # Null reference
                return {'name': None, 'guid': None, 'is_null': True}

        name = self.guid_map.get(guid) if guid else None
        return {
            'name': name,
            'guid': guid,
            'is_null': not bool(guid)
        }


class AssetExtractor:
    """Base class for extracting specific asset types"""

    def __init__(self, parser: UnityParser):
        self.parser = parser
        self.data = {}

    def extract_basic_properties(self, data: Dict[str, Any]) -> Dict[str, Any]:
        """Extract common Unity ScriptableObject properties"""
        return {
            'id': data.get('ID', ''),
            'unlocked_by_default': data.get('UnlockedByDefault', False),
            'evolve_level': data.get('EvolveLevel', 0),
            'starting_level': data.get('StartingLevel', 0),
            'name_loc_key': data.get('_nameLocKey', ''),
            'troop_category': data.get('ThisTroopCategory', 0),
            'included_in_level_generation': data.get('IncludedInLevelGeneration', False),
            'acceptable_level_range': data.get('acceptableLevelRangeForGeneration', {}),
            'unlock_cost_override': data.get('unlockCostOverride', 0),
            'evolution_reference': self.parser.resolve_reference(data.get('EvolvesInto')),
            'gear_reference': self.parser.resolve_reference(data.get('ScriptableGear'))
        }


class TroopExtractor(AssetExtractor):
    """Extract enemy/troop data"""

    def extract_all(self) -> Dict[str, Any]:
        """Extract all troop assets"""
        logger.info("Extracting troops...")

        for filepath in self.parser.unity_path.glob("Troop*.asset"):
            data = self.parser.parse_asset(filepath)
            if data:
                troop_data = {
                    'name': filepath.stem,
                    'filepath': str(filepath),
                    **self.extract_basic_properties(data),
                    # Troop-specific properties
                    'sprite_references': {
                        'ally': self.parser.resolve_reference(data.get('DisplaySpriteAlly')),
                        'enemy': self.parser.resolve_reference(data.get('DisplaySpriteEnemy')),
                        'gear': self.parser.resolve_reference(data.get('DisplaySpriteGear'))
                    },
                    'controllers': {
                        'falling_troop': self.parser.resolve_reference(data.get('fallingTroop')),
                        'troop_controller': self.parser.resolve_reference(data.get('troopController'))
                    }
                }
                self.data[filepath.stem] = troop_data

        logger.info(f"Extracted {len(self.data)} troops")
        return self.data


class StructureExtractor(AssetExtractor):
    """Extract structure data"""

    def extract_all(self) -> Dict[str, Any]:
        """Extract all structure assets"""
        logger.info("Extracting structures...")

        patterns = ["*Structure*.asset", "City_*.asset", "Desert_*.asset", "Forest_*.asset", "Snow_*.asset"]
        structure_files = set()

        for pattern in patterns:
            structure_files.update(self.parser.unity_path.glob(pattern))

        for filepath in structure_files:
            data = self.parser.parse_asset(filepath)
            if data:
                structure_data = {
                    'name': filepath.stem,
                    'filepath': str(filepath),
                    'environmental_theme': self._determine_theme(filepath.stem),
                    **self.extract_basic_properties(data)
                }
                self.data[filepath.stem] = structure_data

        logger.info(f"Extracted {len(self.data)} structures")
        return self.data

    def _determine_theme(self, name: str) -> str:
        """Determine environmental theme from name"""
        name_lower = name.lower()
        themes = ['city', 'desert', 'forest', 'snow', 'volcano']

        for theme in themes:
            if theme in name_lower:
                return theme.title()

        return 'Generic' if 'structure' in name_lower else 'Unknown'


class GearExtractor(AssetExtractor):
    """Extract gear data"""

    def extract_all(self) -> Dict[str, Any]:
        """Extract all gear assets"""
        logger.info("Extracting gears...")

        for filepath in self.parser.unity_path.glob("Gear*.asset"):
            data = self.parser.parse_asset(filepath)
            if data:
                gear_data = {
                    'name': filepath.stem,
                    'filepath': str(filepath),
                    'id': data.get('ID', ''),
                    'm_name': data.get('m_Name', ''),
                    'level': data.get('Level', 0),
                    'cost': data.get('Cost', 0),
                    'gear_type': data.get('GearType', ''),
                    'rarity': data.get('Rarity', {}),
                    'description_key': data.get('DescriptionKey', ''),
                    'icon_reference': self.parser.resolve_reference(data.get('Icon'))
                }
                self.data[filepath.stem] = gear_data

        logger.info(f"Extracted {len(self.data)} gears")
        return self.data


class AnimationBehaviorExtractor(AssetExtractor):
    """Extract animation behavior data"""

    def extract_all(self) -> Dict[str, Any]:
        """Extract all animation behavior assets"""
        logger.info("Extracting animation behaviors...")

        behavior_patterns = ["*Behavior*.asset", "*Animation*.asset", "*Effect*.asset"]
        behavior_files = set()

        for pattern in behavior_patterns:
            behavior_files.update(self.parser.unity_path.glob(pattern))

        for filepath in behavior_files:
            data = self.parser.parse_asset(filepath)
            if data:
                behavior_data = {
                    'name': filepath.stem,
                    'filepath': str(filepath),
                    **self.extract_basic_properties(data),
                    # Animation-specific properties
                    'amplitude': data.get('amplitude', 0),
                    'frequency': data.get('frequency', 0),
                    'wave_size': data.get('waveSize', 0),
                    'behavior_type': data.get('BehaviorType', ''),
                    'duration': data.get('Duration', 0),
                    'loop_type': data.get('LoopType', ''),
                    'ease_type': data.get('EaseType', ''),
                    'target_reference': self.parser.resolve_reference(data.get('Target')),
                    'prefab_reference': self.parser.resolve_reference(data.get('Prefab'))
                }
                self.data[filepath.stem] = behavior_data

        logger.info(f"Extracted {len(self.data)} animation behaviors")
        return self.data


class CurrencyExtractor(AssetExtractor):
    """Extract currency and economy data"""

    def extract_all(self) -> Dict[str, Any]:
        """Extract all currency assets"""
        logger.info("Extracting currencies...")

        currency_patterns = ["*Currency*.asset", "*Coin*.asset", "*Diamond*.asset", "*Gem*.asset"]
        currency_files = set()

        for pattern in currency_patterns:
            currency_files.update(self.parser.unity_path.glob(pattern))

        for filepath in currency_files:
            data = self.parser.parse_asset(filepath)
            if data:
                currency_data = {
                    'name': filepath.stem,
                    'filepath': str(filepath),
                    **self.extract_basic_properties(data),
                    # Currency-specific properties
                    'currency_type': data.get('CurrencyType', ''),
                    'base_value': data.get('BaseValue', 0),
                    'exchange_rate': data.get('ExchangeRate', 1.0),
                    'max_capacity': data.get('MaxCapacity', 0),
                    'purchase_options': data.get('PurchaseOptions', []),
                    'icon_reference': self.parser.resolve_reference(data.get('Icon')),
                    'display_format': data.get('DisplayFormat', '')
                }
                self.data[filepath.stem] = currency_data

        logger.info(f"Extracted {len(self.data)} currencies")
        return self.data


class QuestExtractor(AssetExtractor):
    """Extract quest and achievement data"""

    def extract_all(self) -> Dict[str, Any]:
        """Extract all quest assets"""
        logger.info("Extracting quests...")

        quest_patterns = ["Quest*.asset", "*Mission*.asset", "*Achievement*.asset", "*Task*.asset"]
        quest_files = set()

        for pattern in quest_patterns:
            quest_files.update(self.parser.unity_path.glob(pattern))

        for filepath in quest_files:
            data = self.parser.parse_asset(filepath)
            if data:
                quest_data = {
                    'name': filepath.stem,
                    'filepath': str(filepath),
                    **self.extract_basic_properties(data),
                    # Quest-specific properties
                    'quest_type': data.get('QuestType', ''),
                    'target_count': data.get('TargetCount', 0),
                    'current_progress': data.get('CurrentProgress', 0),
                    'completion_reward': data.get('CompletionReward', {}),
                    'requirements': data.get('Requirements', []),
                    'daily_quest': data.get('DailyQuest', False),
                    'weekly_quest': data.get('WeeklyQuest', False),
                    'description_key': data.get('DescriptionKey', ''),
                    'icon_reference': self.parser.resolve_reference(data.get('Icon'))
                }
                self.data[filepath.stem] = quest_data

        logger.info(f"Extracted {len(self.data)} quests")
        return self.data


class GearFightExtractor:
    """Main orchestrator for all extraction"""

    def __init__(self, unity_path: str = "UnityProject/MonoBehaviour"):
        self.parser = UnityParser(unity_path)
        self.extractors = {
            'troops': TroopExtractor(self.parser),
            'structures': StructureExtractor(self.parser),
            'gears': GearExtractor(self.parser),
            'behaviors': AnimationBehaviorExtractor(self.parser),
            'currencies': CurrencyExtractor(self.parser),
            'quests': QuestExtractor(self.parser)
        }
        self.results = {}

    def extract_all(self) -> Dict[str, Any]:
        """Extract all game data"""
        logger.info("Starting complete extraction...")

        # Run all extractors
        for name, extractor in self.extractors.items():
            self.results[name] = extractor.extract_all()

        # Compile final results
        return {
            'metadata': {
                'extraction_date': datetime.now().isoformat(),
                'version': 'Gear Fight 5.1.3',
                'extractor_version': '2.0 - Clean Architecture',
                'total_assets': sum(len(data) for data in self.results.values()),
                'asset_counts': {name: len(data) for name, data in self.results.items()}
            },
            'data': self.results,
            'statistics': self._generate_statistics()
        }

    def _generate_statistics(self) -> Dict[str, Any]:
        """Generate extraction statistics"""
        stats = {}

        # Troop statistics
        if 'troops' in self.results:
            troops = self.results['troops']
            stats['troops'] = {
                'total': len(troops),
                'with_evolution': sum(1 for t in troops.values() if not t['evolution_reference']['is_null']),
                'with_gear': sum(1 for t in troops.values() if not t['gear_reference']['is_null']),
                'by_category': {}
            }

            # Category breakdown
            for troop in troops.values():
                cat = troop['troop_category']
                stats['troops']['by_category'][f'category_{cat}'] = stats['troops']['by_category'].get(f'category_{cat}', 0) + 1

        # Structure statistics
        if 'structures' in self.results:
            structures = self.results['structures']
            stats['structures'] = {
                'total': len(structures),
                'by_theme': {}
            }

            # Theme breakdown
            for structure in structures.values():
                theme = structure['environmental_theme']
                stats['structures']['by_theme'][theme] = stats['structures']['by_theme'].get(theme, 0) + 1

        # Gear statistics
        if 'gears' in self.results:
            gears = self.results['gears']
            stats['gears'] = {
                'total': len(gears),
                'with_cost': sum(1 for g in gears.values() if g['cost'] > 0)
            }

        return stats

    def save_results(self, output_file: str = "gear_fight_complete_data.json") -> None:
        """Save extraction results"""
        results = self.extract_all()

        # Save main file
        output_path = Path(output_file)
        output_path.write_text(json.dumps(results, indent=2, ensure_ascii=False))

        # Save compact version
        compact_path = output_path.with_suffix('.compact.json')
        compact_path.write_text(json.dumps(results, separators=(',', ':'), ensure_ascii=False))

        # Create API-compatible catalogs
        self._create_api_catalogs(results)

        logger.info(f"Results saved to {output_path} and {compact_path}")
        logger.info("API-compatible catalogs created")

    def _create_api_catalogs(self, results: Dict[str, Any]) -> None:
        """Create backward-compatible API catalog files"""
        data = results['data']
        metadata = results['metadata']

        # Enemies catalog
        if 'troops' in data:
            enemies_catalog = {
                'extraction_info': {
                    'date': metadata['extraction_date'],
                    'version': metadata['extractor_version'],
                    'total_enemies': len(data['troops'])
                },
                'enemies': list(data['troops'].keys()),
                'enemies_detailed': data['troops']
            }
            Path('enemies_catalog_detailed.json').write_text(json.dumps(enemies_catalog, indent=2))

        # Structures catalog
        if 'structures' in data:
            structures_catalog = {
                'extraction_info': {
                    'date': metadata['extraction_date'],
                    'version': metadata['extractor_version'],
                    'total_structures': len(data['structures'])
                },
                'structures': list(data['structures'].keys()),
                'structures_detailed': data['structures']
            }
            Path('structures_catalog_detailed.json').write_text(json.dumps(structures_catalog, indent=2))

        # Gears catalog
        if 'gears' in data:
            gears_catalog = {
                'extraction_info': {
                    'date': metadata['extraction_date'],
                    'version': metadata['extractor_version'],
                    'total_gears': len(data['gears'])
                },
                'gears': list(data['gears'].keys()),
                'gears_detailed': data['gears']
            }
            Path('gears_catalog_detailed.json').write_text(json.dumps(gears_catalog, indent=2))

        # Behaviors catalog
        if 'behaviors' in data:
            behaviors_catalog = {
                'extraction_info': {
                    'date': metadata['extraction_date'],
                    'version': metadata['extractor_version'],
                    'total_behaviors': len(data['behaviors'])
                },
                'behaviors': list(data['behaviors'].keys()),
                'behaviors_detailed': data['behaviors']
            }
            Path('behaviors_catalog_detailed.json').write_text(json.dumps(behaviors_catalog, indent=2))

        # Currencies catalog
        if 'currencies' in data:
            currencies_catalog = {
                'extraction_info': {
                    'date': metadata['extraction_date'],
                    'version': metadata['extractor_version'],
                    'total_currencies': len(data['currencies'])
                },
                'currencies': list(data['currencies'].keys()),
                'currencies_detailed': data['currencies']
            }
            Path('currencies_catalog_detailed.json').write_text(json.dumps(currencies_catalog, indent=2))

        # Quests catalog
        if 'quests' in data:
            quests_catalog = {
                'extraction_info': {
                    'date': metadata['extraction_date'],
                    'version': metadata['extractor_version'],
                    'total_quests': len(data['quests'])
                },
                'quests': list(data['quests'].keys()),
                'quests_detailed': data['quests']
            }
            Path('quests_catalog_detailed.json').write_text(json.dumps(quests_catalog, indent=2))


def main():
    """Main extraction entry point"""
    extractor = GearFightExtractor()
    extractor.save_results()

    # Print summary
    results = extractor.extract_all()
    metadata = results['metadata']
    stats = results['statistics']

    print(f"\n{'='*60}")
    print("🎯 GEAR FIGHT DATA EXTRACTION COMPLETE")
    print(f"{'='*60}")
    print(f"📊 Total Assets: {metadata['total_assets']}")
    print(f"📅 Date: {metadata['extraction_date']}")
    print(f"🎮 Game: {metadata['version']}")

    print(f"\n📋 Asset Breakdown:")
    for asset_type, count in metadata['asset_counts'].items():
        print(f"   • {asset_type.title()}: {count}")

    if 'troops' in stats:
        troop_stats = stats['troops']
        print(f"\n🎯 Troop Analysis:")
        print(f"   • With Evolution: {troop_stats['with_evolution']}/{troop_stats['total']}")
        print(f"   • With Gear: {troop_stats['with_gear']}/{troop_stats['total']}")

    if 'structures' in stats:
        structure_stats = stats['structures']
        print(f"\n🏗️ Structure Analysis:")
        for theme, count in structure_stats['by_theme'].items():
            print(f"   • {theme}: {count}")

    print(f"\n✅ Ready for API integration!")


if __name__ == "__main__":
    main()