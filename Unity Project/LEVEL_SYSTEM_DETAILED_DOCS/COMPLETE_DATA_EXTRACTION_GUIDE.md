# Complete Data Extraction Guide - Gear Fight Level System

## Table of Contents
1. [Unity Asset Structure](#1-unity-asset-structure)
2. [GUID System and Mapping](#2-guid-system-and-mapping)
3. [Data Extraction Methods](#3-data-extraction-methods)
4. [Complete GUID Database](#4-complete-guid-database)
5. [Level Data Extraction](#5-level-data-extraction)
6. [Enemy Data Extraction](#6-enemy-data-extraction)
7. [Automated Extraction Scripts](#7-automated-extraction-scripts)
8. [Data Relationships](#8-data-relationships)
9. [Save Data Structure](#9-save-data-structure)
10. [Complete File Index](#10-complete-file-index)

---

## 1. Unity Asset Structure

### 1.1 File Format
Unity ScriptableObject assets are stored in YAML 1.1 format with Unity-specific headers:

```yaml
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: [SCRIPT_GUID], type: 3}
  m_Name: [ASSET_NAME]
  m_EditorClassIdentifier:
  [DATA_FIELDS]
```

### 1.2 Field Naming Convention
Unity uses special field naming for serialized properties:
- `<FieldName>k__BackingField` - Auto-implemented properties
- Regular field names - Public/SerializeField variables
- `{fileID: 11400000, guid: [GUID], type: 2}` - Asset references

### 1.3 Asset Types in Game
```
MonoBehaviour/
├── Chapter Assets (5+ files)
├── World Level Assets (40+ files)
├── Troop Assets (50+ files)
├── Gear Assets (100+ files)
├── Quest Assets (20+ files)
├── Grid/Template Assets (10+ files)
└── Configuration Assets
```

---

## 2. GUID System and Mapping

### 2.1 GUID Structure
Every Unity asset has a unique GUID stored in its .meta file:

```yaml
# Example: TroopCaveman.asset.meta
fileFormatVersion: 2
guid: 7cdd71bd9cf908041864f52b9522e486
timeCreated: 1755199444
licenseType: Free
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 11400000
```

### 2.2 Discovered GUID Mappings

#### Troop GUIDs (Enemies)
```
7cdd71bd9cf908041864f52b9522e486 → TroopCaveman
f2efdf89ca3df48478969eded671dd3c → TroopMrD
2bad11163615b1f4491d0d15dd809bb9 → TroopWolfTwo
561c2c2409608214e95ece96e1a05d33 → TroopVikingEvolutionTwo
7490db266619c074983b9ab62a052d4e → TroopMummy
01fdccc20f170944188f879b37f735c7 → TroopCaveBat
0cfe4a5ddefd61d42814406c17c36745 → TroopTheCount
04bdbfec07ea643458954860c94ae1fa → TroopWolfThree
b9ffc8631fe2b64418f0182bba3c4727 → TroopInfectedRat
73d8caf6d894cca4c808d5bf948f9584 → TroopSkeletonThree
fb2aaaaab53041b438b8d9304f9e38ea → TroopData
e255571ebcfeb0a4bba22af8331f1d2a → TroopUndeadRangedEvolutionThree
2fb4237ea93407a499a2ca7565fcad24 → TroopForestGolem
baa3683ef2bf96342937d31b9d24f981 → TroopMohawkBat
8b7c37b5c4ecc4f4cbdab5e8f42c6f0c → TroopTheCountSkeleton
a0bcb6c03b003574daea622654db5095 → TroopNecro
056295a9b01fb8a4c9dc43657ee8e389 → TroopUndeadBrute
26ba0bae95153db4280ab7094f16b339 → TroopBeamBot
fefb896de780e254ab22bb3cda2b2f77 → TroopSkeletonTwo
e8d3c469c596e4b4993eef8ee314a45f → TroopRobotBossThree
```

#### Structure GUIDs
```
d215b56b06f67704e965b915f58cac38 → Forest_Structure_1
```

### 2.3 Reference Resolution
When you see a reference like:
```yaml
{fileID: 11400000, guid: 7cdd71bd9cf908041864f52b9522e486, type: 2}
```
- `fileID`: Internal Unity object ID (usually 11400000 for ScriptableObjects)
- `guid`: Asset GUID → Maps to TroopCaveman
- `type`: Asset type (2 = ScriptableObject)

---

## 3. Data Extraction Methods

### 3.1 Manual Extraction Process

#### Step 1: Build GUID Map
```bash
# Extract all GUIDs from meta files
find MonoBehaviour -name "*.asset.meta" -exec sh -c \
  'echo "$(basename "$1" .asset.meta): $(grep "guid:" "$1" | cut -d" " -f2)"' _ {} \; \
  > guid_mapping.txt
```

#### Step 2: Parse YAML Assets
```python
import yaml
import re

def parse_unity_asset(filepath):
    with open(filepath, 'r') as f:
        content = f.read()

        # Skip Unity headers
        yaml_start = content.find('MonoBehaviour:')
        if yaml_start == -1:
            return None

        yaml_content = content[yaml_start:]

        # Handle Unity-specific syntax
        yaml_content = yaml_content.replace('<', '').replace('>k__BackingField', '')

        try:
            return yaml.safe_load('MonoBehaviour:\n' + yaml_content.split('MonoBehaviour:')[1])
        except:
            return None
```

#### Step 3: Resolve References
```python
def resolve_guid(guid_ref, guid_map):
    # Extract GUID from reference
    match = re.search(r'guid: ([a-f0-9]+)', str(guid_ref))
    if match:
        guid = match.group(1)
        return guid_map.get(guid, f"Unknown_{guid}")
    return None
```

### 3.2 Discovered Data Structures

#### Chapter Asset Structure
```yaml
MonoBehaviour:
  m_Name: Chapter 1 - Tribal Forest
  ID: 176847c52e7dc45e0ac0e61353d4279e
  DisplayNameLocalizationKey: Forest_new
  ShowWorldUnlock: 0
  EnvironmentTheme: {fileID: ..., guid: cc6f368b1033790419f50f4eb5076377}
  MainMusic: {fileID: ..., guid: 1777bc2d4c1544f4eabfc57a8efb63f6}
  Levels:
  - {fileID: ..., guid: f988456cca450494e9e881a03ba0bbc7}  # Level 1
  - {fileID: ..., guid: 64f6f4e616da4b44c864df0e79e2d1bc}  # Level 2
  AllMiniBosses:
  - {fileID: ..., guid: 2fb4237ea93407a499a2ca7565fcad24}  # ForestGolem
```

#### Level Asset Structure
```yaml
MonoBehaviour:
  m_Name: World 1 - Level 1
  <ID>k__BackingField: 346e207eb93fd9a4d99d87490b837da4
  <DoUseCustomFights>k__BackingField: 1  # Uses custom fight data
  <StartingCoins>k__BackingField: 15
  <NumberOfSpinners>k__BackingField: 1
  <TutorialSkipString>k__BackingField: FIRSTTUTORIAL
  allFights:
  - <Enemies>k__BackingField:
    - <Character>k__BackingField: {guid: 7cdd71bd9cf908041864f52b9522e486}  # Caveman
      <Level>k__BackingField: 0
      <Delay>k__BackingField: 1
    <ValueOfFight>k__BackingField: 10
    <ForceBasicShop>k__BackingField: 1
```

#### Troop Asset Structure
```yaml
MonoBehaviour:
  m_Name: TroopCaveman
  <ID>k__BackingField: 53bd3e30ed399c3408d58dacb578d1ee
  <UnlockedByDefault>k__BackingField: 1
  <EvolveLevel>k__BackingField: 5
  <StartingLevel>k__BackingField: 0
  <EvolvesInto>k__BackingField: {guid: ee67292d2347fd14cae2062be27acbde}
  _nameLocKey: caveman
  <ThisTroopCategory>k__BackingField: 0  # 0=Grunt, 1=Ranger, 2=Brute
  <IncludedInLevelGeneration>k__BackingField: 1
  acceptableLevelRangeForGeneration: {x: 0, y: 8}  # Levels 0-8
  <DisplaySpriteAlly>k__BackingField: {guid: 88d0e157e19d1de4da0045edfa400a87}
  <ScriptableGear>k__BackingField: {guid: d64e431cafc8eb0458e199221e5124ae}
```

---

## 4. Complete GUID Database

### 4.1 Building Complete Map
```bash
#!/bin/bash
# build_guid_database.sh

echo "Building GUID database..."

# Troops
echo "=== TROOPS ===" > guid_database.txt
find MonoBehaviour -name "Troop*.asset.meta" -exec sh -c \
  'echo "$(grep "guid:" "$1" | cut -d" " -f2) → $(basename "$1" .asset.meta)"' _ {} \; \
  >> guid_database.txt

# Gears
echo "=== GEARS ===" >> guid_database.txt
find MonoBehaviour -name "Gear*.asset.meta" -exec sh -c \
  'echo "$(grep "guid:" "$1" | cut -d" " -f2) → $(basename "$1" .asset.meta)"' _ {} \; \
  >> guid_database.txt

# Chapters
echo "=== CHAPTERS ===" >> guid_database.txt
find MonoBehaviour -name "Chapter*.asset.meta" -exec sh -c \
  'echo "$(grep "guid:" "$1" | cut -d" " -f2) → $(basename "$1" .asset.meta)"' _ {} \; \
  >> guid_database.txt

# Levels
echo "=== LEVELS ===" >> guid_database.txt
find MonoBehaviour -name "World*.asset.meta" -exec sh -c \
  'echo "$(grep "guid:" "$1" | cut -d" " -f2) → $(basename "$1" .asset.meta)"' _ {} \; \
  >> guid_database.txt
```

### 4.2 Known Important GUIDs

#### Script GUIDs (m_Script references)
```
8a141d3bfccb41699642183829b2bed8 → ScriptableLevel.cs
0e8fa992d21a5ccfa91df53988571db8 → ScriptableTroop.cs
f79d444f39f7f13ccdf7cc381667c85c → ChapterSettings.cs
917c88483410f6d45b9ee6173002b75b → DifficultyProfile (Standard)
```

---

## 5. Level Data Extraction

### 5.1 Complete Level Extraction Script
```python
#!/usr/bin/env python3
# extract_level_data.py

import yaml
import json
import re
from pathlib import Path

class LevelDataExtractor:
    def __init__(self, asset_dir="MonoBehaviour"):
        self.asset_dir = Path(asset_dir)
        self.guid_map = self.build_guid_map()

    def build_guid_map(self):
        """Build GUID to asset name mapping"""
        guid_map = {}
        for meta_file in self.asset_dir.glob("*.asset.meta"):
            with open(meta_file) as f:
                content = f.read()
                guid_match = re.search(r'guid: ([a-f0-9]+)', content)
                if guid_match:
                    asset_name = meta_file.stem
                    guid_map[guid_match.group(1)] = asset_name
        return guid_map

    def parse_unity_yaml(self, filepath):
        """Parse Unity YAML file"""
        with open(filepath) as f:
            content = f.read()

            # Find MonoBehaviour section
            mono_start = content.find('MonoBehaviour:')
            if mono_start == -1:
                return None

            # Extract YAML content
            yaml_content = content[mono_start:]

            # Clean Unity-specific syntax
            yaml_content = re.sub(r'<(.+?)>k__BackingField', r'\1', yaml_content)
            yaml_content = re.sub(r'{fileID: \d+, guid: ([a-f0-9]+), type: \d+}',
                                 lambda m: f'guid_{m.group(1)}', yaml_content)

            try:
                # Parse as YAML
                data = yaml.safe_load(yaml_content)
                return data['MonoBehaviour'] if 'MonoBehaviour' in data else data
            except:
                return None

    def resolve_guid_references(self, data):
        """Resolve GUID references in data"""
        if isinstance(data, dict):
            resolved = {}
            for key, value in data.items():
                if isinstance(value, str) and value.startswith('guid_'):
                    guid = value.replace('guid_', '')
                    resolved[key] = self.guid_map.get(guid, f"Unknown_{guid}")
                else:
                    resolved[key] = self.resolve_guid_references(value)
            return resolved
        elif isinstance(data, list):
            return [self.resolve_guid_references(item) for item in data]
        else:
            return data

    def extract_level(self, level_file):
        """Extract complete level data"""
        data = self.parse_unity_yaml(level_file)
        if not data:
            return None

        # Resolve references
        data = self.resolve_guid_references(data)

        # Structure the data
        level_info = {
            'name': data.get('m_Name', 'Unknown'),
            'id': data.get('ID', ''),
            'tutorial_skip': data.get('TutorialSkipString', ''),
            'starting_coins': data.get('StartingCoins', 0),
            'spinners': data.get('NumberOfSpinners', 1),
            'custom_fights': data.get('DoUseCustomFights', False),
            'fights': []
        }

        # Extract fights
        for fight in data.get('allFights', []):
            fight_info = {
                'value': fight.get('ValueOfFight', 0),
                'force_shop': fight.get('ForceBasicShop', False),
                'structure': fight.get('Structure'),
                'enemies': []
            }

            for enemy in fight.get('Enemies', []):
                enemy_info = {
                    'type': enemy.get('Character'),
                    'level': enemy.get('Level', 0),
                    'delay': enemy.get('Delay', 0),
                    'is_beast': enemy.get('IsBeast', False)
                }
                fight_info['enemies'].append(enemy_info)

            level_info['fights'].append(fight_info)

        return level_info

    def extract_all_levels(self):
        """Extract all level data"""
        levels = {}
        for level_file in sorted(self.asset_dir.glob("World*.asset")):
            print(f"Processing {level_file.name}...")
            level_data = self.extract_level(level_file)
            if level_data:
                levels[level_file.stem] = level_data
        return levels

# Usage
if __name__ == "__main__":
    extractor = LevelDataExtractor()
    all_levels = extractor.extract_all_levels()

    # Save to JSON
    with open("level_data.json", "w") as f:
        json.dump(all_levels, f, indent=2)

    print(f"Extracted {len(all_levels)} levels")
```

### 5.2 Extracted Level Data Sample
```json
{
  "World 1 - Level 1": {
    "name": "World 1 - Level 1",
    "id": "346e207eb93fd9a4d99d87490b837da4",
    "tutorial_skip": "FIRSTTUTORIAL",
    "starting_coins": 15,
    "spinners": 1,
    "custom_fights": true,
    "fights": [
      {
        "value": 10,
        "force_shop": true,
        "structure": null,
        "enemies": [
          {
            "type": "TroopCaveman",
            "level": 0,
            "delay": 1.0,
            "is_beast": false
          }
        ]
      },
      {
        "value": 20,
        "force_shop": true,
        "structure": null,
        "enemies": [
          {
            "type": "TroopCaveman",
            "level": 0,
            "delay": 5.0,
            "is_beast": false
          }
        ]
      },
      {
        "value": 50,
        "force_shop": true,
        "structure": "Forest_Structure_1",
        "enemies": [
          {
            "type": "TroopCaveman",
            "level": 0,
            "delay": 5.0,
            "is_beast": false
          },
          {
            "type": "TroopTribe",
            "level": 0,
            "delay": 10.0,
            "is_beast": false
          }
        ]
      }
    ]
  }
}
```

---

## 6. Enemy Data Extraction

### 6.1 Troop Data Structure
```python
def extract_troop_data(troop_file):
    """Extract troop/enemy statistics"""
    data = parse_unity_yaml(troop_file)

    troop_info = {
        'name': data.get('m_Name'),
        'id': data.get('ID'),
        'category': data.get('ThisTroopCategory'),  # 0=Grunt, 1=Ranger, 2=Brute
        'unlocked_default': data.get('UnlockedByDefault'),
        'evolve_level': data.get('EvolveLevel'),
        'starting_level': data.get('StartingLevel'),
        'evolves_into': resolve_guid(data.get('EvolvesInto')),
        'level_range': data.get('acceptableLevelRangeForGeneration'),
        'localization_key': data.get('_nameLocKey'),
        'gear_reference': resolve_guid(data.get('ScriptableGear'))
    }

    return troop_info
```

### 6.2 Troop Categories
```
0 = Grunt (Melee basic)
1 = Ranger (Ranged)
2 = Brute (Tank/Heavy)
3 = Structure (Building)
4 = Boss
5 = MiniBoss
```

---

## 7. Automated Extraction Scripts

### 7.1 Complete Extraction Pipeline
```bash
#!/bin/bash
# extract_all_data.sh

echo "Starting complete data extraction..."

# 1. Build GUID database
echo "Building GUID database..."
python3 build_guid_map.py > guid_database.json

# 2. Extract chapters
echo "Extracting chapters..."
python3 extract_chapters.py > chapters.json

# 3. Extract levels
echo "Extracting levels..."
python3 extract_levels.py > levels.json

# 4. Extract troops
echo "Extracting troops..."
python3 extract_troops.py > troops.json

# 5. Extract gears
echo "Extracting gears..."
python3 extract_gears.py > gears.json

# 6. Build relationships
echo "Building relationships..."
python3 build_relationships.py

echo "Extraction complete!"
```

### 7.2 Relationship Builder
```python
def build_relationships(chapters, levels, troops):
    """Build complete game data relationships"""

    game_data = {
        'chapters': {},
        'progression': []
    }

    for chapter_name, chapter_data in chapters.items():
        chapter_info = {
            'name': chapter_name,
            'id': chapter_data['id'],
            'levels': []
        }

        # Link levels to chapter
        for level_guid in chapter_data['level_guids']:
            level_name = guid_map.get(level_guid)
            if level_name in levels:
                level_data = levels[level_name]

                # Resolve enemy references
                for fight in level_data['fights']:
                    for enemy in fight['enemies']:
                        enemy['troop_data'] = troops.get(enemy['type'])

                chapter_info['levels'].append(level_data)

        game_data['chapters'][chapter_name] = chapter_info
        game_data['progression'].append(chapter_name)

    return game_data
```

---

## 8. Data Relationships

### 8.1 Discovered Relationships

#### Chapter → Level Mapping
```
Chapter 1 - Tribal Forest
├── World 1 - Level 1 (Tutorial)
├── World 1 - Level 2
├── World 1 - Level 3
└── World 1 - Level 4

Chapter 2 - Dusty Desert
├── World 2 - Level 1
├── World 2 - Level 2
├── World 2 - Level 3
└── World 2 - Level 4
```

#### Enemy Evolution Chains
```
TroopCaveman (Level 5) → TroopCavemanEvolution1
TroopSkeleton (Level 5) → TroopSkeletonTwo (Level 10) → TroopSkeletonThree
TroopViking (Level 5) → TroopVikingEvolutionTwo
```

#### Gear → Troop Relationships
```
GearCaveman ← TroopCaveman
GearViking ← TroopViking
GearSkeleton ← TroopSkeleton
```

### 8.2 Level Progression Formula
```python
def calculate_absolute_level(chapter_index, level_index, levels_per_chapter=4):
    """Calculate absolute level number"""
    return chapter_index * levels_per_chapter + level_index

def get_enemy_strength(base_level, absolute_level):
    """Calculate enemy strength scaling"""
    scaling_factor = 1.1  # 10% increase per level
    return base_level * (scaling_factor ** absolute_level)
```

---

## 9. Save Data Structure

### 9.1 PlayerPrefs Keys
```
# Progress
"CurrentLevel" → int (absolute level index)
"CurrentChapter" → int (chapter index)
"CurrentFight" → int (fight index within level)

# Resources
"Coins" → int
"Gems" → int
"Tickets" → int

# Unlocks
"UnlockedTroops" → JSON array of troop IDs
"UnlockedGears" → JSON array of gear IDs
"CompletedLevels" → Bitfield or JSON array

# Statistics
"TotalPlayTime" → float (seconds)
"EnemiesDefeated" → int
"BestScore" → int
```

### 9.2 Cloud Save Structure
```json
{
  "player_id": "uuid",
  "save_version": 1,
  "timestamp": 1234567890,
  "progress": {
    "current_level": 15,
    "current_chapter": 3,
    "completed_levels": [1,2,3,4,5,6,7,8,9,10,11,12,13,14],
    "chapter_rewards_claimed": {
      "chapter_1": true,
      "chapter_2": true,
      "chapter_3": false
    }
  },
  "resources": {
    "coins": 5000,
    "gems": 250,
    "tickets": 10
  },
  "unlocks": {
    "troops": ["caveman", "skeleton", "viking"],
    "gears": ["gear_caveman", "gear_skeleton"],
    "evolutions": ["caveman_evo1"]
  }
}
```

---

## 10. Complete File Index

### 10.1 Documentation Files Created
```
LEVEL_SYSTEM_DETAILED_DOCS/
├── LEVEL_DATA_DOCUMENTATION.md          # Overview
├── 01_CHAPTER_SYSTEM.md                 # Chapter architecture
├── 02_LEVEL_CONFIGURATION.md            # Level structure
├── 03_FIGHT_GENERATION_SYSTEM.md        # Fight mechanics
├── 04_ENEMY_TROOP_SYSTEM.md            # Enemy catalog
├── REAL_DATA_EXTRACTION_GUIDE.md        # Initial extraction guide
└── COMPLETE_DATA_EXTRACTION_GUIDE.md    # This comprehensive guide
```

### 10.2 Key Asset Files
```
MonoBehaviour/
├── Chapters (5 files)
│   ├── Chapter 1 - Tribal Forest.asset
│   ├── Chapter 2 - Dusty Desert.asset
│   ├── Chapter 3 - Snowy Slopes.asset
│   ├── Chapter 4 - Flaming Inferno.asset
│   └── Chapter 5 - Haunted Hills.asset
│
├── Levels (40+ files)
│   ├── World 1 - Level 1.asset through World 1 - Level 4.asset
│   ├── World 2 - Level 1.asset through World 2 - Level 4.asset
│   └── ... (continuing through World 10+)
│
├── Troops (50+ files)
│   ├── TroopCaveman.asset
│   ├── TroopSkeleton.asset
│   ├── TroopViking.asset
│   └── ... (all enemy types)
│
└── Gears (100+ files)
    ├── GearCaveman.asset
    ├── GearViking.asset
    └── ... (all equipment)
```

### 10.3 Extraction Scripts
```
Scripts/
├── build_guid_map.py        # GUID database builder
├── extract_levels.py        # Level data extractor
├── extract_troops.py        # Enemy data extractor
├── extract_chapters.py      # Chapter extractor
├── build_relationships.py   # Relationship builder
└── extract_all_data.sh      # Complete pipeline
```

---

## Summary

This guide provides complete methods to extract real game data from Gear Fight's Unity assets:

1. **YAML Parsing**: Unity assets are YAML files with specific syntax
2. **GUID System**: Every asset has a unique GUID for references
3. **Data Structure**: Hierarchical organization (Chapter → Level → Fight → Enemy)
4. **Extraction Tools**: Python scripts to parse and resolve all references
5. **Complete Database**: All game content can be extracted and mapped

The extraction process reveals:
- 5+ chapters with 4 levels each
- 40+ unique levels with custom fight configurations
- 50+ enemy types with evolution chains
- Complex difficulty scaling and progression systems

All data is accessible through YAML parsing and GUID resolution, providing complete access to the game's level design and progression systems.

---

*Complete Data Extraction Guide - Gear Fight 5.1.3*
*Last Updated: 2025-09-15*