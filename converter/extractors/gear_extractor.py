#!/usr/bin/env python3
"""
Gear extraction module
Extracts gear/equipment definitions from Unity data
"""

import json
import sys
from pathlib import Path

# Add parent directory to path for imports
sys.path.insert(0, str(Path(__file__).parent.parent))

from utils.yaml_parser import UnityYAMLParser, UnityAssetScanner
from constants.unity_guids import UnityGUIDManager

class GearExtractor:
    """Extracts gear data from Unity assets"""
    
    def __init__(self, unity_project_path, guid_manager=None):
        self.unity_path = Path(unity_project_path)
        self.guid_manager = guid_manager or UnityGUIDManager()
        self.parser = UnityYAMLParser()
        
    def extract_all_gear(self):
        """Extract all gear definitions from Unity assets"""
        print("⚙️ Scanning for gear assets...")
        
        # Find all Gear asset files
        gear_files = UnityAssetScanner.find_assets(
            self.unity_path / 'MonoBehaviour', 'Gear*.asset'
        )
        print(f"Found {len(gear_files)} gear asset files")
        
        gear_data = {}
        gear_categories = {}
        
        for gear_file in gear_files:
            gear_info = self._extract_gear_from_file(gear_file)
            if gear_info:
                gear_name = gear_info['name']
                gear_data[gear_name] = gear_info
                
                # Track categories if available
                category = gear_info.get('category', 'Unknown')
                if category not in gear_categories:
                    gear_categories[category] = []
                gear_categories[category].append(gear_name)
        
        # Generate statistics
        stats = self._generate_gear_statistics(gear_data, gear_categories)
        
        return {
            'gear': gear_data,
            'categories': gear_categories,
            'statistics': stats,
            'extraction_info': {
                'total_files_scanned': len(gear_files),
                'total_gear_found': len(gear_data)
            }
        }
    
    def _extract_gear_from_file(self, gear_file):
        """Extract gear data from a single Unity asset file"""
        try:
            asset_data = self.parser.load_unity_asset(gear_file)
            if not asset_data:
                return None
            
            # Extract basic properties
            properties = self.parser.extract_asset_properties(asset_data)
            file_refs = self.parser.extract_file_references(asset_data)
            
            # Build gear definition
            gear_data = {
                'name': properties.get('name', gear_file.stem),
                'id': properties.get('ID', ''),
                'file_path': str(gear_file),
                'file_references': file_refs
            }
            
            # Extract gear-specific properties
            gear_properties = [
                'rarity', 'cost', 'level', 'damage', 'health', 'defense',
                'speed', 'range', 'description', 'category'
            ]
            
            for prop in gear_properties:
                if prop in properties:
                    gear_data[prop] = properties[prop]
            
            return gear_data
            
        except Exception as e:
            print(f"Error extracting gear from {gear_file}: {e}")
            return None
    
    def _generate_gear_statistics(self, gear_data, categories):
        """Generate statistics about extracted gear"""
        stats = {
            'total_gear': len(gear_data),
            'by_category': {cat: len(items) for cat, items in categories.items()}
        }
        
        return stats
    
    def save_gear_catalog(self, output_path, gear_data):
        """Save gear catalog to JSON file"""
        try:
            with open(output_path, 'w') as f:
                json.dump(gear_data, f, indent=2)
            
            print(f"✅ Saved gear catalog to {output_path}")
            print(f"   Total gear: {gear_data['statistics']['total_gear']}")
            
            return gear_data
            
        except Exception as e:
            print(f"❌ Error saving gear catalog: {e}")
            return None
