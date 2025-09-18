#!/usr/bin/env python3
"""
Unity YAML parsing utilities
"""

import yaml
import re
from pathlib import Path

# Custom Unity YAML loader to handle Unity-specific tags
class UnityLoader(yaml.SafeLoader):
    """Custom YAML loader for Unity assets"""
    pass

def unity_constructor(loader, tag_suffix, node):
    """Constructor for Unity tags"""
    return loader.construct_mapping(node)

# Register Unity tag constructors
UnityLoader.add_multi_constructor('tag:unity3d.com,2011:', unity_constructor)

class UnityYAMLParser:
    """Parser for Unity YAML asset files"""
    
    @staticmethod
    def load_unity_asset(file_path):
        """Load a Unity asset YAML file"""
        try:
            with open(file_path, 'r', encoding='utf-8') as f:
                content = f.read()
            
            # Parse Unity YAML using custom loader
            docs = list(yaml.load_all(content, Loader=UnityLoader))
            
            # Extract MonoBehaviour data (usually the main object)
            monobehaviour_data = None
            for doc in docs:
                if doc and isinstance(doc, dict):
                    # Look for MonoBehaviour key
                    if 'MonoBehaviour' in doc:
                        monobehaviour_data = doc['MonoBehaviour']
                        break
                    # Sometimes the doc is the MonoBehaviour directly
                    elif 'm_Name' in doc or any(key.startswith('<') and key.endswith('>k__BackingField') for key in doc.keys()):
                        monobehaviour_data = doc
                        break
            
            return monobehaviour_data
            
        except Exception as e:
            print(f"Error parsing {file_path}: {e}")
            return None
    
    @staticmethod
    def extract_asset_properties(asset_data):
        """Extract key properties from Unity asset data"""
        if not asset_data:
            return {}
        
        properties = {}
        
        # Standard Unity properties
        properties['name'] = asset_data.get('m_Name', 'Unknown')
        properties['enabled'] = asset_data.get('m_Enabled', 1)
        
        # Extract backing fields (Unity's auto-properties)
        for key, value in asset_data.items():
            if key.startswith('<') and key.endswith('>k__BackingField'):
                # Convert Unity backing field to readable property name
                prop_name = key[1:-17]  # Remove < and >k__BackingField
                properties[prop_name] = value
        
        # Extract other relevant fields
        relevant_fields = [
            '_nameLocKey', 'acceptableLevelRangeForGeneration',
            'onlyIncludedInTheseScenes', 'overrideUnlockCost', 
            'unlockCostOverride'
        ]
        
        for field in relevant_fields:
            if field in asset_data:
                properties[field] = asset_data[field]
        
        return properties
    
    @staticmethod
    def extract_file_references(asset_data):
        """Extract Unity file references (GUIDs)"""
        file_refs = {}
        
        if not asset_data:
            return file_refs
        
        # Look for fileID/guid patterns
        for key, value in asset_data.items():
            if isinstance(value, dict) and 'guid' in value:
                file_refs[key] = value['guid']
            elif isinstance(value, dict) and 'fileID' in value and value['fileID'] != 0:
                file_refs[key] = value
        
        return file_refs
    
    @staticmethod
    def is_null_reference(ref):
        """Check if a Unity reference is null"""
        if isinstance(ref, dict):
            return ref.get('fileID') == 0
        return ref is None
    
    @staticmethod
    def extract_vector2(data):
        """Extract Unity Vector2 data"""
        if isinstance(data, dict) and 'x' in data and 'y' in data:
            return {'x': data['x'], 'y': data['y']}
        return None
    
    @staticmethod
    def get_troop_category_name(category_id):
        """Convert troop category ID to name"""
        categories = {
            0: 'Player',
            1: 'Enemy',
            2: 'Ally', 
            3: 'Structure'
        }
        return categories.get(category_id, f'Unknown_{category_id}')

class UnityAssetScanner:
    """Utility to scan for Unity assets matching patterns"""
    
    @staticmethod
    def find_assets(directory, pattern):
        """Find all assets matching pattern in directory"""
        directory = Path(directory)
        if not directory.exists():
            print(f"Warning: Directory {directory} does not exist")
            return []
        
        return list(directory.glob(pattern))
    
    @staticmethod
    def scan_for_troops(base_directory):
        """Find all Troop asset files"""
        mono_dir = Path(base_directory) / 'MonoBehaviour'
        return UnityAssetScanner.find_assets(mono_dir, 'Troop*.asset')
    
    @staticmethod
    def scan_for_structures(base_directory):
        """Find all Structure asset files"""
        mono_dir = Path(base_directory) / 'MonoBehaviour'
        return UnityAssetScanner.find_assets(mono_dir, '*Structure*.asset')
    
    @staticmethod
    def scan_for_levels(base_directory):
        """Find all Level asset files"""
        mono_dir = Path(base_directory) / 'MonoBehaviour'
        return UnityAssetScanner.find_assets(mono_dir, 'World*Level*.asset')
    
    @staticmethod
    def scan_for_chapters(base_directory):
        """Find all Chapter asset files"""
        mono_dir = Path(base_directory) / 'MonoBehaviour'
        return UnityAssetScanner.find_assets(mono_dir, 'Chapter*.asset')
