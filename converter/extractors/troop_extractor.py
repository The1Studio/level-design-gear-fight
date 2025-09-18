#!/usr/bin/env python3
"""
Troop/Enemy Extractor - Specialized extractor for enemy assets
Based on 04_ENEMY_TROOP_SYSTEM.md documentation and ScriptableTroop analysis
"""

from pathlib import Path
from typing import Dict, List, Any, Optional
import logging

from ..core.base_extractor import BaseExtractor

logger = logging.getLogger(__name__)

class TroopExtractor(BaseExtractor):
    """
    Specialized extractor for Troop/Enemy assets

    Extracts detailed properties from Troop*.asset files including:
    - Basic troop properties (level, category, unlock cost)
    - Evolution chains and relationships
    - Level generation parameters
    - Associated gear and sprite references
    - Combat controller references

    Based on documented patterns in 04_ENEMY_TROOP_SYSTEM.md
    """

    @property
    def file_patterns(self) -> List[str]:
        """File patterns for troop assets"""
        return ["Troop*.asset"]

    @property
    def asset_type_name(self) -> str:
        """Human-readable name for troop assets"""
        return "Troops/Enemies"

    def extract_single_asset(self, filepath: Path, data: Dict[str, Any]) -> Optional[Dict[str, Any]]:
        """
        Extract detailed data from a single troop asset

        Returns comprehensive troop data including all properties
        documented in the enemy system analysis
        """
        try:
            troop_name = filepath.stem

            # Extract basic Unity ScriptableObject properties
            basic_props = self.extract_basic_properties(data)

            # Extract evolution data
            evolution_data = self.extract_evolution_data(data)

            # Extract associated gear reference
            gear_reference = self.extract_gear_reference(data)

            # Extract sprite references for UI display
            sprite_refs = self.extract_sprite_references(data)

            # Extract controller references for gameplay
            controller_refs = self.extract_controller_references(data)

            # Combine all extracted data
            troop_data = {
                'name': troop_name,
                'file_path': str(filepath),
                **basic_props,
                'evolution_chain': evolution_data,
                'associated_gear': gear_reference,
                'sprite_references': sprite_refs,
                'controller_references': controller_refs,
                # Additional troop-specific properties
                'extraction_metadata': {
                    'source_file': str(filepath),
                    'extraction_method': 'TroopExtractor v1.0',
                    'documented_in': '04_ENEMY_TROOP_SYSTEM.md'
                }
            }

            return troop_data

        except Exception as e:
            logger.error(f"Error extracting troop {filepath}: {e}")
            return None

    def get_troop_categories(self) -> Dict[int, List[str]]:
        """
        Get troops organized by category

        Based on documented troop category system:
        - Category 0: Basic troops
        - Category 1: Elite troops
        - Category 2: Boss troops
        - Category 3: Structures/Environmental
        """
        categories = {}

        for troop_name, troop_data in self.extracted_data.items():
            category = troop_data.get('troop_category', 0)
            if category not in categories:
                categories[category] = []
            categories[category].append(troop_name)

        return categories

    def get_evolution_chains(self) -> Dict[str, List[str]]:
        """
        Build complete evolution chains for all troops

        Returns dictionary where keys are base troop names
        and values are complete evolution chains
        """
        evolution_chains = {}

        for troop_name, troop_data in self.extracted_data.items():
            evolution = troop_data.get('evolution_chain')
            if evolution and not evolution['is_null']:
                # This troop evolves into something
                base_troop = troop_name
                chain = [base_troop]

                # Follow the evolution chain
                current = evolution['name']
                seen = {base_troop}  # Prevent infinite loops

                while current and current in self.extracted_data and current not in seen:
                    chain.append(current)
                    seen.add(current)

                    next_evolution = self.extracted_data[current].get('evolution_chain')
                    if next_evolution and not next_evolution['is_null']:
                        current = next_evolution['name']
                    else:
                        break

                if len(chain) > 1:  # Only store actual chains
                    evolution_chains[base_troop] = chain

        return evolution_chains

    def get_level_generation_troops(self) -> Dict[str, Dict[str, Any]]:
        """
        Get troops that are included in procedural level generation

        Based on documented procedural generation system that uses
        IncludedInLevelGeneration flag and acceptableLevelRangeForGeneration
        """
        generation_troops = {}

        for troop_name, troop_data in self.extracted_data.items():
            if troop_data.get('included_in_level_generation', False):
                level_range = troop_data.get('acceptable_level_range', {})
                generation_troops[troop_name] = {
                    'min_level': level_range.get('x', 0),
                    'max_level': level_range.get('y', 0),
                    'troop_category': troop_data.get('troop_category', 0),
                    'evolve_level': troop_data.get('evolve_level', 0)
                }

        return generation_troops

    def get_extraction_summary(self) -> Dict[str, Any]:
        """Get comprehensive summary of troop extraction"""
        base_stats = self.get_extraction_stats()

        categories = self.get_troop_categories()
        evolution_chains = self.get_evolution_chains()
        generation_troops = self.get_level_generation_troops()

        return {
            **base_stats,
            'categories': {
                f'category_{cat}': troops for cat, troops in categories.items()
            },
            'category_counts': {
                f'category_{cat}': len(troops) for cat, troops in categories.items()
            },
            'evolution_chains': len(evolution_chains),
            'troops_in_level_generation': len(generation_troops),
            'analysis': {
                'total_evolution_chains': len(evolution_chains),
                'longest_chain': max([len(chain) for chain in evolution_chains.values()]) if evolution_chains else 0,
                'procedural_generation_coverage': f"{len(generation_troops)}/{len(self.extracted_data)} troops"
            }
        }