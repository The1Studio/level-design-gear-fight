#!/usr/bin/env python3
"""
Game-specific constants for Gear Fight
"""

# Expected enemy types based on documentation and analysis
EXPECTED_ENEMIES = [
    'TroopViking', 'TroopSpartan', 'TroopZombieGrunt', 'TroopRobotMelee', 
    'TroopRobotRange', 'TroopOrc', 'TroopAngel', 'TroopMrD', 'TroopCaveman',
    'TroopTribe', 'TroopTutorialCaveman', 'TroopWolfOne'
]

# Structure environment types
STRUCTURE_ENVIRONMENTS = [
    'Forest', 'City', 'Desert', 'Haunt', 'Jungle', 'Lava', 
    'Mine', 'Nimbus', 'Snow', 'Spore'
]

# Unity asset file patterns
TROOP_PATTERN = 'Troop*.asset'
STRUCTURE_PATTERN = '*Structure*.asset'
LEVEL_PATTERN = 'World*Level*.asset'
CHAPTER_PATTERN = 'Chapter*.asset'

# Unity file paths
UNITY_MONOBEHAVIOUR_PATH = '../UnityProject/MonoBehaviour'
UNITY_GAMEOBJECT_PATH = '../UnityProject/GameObject'
UNITY_RESOURCES_PATH = '../UnityProject/Resources'

# Output file paths
ENEMIES_CATALOG_PATH = '../enemies_catalog.json'
STRUCTURES_CATALOG_PATH = '../structures_catalog.json'
COMPLETE_DATA_PATH = '../complete_game_data.json'
GUID_MAPPINGS_PATH = '../guid_mappings.json'

# Unity YAML constants
UNITY_YAML_HEADER = '%YAML 1.1'
MONOBEHAVIOUR_TAG = '--- !u!114'

# Troop categories (from Unity ScriptableTroop)
TROOP_CATEGORIES = {
    0: 'Player',
    1: 'Enemy', 
    2: 'Ally',
    3: 'Structure'
}

# Level generation constants
MIN_LEVEL_RANGE = 1
MAX_LEVEL_RANGE = 50
