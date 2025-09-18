#!/usr/bin/env python3
"""
Structure extraction module
Extracts ALL structure definitions from Unity data
"""

import json
import sys
from pathlib import Path

# Add parent directory to path for imports
sys.path.insert(0, str(Path(__file__).parent.parent))

from utils.yaml_parser import UnityYAMLParser, UnityAssetScanner
from constants.unity_guids import UnityGUIDManager
from constants.game_constants import (
    UNITY_MONOBEHAVIOUR_PATH, STRUCTURE_ENVIRONMENTS, TROOP_CATEGORIES
)

class StructureExtractor:
    """Extracts structure data from Unity assets"""
    
    def __init__(self, unity_project_path, guid_manager=None):
        self.unity_path = Path(unity_project_path)
        self.guid_manager = guid_manager or UnityGUIDManager()
        self.parser = UnityYAMLParser()
        
    def extract_all_structures(self):
        """Extract all structure definitions from Unity assets"""
        print("🏗️ Scanning for structure assets...")
        
        # Find all Structure asset files
        structure_files = UnityAssetScanner.scan_for_structures(self.unity_path)
        print(f"Found {len(structure_files)} structure asset files")
        
        structures_data = {}
        environment_types = {}
        
        for structure_file in structure_files:
            structure_data = self._extract_structure_from_file(structure_file)
            if structure_data:
                structure_name = structure_data['name']
                structures_data[structure_name] = structure_data
                
                # Track environment types
                env_type = structure_data.get('environment_type')
                if env_type not in environment_types:
                    environment_types[env_type] = []
                environment_types[env_type].append(structure_name)
        
        # Generate statistics
        stats = self._generate_structure_statistics(structures_data, environment_types)
        
        return {
            'structures': structures_data,
            'environment_types': environment_types,
            'statistics': stats,
            'extraction_info': {
                'total_files_scanned': len(structure_files),
                'total_structures_found': len(structures_data),
                'expected_environments': len(STRUCTURE_ENVIRONMENTS),
                'found_environments': len(environment_types)
            }
        }
    
    def _extract_structure_from_file(self, structure_file):
        """Extract structure data from a single Unity asset file"""
        try:
            asset_data = self.parser.load_unity_asset(structure_file)
            if not asset_data:
                return None
            
            # Extract basic properties
            properties = self.parser.extract_asset_properties(asset_data)
            file_refs = self.parser.extract_file_references(asset_data)
            
            # Parse structure name to extract environment type
            structure_name = properties.get('name', structure_file.stem)
            environment_type, variant_number = self._parse_structure_name(structure_name)
            
            # Build structure definition
            structure_data = {
                'name': structure_name,
                'id': properties.get('ID', ''),
                'environment_type': environment_type,
                'variant_number': variant_number,
                'unlocked_by_default': bool(properties.get('UnlockedByDefault', 0)),
                'evolve_level': properties.get('EvolveLevel', 0),
                'starting_level': properties.get('StartingLevel', 99),  # Most structures start at 99
                'category_id': properties.get('ThisTroopCategory', 3),  # 3 = Structure
                'category': TROOP_CATEGORIES.get(properties.get('ThisTroopCategory', 3), 'Structure'),
                'included_in_generation': bool(properties.get('IncludedInLevelGeneration', 0)),
                'level_range': self.parser.extract_vector2(
                    properties.get('acceptableLevelRangeForGeneration', {})
                ),
                'unlock_cost_override': properties.get('unlockCostOverride', 15),  # Default 15
                'override_unlock_cost': bool(properties.get('overrideUnlockCost', 0)),
                'file_path': str(structure_file),
                'file_references': file_refs
            }
            
            # Extract controller reference (important for structures)
            troop_controller = properties.get('troopController', {})
            if not self.parser.is_null_reference(troop_controller):
                structure_data['controller_guid'] = file_refs.get('troopController')
                if self.guid_manager:
                    controller_name = self.guid_manager.get_asset_name(
                        file_refs.get('troopController', '')
                    )
                    if controller_name != f"Unknown_{file_refs.get('troopController', '')}":
                        structure_data['controller'] = controller_name
            
            return structure_data
            
        except Exception as e:
            print(f"Error extracting structure from {structure_file}: {e}")
            return None
    
    def _parse_structure_name(self, structure_name):
        """Parse structure name to extract environment and variant"""
        # Expected format: EnvironmentType_Structure_Number
        # Examples: Forest_Structure_1, City_Structure_2
        
        parts = structure_name.split('_')
        if len(parts) >= 3 and parts[1] == 'Structure':
            environment_type = parts[0]
            try:
                variant_number = int(parts[2])
            except (ValueError, IndexError):
                variant_number = 1
        else:
            # Fallback parsing
            environment_type = 'Unknown'
            variant_number = 1
            
            # Try to identify environment from name
            for env in STRUCTURE_ENVIRONMENTS:
                if env.lower() in structure_name.lower():
                    environment_type = env
                    break
        
        return environment_type, variant_number
    
    def _generate_structure_statistics(self, structures_data, environment_types):
        """Generate statistics about extracted structures"""
        stats = {
            'total_structures': len(structures_data),
            'by_environment': {env: len(structures) for env, structures in environment_types.items()},
            'variants_per_environment': {},
            'average_unlock_cost': 0,
            'generation_included': 0,
            'has_controller': 0
        }
        
        # Calculate variants per environment
        for env, structures in environment_types.items():
            variant_counts = {}
            for struct_name in structures:
                struct_data = structures_data[struct_name]
                variant = struct_data.get('variant_number', 1)
                variant_counts[variant] = variant_counts.get(variant, 0) + 1
            stats['variants_per_environment'][env] = len(variant_counts)
        
        # Calculate other statistics
        total_cost = 0
        for structure in structures_data.values():
            total_cost += structure.get('unlock_cost_override', 15)
            if structure.get('included_in_generation'):
                stats['generation_included'] += 1
            if 'controller' in structure:
                stats['has_controller'] += 1
        
        if structures_data:
            stats['average_unlock_cost'] = total_cost / len(structures_data)
        
        return stats
    
    def save_structures_catalog(self, output_path, structures_data):
        """Save structures catalog to JSON file"""
        try:
            # Create simplified catalog for compatibility
            catalog_data = {
                'structures': sorted(list(structures_data['structures'].keys())),
                'total': len(structures_data['structures']),
                'environment_types': structures_data['environment_types'],
                'statistics': structures_data['statistics'],
                'extraction_info': structures_data['extraction_info'],
                'detailed_structures': structures_data['structures']  # Full data
            }
            
            with open(output_path, 'w') as f:
                json.dump(catalog_data, f, indent=2)
            
            print(f"✅ Saved structures catalog to {output_path}")
            print(f"   Total structures: {catalog_data['total']}")
            print(f"   Environment types: {list(catalog_data['environment_types'].keys())}")
            
            return catalog_data
            
        except Exception as e:
            print(f"❌ Error saving structures catalog: {e}")
            return None
