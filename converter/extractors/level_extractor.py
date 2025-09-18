#!/usr/bin/env python3
"""
Level extraction module
Extracts level configuration data from Unity assets
"""

import json
import sys
from pathlib import Path

# Add parent directory to path for imports
sys.path.insert(0, str(Path(__file__).parent.parent))

from utils.yaml_parser import UnityYAMLParser, UnityAssetScanner
from constants.unity_guids import UnityGUIDManager

class LevelExtractor:
    """Extracts level data from Unity assets"""
    
    def __init__(self, unity_project_path, guid_manager=None):
        self.unity_path = Path(unity_project_path)
        self.guid_manager = guid_manager or UnityGUIDManager()
        self.parser = UnityYAMLParser()
        
    def extract_all_levels(self):
        """Extract all level definitions from Unity assets"""
        print("📋 Scanning for level assets...")
        
        # Find all Level asset files
        level_files = UnityAssetScanner.scan_for_levels(self.unity_path)
        print(f"Found {len(level_files)} level asset files")
        
        levels_data = {}
        worlds_data = {}
        
        for level_file in level_files:
            level_data = self._extract_level_from_file(level_file)
            if level_data:
                level_id = f"{level_data['world']}_{level_data['level']}"
                levels_data[level_id] = level_data
                
                # Track worlds
                world_num = level_data['world']
                if world_num not in worlds_data:
                    worlds_data[world_num] = []
                worlds_data[world_num].append(level_data)
        
        # Sort levels within worlds
        for world_levels in worlds_data.values():
            world_levels.sort(key=lambda x: x['level'])
        
        # Generate statistics
        stats = self._generate_level_statistics(levels_data, worlds_data)
        
        return {
            'levels': levels_data,
            'worlds': worlds_data,
            'statistics': stats,
            'extraction_info': {
                'total_files_scanned': len(level_files),
                'total_levels_found': len(levels_data),
                'worlds_found': len(worlds_data)
            }
        }
    
    def _extract_level_from_file(self, level_file):
        """Extract level data from a single Unity asset file"""
        try:
            asset_data = self.parser.load_unity_asset(level_file)
            if not asset_data:
                return None
            
            # Extract basic properties
            properties = self.parser.extract_asset_properties(asset_data)
            file_refs = self.parser.extract_file_references(asset_data)
            
            # Parse level name to extract world and level numbers
            level_name = properties.get('name', level_file.stem)
            world_num, level_num = self._parse_level_name(level_name)
            
            # Build level definition
            level_data = {
                'name': level_name,
                'world': world_num,
                'level': level_num,
                'level_id': f"{world_num}_{level_num}",
                'id': properties.get('ID', ''),
                'sort_key': world_num * 1000 + level_num,  # For sorting
                'file_path': str(level_file),
                'file_references': file_refs
            }
            
            # Extract level-specific properties
            level_properties = [
                'useCustomFights', 'useCustomGears', 'puzzleConfiguration',
                'startingCoins', 'numLevels', 'numberOfSpinners',
                'tutorialSkipString'
            ]
            
            for prop in level_properties:
                if prop in properties:
                    level_data[prop] = properties[prop]
            
            # Extract custom level grid reference
            custom_grid = properties.get('customLevelGrid', {})
            if not self.parser.is_null_reference(custom_grid):
                level_data['custom_grid_guid'] = file_refs.get('customLevelGrid')
                if self.guid_manager:
                    grid_name = self.guid_manager.get_asset_name(
                        file_refs.get('customLevelGrid', '')
                    )
                    if grid_name != f"Unknown_{file_refs.get('customLevelGrid', '')}":
                        level_data['custom_grid'] = grid_name
            
            return level_data
            
        except Exception as e:
            print(f"Error extracting level from {level_file}: {e}")
            return None
    
    def _parse_level_name(self, level_name):
        """Parse level name to extract world and level numbers"""
        # Expected format: "World X - Level Y"
        # Example: "World 1 - Level 1"
        
        try:
            parts = level_name.split(' - ')
            if len(parts) == 2:
                world_part = parts[0].replace('World ', '')
                level_part = parts[1].replace('Level ', '')
                
                world_num = int(world_part)
                level_num = int(level_part)
                
                return world_num, level_num
        except (ValueError, IndexError):
            pass
        
        # Fallback: try to extract numbers from filename
        import re
        numbers = re.findall(r'\d+', level_name)
        if len(numbers) >= 2:
            return int(numbers[0]), int(numbers[1])
        elif len(numbers) == 1:
            return 1, int(numbers[0])
        
        return 1, 1  # Default fallback
    
    def _generate_level_statistics(self, levels_data, worlds_data):
        """Generate statistics about extracted levels"""
        stats = {
            'total_levels': len(levels_data),
            'total_worlds': len(worlds_data),
            'levels_per_world': {world: len(levels) for world, levels in worlds_data.items()},
            'custom_fights_levels': 0,
            'custom_gears_levels': 0,
            'tutorial_levels': 0,
            'with_custom_grids': 0
        }
        
        for level in levels_data.values():
            if level.get('useCustomFights', 0) == 1:
                stats['custom_fights_levels'] += 1
            if level.get('useCustomGears', 0) == 1:
                stats['custom_gears_levels'] += 1
            if level.get('tutorialSkipString'):
                stats['tutorial_levels'] += 1
            if 'custom_grid' in level:
                stats['with_custom_grids'] += 1
        
        return stats
    
    def save_levels_data(self, output_path, levels_data):
        """Save levels data to JSON file"""
        try:
            with open(output_path, 'w') as f:
                json.dump(levels_data, f, indent=2)
            
            print(f"✅ Saved levels data to {output_path}")
            print(f"   Total levels: {levels_data['statistics']['total_levels']}")
            print(f"   Total worlds: {levels_data['statistics']['total_worlds']}")
            
            return levels_data
            
        except Exception as e:
            print(f"❌ Error saving levels data: {e}")
            return None
