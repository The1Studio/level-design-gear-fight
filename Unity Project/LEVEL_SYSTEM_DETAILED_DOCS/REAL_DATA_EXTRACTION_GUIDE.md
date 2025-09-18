# Real Data Extraction Guide - Gear Fight Level System

## Investigation Progress Checkpoint
**Date**: 2025-09-15
**Status**: Data extraction methods identified, sample data analyzed

## 1. Data Storage Overview

### 1.1 Unity Asset Files Location
The actual game data is stored in Unity ScriptableObject assets:
```
Assets/MonoBehaviour/
├── Chapter Assets (World Configuration)
│   ├── Chapter 1 - Tribal Forest.asset
│   ├── Chapter 2 - Dusty Desert.asset
│   ├── Chapter 3 - Snowy Slopes.asset
│   ├── Chapter 4 - Flaming Inferno.asset
│   ├── Chapter 5 - Haunted Hills.asset
│   └── Boss Robot Chapter.asset
│
├── Level Assets (Individual Levels)
│   ├── World 1 - Level 1.asset through World 1 - Level 4.asset
│   ├── World 2 - Level 1.asset through World 2 - Level 4.asset
│   ├── World 3 - Level 1.asset through World 3 - Level 15.asset
│   └── ... (continuing through World 10+)
│
├── Troop Assets (Enemy Data)
│   ├── TroopCaveman.asset
│   ├── TroopSkeleton.asset
│   ├── TroopViking.asset
│   └── ... (50+ troop types)
│
└── Gear Assets (Equipment)
    ├── GearCaveman.asset
    ├── GearViking.asset
    ├── GearGuardian.asset
    └── ... (numerous gear items)
```

### 1.2 Asset File Format
Unity assets are stored in YAML format with the following structure:
- Header: Unity version and tags
- MonoBehaviour section with serialized data
- References to other assets via GUID

## 2. Extracting Chapter Data

### 2.1 Chapter Asset Structure
Example from `Chapter 1 - Tribal Forest.asset`:
```yaml
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_Name: Chapter 1 - Tribal Forest
  ID: 176847c52e7dc45e0ac0e61353d4279e
  DisplayNameLocalizationKey: Forest_new
  ShowWorldUnlock: 0
  EnvironmentTheme: {fileID: 114382395266134545, guid: cc6f368b1033790419f50f4eb5076377}
  MainMusic: {fileID: 8300000, guid: 1777bc2d4c1544f4eabfc57a8efb63f6}
  Levels:
  - {fileID: 11400000, guid: f988456cca450494e9e881a03ba0bbc7}  # World 1 - Level 1
  - {fileID: 11400000, guid: 64f6f4e616da4b44c864df0e79e2d1bc}  # World 1 - Level 2
  - {fileID: 11400000, guid: af83152e53ba23b4888b49d0a36d076c}  # World 1 - Level 3
  - {fileID: 11400000, guid: e9a06bd620f6c434abad69143dd89095}  # World 1 - Level 4
  AllMiniBosses:
  - {fileID: 11400000, guid: 2fb4237ea93407a499a2ca7565fcad24}
  - {fileID: 11400000, guid: d17208b7ed500324cb29343416057e4e}
```

### 2.2 Data Extraction Method
1. Parse YAML file
2. Extract GUID references
3. Map GUIDs to actual asset files via .meta files
4. Recursively load referenced assets

## 3. Extracting Level Data

### 3.1 Level Asset Structure
Example from `World 1 - Level 1.asset`:
```yaml
MonoBehaviour:
  m_Name: World 1 - Level 1
  <DoUseCustomFights>k__BackingField: 1  # Uses predefined fights
  <ID>k__BackingField: 346e207eb93fd9a4d99d87490b837da4
  <StartingCoins>k__BackingField: 15
  <NumberOfSpinners>k__BackingField: 1
  <TutorialSkipString>k__BackingField: FIRSTTUTORIAL

  allFights:
  - <Enemies>k__BackingField:
    - <Character>k__BackingField: {fileID: 11400000, guid: 80924e83f992c1c49a086d34551e1a9b}
      <Level>k__BackingField: 0
      <Delay>k__BackingField: 1
      <IsBeast>k__BackingField: 0
    <ValueOfFight>k__BackingField: 10
    <ForceBasicShop>k__BackingField: 1
```

### 3.2 Fight Data Structure
Each fight contains:
- Enemy list with character GUID, level, and spawn delay
- Structure reference (optional)
- Fight value (difficulty/reward indicator)
- Shop configuration

## 4. GUID Mapping System

### 4.1 Meta Files
Each asset has a corresponding .meta file containing its GUID:
```yaml
# Example: TroopCaveman.asset.meta
fileFormatVersion: 2
guid: 80924e83f992c1c49a086d34551e1a9b
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 0
```

### 4.2 Building GUID Map
```python
# Pseudocode for GUID mapping
guid_map = {}
for meta_file in all_meta_files:
    guid = extract_guid(meta_file)
    asset_name = meta_file.replace('.meta', '')
    guid_map[guid] = asset_name
```

## 5. Data Extraction Tools

### 5.1 Unity Asset Bundle Extractor
- Tool: AssetStudio or UABE (Unity Asset Bundle Extractor)
- Can extract raw asset data from Unity files
- Preserves references and hierarchy

### 5.2 YAML Parser Script
```python
import yaml

def load_unity_asset(file_path):
    with open(file_path, 'r') as f:
        # Skip Unity headers
        content = f.read()
        yaml_start = content.find('MonoBehaviour:')
        yaml_data = content[yaml_start:]

        # Parse YAML
        data = yaml.safe_load(yaml_data)
        return data

def extract_level_data(level_asset_path):
    data = load_unity_asset(level_asset_path)

    level_info = {
        'id': data.get('<ID>k__BackingField'),
        'starting_coins': data.get('<StartingCoins>k__BackingField'),
        'fights': []
    }

    for fight in data.get('allFights', []):
        fight_data = {
            'enemies': [],
            'value': fight.get('<ValueOfFight>k__BackingField')
        }

        for enemy in fight.get('<Enemies>k__BackingField', []):
            enemy_data = {
                'character_guid': extract_guid(enemy.get('<Character>k__BackingField')),
                'level': enemy.get('<Level>k__BackingField'),
                'delay': enemy.get('<Delay>k__BackingField')
            }
            fight_data['enemies'].append(enemy_data)

        level_info['fights'].append(fight_data)

    return level_info
```

## 6. Complete Data Extraction Pipeline

### 6.1 Step-by-Step Process
1. **Extract Meta Files**
   - Parse all .meta files to build GUID → Asset mapping

2. **Load Chapter Data**
   - Start with chapter assets
   - Extract level references

3. **Load Level Data**
   - For each level GUID, load the corresponding asset
   - Extract fight configurations

4. **Load Enemy Data**
   - For each enemy GUID, load troop asset
   - Extract stats and properties

5. **Build Complete Database**
   - Combine all data into structured format
   - Resolve all GUID references

### 6.2 Sample Extraction Script
```bash
# Extract all level data
find MonoBehaviour -name "World*.asset" | while read level; do
    echo "Processing: $level"
    # Extract YAML content
    # Parse fight data
    # Map GUIDs to enemy types
done
```

## 7. Discovered Data Structure

### 7.1 Chapter Progression
```
Chapter 1 - Tribal Forest (4 levels)
├── World 1 - Level 1 (Tutorial, 5 fights)
├── World 1 - Level 2 (4 fights)
├── World 1 - Level 3 (5 fights)
└── World 1 - Level 4 (5 fights + structure)

Chapter 2 - Dusty Desert (4 levels)
├── World 2 - Level 1
├── World 2 - Level 2
├── World 2 - Level 3
└── World 2 - Level 4

... continues through Chapter 10+
```

### 7.2 Enemy Progression
Early levels use:
- TroopCaveman (guid: 80924e83f992c1c49a086d34551e1a9b)
- TroopTribe (guid: 7cdd71bd9cf908041864f52b9522e486)
- TroopShaman (guid: 8fbd3895bf4ab604ea5d09c829160ca2)

Later levels introduce:
- Skeletons, Zombies, Vikings, Robots, etc.

## 8. Save Game Data

### 8.1 PlayerPrefs Location
- **iOS**: ~/Library/Preferences/[bundle.id].plist
- **Android**: /data/data/[package.name]/shared_prefs/
- **Windows**: Registry HKCU\Software\[CompanyName]\[ProductName]

### 8.2 Save Data Keys
Common PlayerPrefs keys found:
- `CurrentLevel`: Absolute level index
- `CurrentChapter`: Chapter index
- `Coins`: Currency amount
- `UnlockedTroops`: JSON array of unlocked troops
- `CompletedLevels`: Bitfield of completed levels

## 9. Current Investigation Status

### 9.1 Completed
✅ Located all chapter asset files (5+ chapters)
✅ Located level asset files (40+ levels across 10 worlds)
✅ Identified YAML structure for assets
✅ Mapped basic enemy GUIDs
✅ Found fight configuration format

### 9.2 In Progress
🔄 Building complete GUID mapping database
🔄 Extracting all enemy statistics
🔄 Parsing gear/item relationships

### 9.3 Next Steps
📋 Create automated extraction script
📋 Build complete level database
📋 Generate difficulty progression charts
📋 Extract and document all enemy types
📋 Map all gear and unlockables

## 10. Quick Reference - Key GUIDs

### Enemy GUIDs
```
80924e83f992c1c49a086d34551e1a9b - TroopCaveman
7cdd71bd9cf908041864f52b9522e486 - TroopTribe
8fbd3895bf4ab604ea5d09c829160ca2 - TroopShaman
d0017b0b667136e47a009d314ec40615 - Unknown (needs mapping)
d215b56b06f67704e965b915f58cac38 - Structure (castle/tower)
```

### Chapter Asset GUIDs
```
176847c52e7dc45e0ac0e61353d4279e - Chapter 1 (Tribal Forest)
[Additional chapters need GUID extraction]
```

## 11. File Index for Continuation

### Documentation Created
1. `01_CHAPTER_SYSTEM.md` - Complete chapter architecture
2. `02_LEVEL_CONFIGURATION.md` - Level structure details
3. `03_FIGHT_GENERATION_SYSTEM.md` - Fight generation mechanics
4. `04_ENEMY_TROOP_SYSTEM.md` - Enemy catalog and systems
5. `REAL_DATA_EXTRACTION_GUIDE.md` - This file (data access methods)

### Pending Documentation
- `05_DIFFICULTY_SCALING.md` - Not yet created
- `06_GRID_PUZZLE_SYSTEM.md` - Not yet created
- `07_PROGRESSION_UNLOCKS.md` - Not yet created
- `08_SPECIAL_FEATURES.md` - Not yet created
- `MASTER_INDEX.md` - Not yet created

### Key Data Files Discovered
- `MonoBehaviour/Chapter*.asset` - All chapter configurations
- `MonoBehaviour/World*Level*.asset` - All level definitions
- `MonoBehaviour/Troop*.asset` - All enemy definitions
- `MonoBehaviour/Gear*.asset` - All equipment items
- `Resources/CombatSimulation*.asset` - Test configurations

## 12. Session Restoration Point

To continue investigation in next session:
1. Resume at GUID mapping completion
2. Continue with automated extraction script
3. Parse remaining World 4-10 level data
4. Complete pending documentation files
5. Generate visual progression charts

### Current Working Directory
`/Users/tuha/Downloads/Gear Fight 5.1.3/ExportedProject/Assets/`

### Active Investigation Paths
- Unity asset extraction via YAML parsing
- GUID to asset mapping via .meta files
- Save data structure analysis
- Resource loading mechanism investigation

---

*Investigation checkpoint saved - Ready for continuation in next session*
*Last updated: 2025-09-15*