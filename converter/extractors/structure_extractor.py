#!/usr/bin/env python3
"""
Structure Extractor - Specialized extractor for environmental structure assets
Based on analysis of structure patterns and environmental themes
"""

from pathlib import Path
from typing import Dict, List, Any, Optional
import logging

from ..core.base_extractor import BaseExtractor

logger = logging.getLogger(__name__)

class StructureExtractor(BaseExtractor):
    """
    Specialized extractor for Structure assets

    Extracts detailed properties from structure files including:
    - Environmental structure properties
    - Theme-based organization (City, Desert, Forest, Snow, etc.)
    - Level generation parameters
    - Associated effects and interactions

    Based on documented environmental themes and structure system
    """

    @property
    def file_patterns(self) -> List[str]:
        """File patterns for structure assets"""
        return [
            "*Structure*.asset",
            "City_*.asset",
            "Desert_*.asset",
            "Forest_*.asset",
            "Snow_*.asset",
            "Volcano_*.asset"
        ]

    @property
    def asset_type_name(self) -> str:
        """Human-readable name for structure assets"""
        return "Environmental Structures"

    def extract_single_asset(self, filepath: Path, data: Dict[str, Any]) -> Optional[Dict[str, Any]]:
        """
        Extract detailed data from a single structure asset

        Returns comprehensive structure data including environmental
        theme classification and gameplay properties
        """
        try:
            structure_name = filepath.stem

            # Extract basic Unity ScriptableObject properties
            basic_props = self.extract_basic_properties(data)

            # Extract evolution data (structures can evolve too)
            evolution_data = self.extract_evolution_data(data)

            # Extract associated gear reference
            gear_reference = self.extract_gear_reference(data)

            # Extract sprite references
            sprite_refs = self.extract_sprite_references(data)

            # Determine environmental theme from name
            theme = self._determine_environmental_theme(structure_name)

            # Extract structure-specific properties
            structure_specific = self._extract_structure_specific_properties(data)

            # Combine all extracted data
            structure_data = {
                'name': structure_name,
                'file_path': str(filepath),
                'environmental_theme': theme,
                **basic_props,
                **structure_specific,
                'evolution_chain': evolution_data,
                'associated_gear': gear_reference,
                'sprite_references': sprite_refs,
                'extraction_metadata': {
                    'source_file': str(filepath),
                    'extraction_method': 'StructureExtractor v1.0',
                    'environmental_classification': theme
                }
            }

            return structure_data

        except Exception as e:
            logger.error(f"Error extracting structure {filepath}: {e}")
            return None

    def _determine_environmental_theme(self, structure_name: str) -> str:
        """
        Determine environmental theme from structure name

        Based on documented environmental themes:
        - City: Urban structures
        - Desert: Desert/arid environment structures
        - Forest: Forest/nature structures
        - Snow: Snow/winter structures
        - Volcano: Volcanic/lava structures
        """
        name_lower = structure_name.lower()

        if 'city' in name_lower:
            return 'City'
        elif 'desert' in name_lower:
            return 'Desert'
        elif 'forest' in name_lower:
            return 'Forest'
        elif 'snow' in name_lower:
            return 'Snow'
        elif 'volcano' in name_lower:
            return 'Volcano'
        elif 'structure' in name_lower:
            return 'Generic'
        else:
            return 'Unknown'

    def _extract_structure_specific_properties(self, data: Dict[str, Any]) -> Dict[str, Any]:
        """Extract properties specific to structures"""
        return {
            # Structure-specific gameplay properties
            'blocking_properties': data.get('BlockingProperties', {}),
            'interaction_type': data.get('InteractionType', ''),
            'environment_effects': data.get('EnvironmentEffects', []),
            'placement_rules': data.get('PlacementRules', {}),
            'destruction_properties': data.get('DestructionProperties', {}),
            'visual_effects': data.get('VisualEffects', []),
            # Resource/reward properties
            'resource_yield': data.get('ResourceYield', 0),
            'interaction_cost': data.get('InteractionCost', 0),
            'regeneration_time': data.get('RegenerationTime', 0)
        }

    def get_structures_by_theme(self) -> Dict[str, List[str]]:
        """
        Get structures organized by environmental theme

        Returns dictionary where keys are theme names and values
        are lists of structure names in that theme
        """
        themes = {}

        for structure_name, structure_data in self.extracted_data.items():
            theme = structure_data.get('environmental_theme', 'Unknown')
            if theme not in themes:
                themes[theme] = []
            themes[theme].append(structure_name)

        return themes

    def get_interactive_structures(self) -> Dict[str, Dict[str, Any]]:
        """
        Get structures that have interaction capabilities

        Based on interaction_type and associated properties
        """
        interactive_structures = {}

        for structure_name, structure_data in self.extracted_data.items():
            interaction_type = structure_data.get('interaction_type', '')
            if interaction_type:
                interactive_structures[structure_name] = {
                    'interaction_type': interaction_type,
                    'interaction_cost': structure_data.get('interaction_cost', 0),
                    'resource_yield': structure_data.get('resource_yield', 0),
                    'environmental_theme': structure_data.get('environmental_theme', 'Unknown')
                }

        return interactive_structures

    def get_level_generation_structures(self) -> Dict[str, Dict[str, Any]]:
        """
        Get structures included in procedural level generation

        Similar to troops, structures can be procedurally placed
        """
        generation_structures = {}

        for structure_name, structure_data in self.extracted_data.items():
            if structure_data.get('included_in_level_generation', False):
                level_range = structure_data.get('acceptable_level_range', {})
                generation_structures[structure_name] = {
                    'min_level': level_range.get('x', 0),
                    'max_level': level_range.get('y', 0),
                    'environmental_theme': structure_data.get('environmental_theme', 'Unknown'),
                    'troop_category': structure_data.get('troop_category', 0)
                }

        return generation_structures

    def get_extraction_summary(self) -> Dict[str, Any]:
        """Get comprehensive summary of structure extraction"""
        base_stats = self.get_extraction_stats()

        themes = self.get_structures_by_theme()
        interactive = self.get_interactive_structures()
        generation_structures = self.get_level_generation_structures()

        return {
            **base_stats,
            'environmental_themes': themes,
            'theme_counts': {theme: len(structures) for theme, structures in themes.items()},
            'interactive_structures': len(interactive),
            'structures_in_level_generation': len(generation_structures),
            'analysis': {
                'total_themes': len(themes),
                'most_common_theme': max(themes.items(), key=lambda x: len(x[1]))[0] if themes else 'None',
                'interactive_coverage': f"{len(interactive)}/{len(self.extracted_data)} structures",
                'procedural_generation_coverage': f"{len(generation_structures)}/{len(self.extracted_data)} structures"
            }
        }