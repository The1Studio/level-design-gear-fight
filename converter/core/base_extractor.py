#!/usr/bin/env python3
"""
Base Extractor - Abstract base class for all specialized extractors
Implements common patterns documented in the Level System analysis
"""

from abc import ABC, abstractmethod
from pathlib import Path
from typing import Dict, List, Any, Optional, Pattern
import re
import logging

from .unity_parser import UnityYAMLParser

logger = logging.getLogger(__name__)

class BaseExtractor(ABC):
    """
    Abstract base class for specialized asset extractors

    Based on documented patterns from LEVEL_SYSTEM_DETAILED_DOCS:
    - Implements common Unity YAML parsing
    - Provides GUID resolution utilities
    - Enforces consistent extraction interface
    """

    def __init__(self, base_path: str = "UnityProject/MonoBehaviour"):
        self.base_path = Path(base_path)
        self.parser = UnityYAMLParser()
        self.extracted_data = {}

    @property
    @abstractmethod
    def file_patterns(self) -> List[str]:
        """File patterns to match for this extractor type"""
        pass

    @property
    @abstractmethod
    def asset_type_name(self) -> str:
        """Human-readable name for this asset type"""
        pass

    @abstractmethod
    def extract_single_asset(self, filepath: Path, data: Dict[str, Any]) -> Optional[Dict[str, Any]]:
        """Extract data from a single asset file"""
        pass

    def get_matching_files(self) -> List[Path]:
        """Get all files matching this extractor's patterns"""
        matching_files = []

        for pattern in self.file_patterns:
            matching_files.extend(self.base_path.glob(pattern))

        # Remove duplicates while preserving order
        seen = set()
        unique_files = []
        for file in matching_files:
            if file not in seen:
                seen.add(file)
                unique_files.append(file)

        return unique_files

    def extract_all(self) -> Dict[str, Dict[str, Any]]:
        """Extract all assets of this type"""
        logger.info(f"Extracting {self.asset_type_name}...")

        matching_files = self.get_matching_files()
        logger.info(f"Found {len(matching_files)} {self.asset_type_name} files")

        extracted_count = 0

        for filepath in matching_files:
            try:
                # Parse Unity YAML
                data = self.parser.parse_unity_yaml(filepath)
                if not data:
                    logger.warning(f"Failed to parse {filepath}")
                    continue

                # Extract asset-specific data
                asset_data = self.extract_single_asset(filepath, data)
                if asset_data:
                    asset_name = asset_data.get('name', filepath.stem)
                    self.extracted_data[asset_name] = asset_data
                    extracted_count += 1

            except Exception as e:
                logger.error(f"Error extracting {filepath}: {e}")

        logger.info(f"Extracted {extracted_count} {self.asset_type_name} assets")
        return self.extracted_data

    def get_extraction_stats(self) -> Dict[str, Any]:
        """Get statistics about the extraction"""
        return {
            'asset_type': self.asset_type_name,
            'total_extracted': len(self.extracted_data),
            'file_patterns': self.file_patterns,
            'assets': list(self.extracted_data.keys())
        }

    # Utility methods for common extraction patterns

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
            'only_included_in_scenes': data.get('onlyIncludedInTheseScenes', []),
            'show_fullscreen_popup_when_unlocked': data.get('ShowFullScreenPopupWhenUnlocked', False),
            'override_unlock_cost': data.get('overrideUnlockCost', False),
            'unlock_cost_override': data.get('unlockCostOverride', 0),
            'anchored_position_offset': data.get('AnchoredPositionOffsetForPackDisplay', {})
        }

    def extract_evolution_data(self, data: Dict[str, Any]) -> Optional[Dict[str, Any]]:
        """Extract evolution reference data"""
        evolves_into_ref = self.parser.extract_unity_reference(data.get('EvolvesInto'))
        return evolves_into_ref if not evolves_into_ref['is_null'] else None

    def extract_gear_reference(self, data: Dict[str, Any]) -> Optional[Dict[str, Any]]:
        """Extract associated gear reference"""
        gear_ref = self.parser.extract_unity_reference(data.get('ScriptableGear'))
        return gear_ref if not gear_ref['is_null'] else None

    def extract_sprite_references(self, data: Dict[str, Any]) -> Dict[str, Optional[str]]:
        """Extract all sprite reference GUIDs"""
        return {
            'display_sprite_ally': self.parser.extract_guid(data.get('DisplaySpriteAlly')),
            'display_sprite_enemy': self.parser.extract_guid(data.get('DisplaySpriteEnemy')),
            'display_sprite_gear': self.parser.extract_guid(data.get('DisplaySpriteGear')),
            'display_sprite_upgrade_button': self.parser.extract_guid(data.get('DisplaySpriteForUpgradeButton'))
        }

    def extract_controller_references(self, data: Dict[str, Any]) -> Dict[str, Optional[str]]:
        """Extract controller reference GUIDs"""
        return {
            'falling_troop': self.parser.extract_guid(data.get('fallingTroop')),
            'troop_controller': self.parser.extract_guid(data.get('troopController'))
        }