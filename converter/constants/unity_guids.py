#!/usr/bin/env python3
"""
Unity GUID mappings and asset reference handling
"""

import json
from pathlib import Path

class UnityGUIDManager:
    """Manages Unity GUID to asset name mappings"""
    
    def __init__(self, guid_mappings_path=None):
        self.guid_mappings = {}
        self.reverse_mappings = {}
        
        if guid_mappings_path:
            self.load_mappings(guid_mappings_path)
    
    def load_mappings(self, path):
        """Load GUID mappings from JSON file"""
        try:
            with open(path, 'r') as f:
                data = json.load(f)
                self.guid_mappings = data.get('sample', {})
                
                # Create reverse mapping (name -> guid)
                self.reverse_mappings = {
                    v.replace('.asset', ''): k 
                    for k, v in self.guid_mappings.items()
                }
                
                print(f"Loaded {len(self.guid_mappings)} GUID mappings")
        except Exception as e:
            print(f"Warning: Could not load GUID mappings: {e}")
    
    def get_asset_name(self, guid):
        """Get asset name from GUID"""
        asset_name = self.guid_mappings.get(guid, f"Unknown_{guid}")
        return asset_name.replace('.asset', '')
    
    def get_guid(self, asset_name):
        """Get GUID from asset name"""
        clean_name = asset_name.replace('.asset', '')
        return self.reverse_mappings.get(clean_name)
    
    def is_troop_asset(self, asset_name):
        """Check if asset is a troop/enemy"""
        clean_name = asset_name.replace('.asset', '')
        return clean_name.startswith('Troop')
    
    def is_structure_asset(self, asset_name):
        """Check if asset is a structure"""
        clean_name = asset_name.replace('.asset', '')
        return 'Structure' in clean_name
    
    def extract_guid_from_fileref(self, file_ref):
        """Extract GUID from Unity file reference"""
        if isinstance(file_ref, dict) and 'guid' in file_ref:
            return file_ref['guid']
        return None

# Known Unity script GUIDs for different asset types
UNITY_SCRIPT_GUIDS = {
    'ScriptableTroop': '0e8fa992d21a5ccfa91df53988571db8',
    'ScriptableLevel': 'other_guid_here',  # To be identified
    'ChapterSettings': 'another_guid_here'  # To be identified
}

# Common Unity null reference
NULL_FILE_REF = {'fileID': 0}
