#!/usr/bin/env python3
"""
Enemy/Troop extraction module
Extracts ALL enemy definitions from Unity data
"""

import json
import sys
from pathlib import Path

# Add parent directory to path for imports
sys.path.insert(0, str(Path(__file__).parent.parent))

from utils.yaml_parser import UnityYAMLParser, UnityAssetScanner
from constants.unity_guids import UnityGUIDManager
from constants.game_constants import (
    UNITY_MONOBEHAVIOUR_PATH, TROOP_CATEGORIES, EXPECTED_ENEMIES
)

class EnemyExtractor:
    """Extracts enemy data from Unity assets"""
    
    def __init__(self, unity_project_path, guid_manager=None):
        self.unity_path = Path(unity_project_path)
        self.guid_manager = guid_manager or UnityGUIDManager()
        self.parser = UnityYAMLParser()
        
    def extract_all_enemies(self):
        """Extract all enemy/troop definitions from Unity assets"""
        print("🔍 Scanning for enemy assets...")
        
        # Find all Troop asset files
        troop_files = UnityAssetScanner.scan_for_troops(self.unity_path)
        print(f"Found {len(troop_files)} troop asset files")
        
        enemies_data = {}
        enemy_categories = {}
        level_ranges = {}
        
        for troop_file in troop_files:
            enemy_data = self._extract_enemy_from_file(troop_file)
            if enemy_data:
                enemy_name = enemy_data['name']
                enemies_data[enemy_name] = enemy_data
                
                # Track categories
                category = enemy_data.get('category')
                if category not in enemy_categories:
                    enemy_categories[category] = []
                enemy_categories[category].append(enemy_name)
                
                # Track level ranges
                level_range = enemy_data.get('level_range')
                if level_range:
                    level_ranges[enemy_name] = level_range
        
        # Generate statistics
        stats = self._generate_enemy_statistics(enemies_data, enemy_categories)
        
        return {
            'enemies': enemies_data,
            'categories': enemy_categories,
            'level_ranges': level_ranges,
            'statistics': stats,
            'extraction_info': {
                'total_files_scanned': len(troop_files),
                'total_enemies_found': len(enemies_data),
                'expected_enemies_found': sum(1 for name in EXPECTED_ENEMIES if name in enemies_data),
                'missing_expected': [name for name in EXPECTED_ENEMIES if name not in enemies_data]
            }
        }
    
    def _extract_enemy_from_file(self, troop_file):
        """Extract enemy data from a single Unity asset file"""
        try:
            asset_data = self.parser.load_unity_asset(troop_file)
            if not asset_data:
                return None
            
            # Extract basic properties
            properties = self.parser.extract_asset_properties(asset_data)
            file_refs = self.parser.extract_file_references(asset_data)
            
            # Build enemy definition
            enemy_data = {
                'name': properties.get('name', troop_file.stem),
                'id': properties.get('ID', ''),
                'unlocked_by_default': bool(properties.get('UnlockedByDefault', 0)),
                'evolve_level': properties.get('EvolveLevel', 0),
                'starting_level': properties.get('StartingLevel', 1),
                'category_id': properties.get('ThisTroopCategory', 1),
                'category': TROOP_CATEGORIES.get(properties.get('ThisTroopCategory', 1), 'Unknown'),
                'included_in_generation': bool(properties.get('IncludedInLevelGeneration', 0)),
                'level_range': self.parser.extract_vector2(
                    properties.get('acceptableLevelRangeForGeneration', {})
                ),
                'name_loc_key': properties.get('_nameLocKey', ''),
                'unlock_cost_override': properties.get('unlockCostOverride', 0),
                'override_unlock_cost': bool(properties.get('overrideUnlockCost', 0)),
                'file_path': str(troop_file),
                'file_references': file_refs
            }
            
            # Extract evolution chain
            evolves_into = properties.get('EvolvesInto', {})
            if not self.parser.is_null_reference(evolves_into):
                enemy_data['evolves_into_guid'] = file_refs.get('EvolvesInto')
                if self.guid_manager:
                    evolved_name = self.guid_manager.get_asset_name(
                        file_refs.get('EvolvesInto', '')
                    )
                    if evolved_name != f"Unknown_{file_refs.get('EvolvesInto', '')}":
                        enemy_data['evolves_into'] = evolved_name
            
            # Extract gear reference
            scriptable_gear = properties.get('ScriptableGear', {})
            if not self.parser.is_null_reference(scriptable_gear):
                enemy_data['gear_guid'] = file_refs.get('ScriptableGear')
                if self.guid_manager:
                    gear_name = self.guid_manager.get_asset_name(
                        file_refs.get('ScriptableGear', '')
                    )
                    if gear_name != f"Unknown_{file_refs.get('ScriptableGear', '')}":
                        enemy_data['associated_gear'] = gear_name
            
            return enemy_data
            
        except Exception as e:
            print(f"Error extracting enemy from {troop_file}: {e}")
            return None
    
    def _generate_enemy_statistics(self, enemies_data, categories):
        """Generate statistics about extracted enemies"""
        stats = {
            'total_enemies': len(enemies_data),
            'by_category': {cat: len(enemies) for cat, enemies in categories.items()},
            'evolution_chains': 0,
            'level_generation_included': 0,
            'unlocked_by_default': 0,
            'has_custom_gear': 0
        }
        
        for enemy in enemies_data.values():
            if 'evolves_into' in enemy:
                stats['evolution_chains'] += 1
            if enemy.get('included_in_generation'):
                stats['level_generation_included'] += 1
            if enemy.get('unlocked_by_default'):
                stats['unlocked_by_default'] += 1
            if 'associated_gear' in enemy:
                stats['has_custom_gear'] += 1
        
        return stats
    
    def save_enemies_catalog(self, output_path, enemies_data):
        """Save enemies catalog to JSON file"""
        try:
            # Create simplified catalog for compatibility
            catalog_data = {
                'enemies': sorted(list(enemies_data['enemies'].keys())),
                'total': len(enemies_data['enemies']),
                'categories': enemies_data['categories'],
                'statistics': enemies_data['statistics'],
                'level_ranges': enemies_data['level_ranges'],
                'extraction_info': enemies_data['extraction_info'],
                'guid_mappings': {
                    enemy_data.get('id', ''): f"{enemy_name}.asset"
                    for enemy_name, enemy_data in enemies_data['enemies'].items()
                    if enemy_data.get('id')
                }
            }
            
            with open(output_path, 'w') as f:
                json.dump(catalog_data, f, indent=2)
            
            print(f"✅ Saved enemies catalog to {output_path}")
            print(f"   Total enemies: {catalog_data['total']}")
            print(f"   Categories: {list(catalog_data['categories'].keys())}")
            
            return catalog_data
            
        except Exception as e:
            print(f"❌ Error saving enemies catalog: {e}")
            return None
