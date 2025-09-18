# Complete Data Conversion Guide - From Unity YAML to JSON

## Overview

This document details the complete process of converting Gear Fight's Unity ScriptableObject assets (YAML format) into structured JSON data, including the progression of our investigation and the final extraction pipeline.

## Investigation Progression Timeline

### Phase 1: Initial Discovery
**Goal**: Understand the codebase structure

1. Started with decompiled C# scripts in `/Scripts/Assembly-CSharp/`
2. Found level-related classes like `ScriptableLevel.cs`, `ScriptableTroop.cs`
3. Discovered the game uses Unity's ScriptableObject system
4. **Problem**: No actual data found in code files

### Phase 2: Finding Real Data
**Goal**: Locate actual game data

1. Discovered `MonoBehaviour/` directory with `.asset` files
2. Found 613 asset files in Unity YAML format
3. Identified naming patterns:
   - `World X - Level Y.asset` (134 files)
   - `Chapter X.asset` (11 files)
   - `Troop*.asset` (50+ enemy types)
4. **Problem**: Assets reference each other using GUIDs

### Phase 3: GUID Mapping Discovery
**Goal**: Resolve asset references

1. Found every `.asset` has a corresponding `.meta` file
2. Meta files contain GUID mappings:
   ```yaml
   fileFormatVersion: 2
   guid: 7cdd71bd9cf908041864f52b9522e486
   ```
3. Built complete GUID → Asset name mapping (613 entries)
4. **Problem**: Unity YAML has special syntax

### Phase 4: YAML Parsing Challenges
**Goal**: Parse Unity's YAML format

**Unity-Specific Syntax Discovered**:
1. **k__BackingField pattern**:
   ```yaml
   <DoUseCustomFights>k__BackingField: 0
   ```
   - Unity's auto-property serialization
   - Need to strip `<>k__BackingField` wrapper

2. **Reference format**:
   ```yaml
   {fileID: 11400000, guid: 2c632fcdc51b25943a943afe8973c24c, type: 2}
   ```
   - fileID: Unity's internal reference
   - guid: Asset identifier
   - type: Asset type indicator

3. **Null references**:
   ```yaml
   {fileID: 0}  # NULL in Unity
   ```

### Phase 5: Building the Extraction Pipeline
**Goal**: Create automated conversion system

## The Final Extraction Pipeline

### Complete Python Script: `extract_all_levels_to_json.py`

```python
class GearFightLevelExtractor:
    def __init__(self, base_path="MonoBehaviour"):
        self.base_path = Path(base_path)
        self.guid_map = {}
        self.levels = {}
        self.chapters = {}
```

### Step 1: Build GUID Map

```python
def build_guid_map(self):
    """Build complete GUID to asset name mapping"""
    for meta_file in self.base_path.glob("*.asset.meta"):
        with open(meta_file, 'r') as f:
            content = f.read()
            guid_match = re.search(r'guid:\s*([a-f0-9]+)', content)
            if guid_match:
                asset_name = meta_file.stem
                self.guid_map[guid_match.group(1)] = asset_name
```

**Process**:
1. Iterate through all `.meta` files
2. Extract GUID using regex
3. Map GUID to asset filename (without extension)
4. Result: 613 GUID mappings

### Step 2: Parse Unity YAML

```python
def parse_unity_yaml(self, filepath):
    """Parse Unity YAML file into Python dict"""
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()

        # Find MonoBehaviour section
        mono_start = content.find('MonoBehaviour:')
        yaml_lines = content[mono_start:].split('\n')

        # Clean Unity-specific syntax
        cleaned_lines = []
        for line in yaml_lines:
            # Remove k__BackingField
            line = re.sub(r'<(.+?)>k__BackingField', r'\1', line)
            cleaned_lines.append(line)

        yaml_content = '\n'.join(cleaned_lines)
        data = yaml.safe_load(yaml_content)
```

**Transformations**:
1. Extract MonoBehaviour section
2. Remove `<>k__BackingField` wrappers
3. Parse with PyYAML library
4. Return clean Python dictionary

### Step 3: Extract and Resolve References

```python
def extract_guid(self, ref):
    """Extract GUID from Unity reference"""
    if isinstance(ref, dict):
        # Handle {fileID: ..., guid: ..., type: ...} format
        return ref.get('guid')

    # Handle string format
    match = re.search(r'guid:\s*([a-f0-9]+)', str(ref))
    return match.group(1) if match else None

def resolve_guid(self, guid):
    """Resolve GUID to asset name"""
    if not guid:
        return None
    return self.guid_map.get(guid, f"Unknown_{guid[:8]}")
```

**Resolution Process**:
1. Extract GUID from reference
2. Look up in GUID map
3. Return asset name or "Unknown_" prefix if not found

### Step 4: Convert Level Data

```python
def extract_level_data(self, filepath):
    """Extract complete level data"""
    data = self.parse_unity_yaml(filepath)

    # Extract fights (with enemy references)
    fights = []
    for fight in data.get('allFights', []):
        enemies = []
        for enemy in fight.get('Enemies', []):
            character_guid = self.extract_guid(enemy.get('Character'))
            enemies.append({
                'character': self.resolve_guid(character_guid),
                'character_guid': character_guid,
                'level': enemy.get('Level', 0),
                'delay': enemy.get('Delay', 0),
                'is_beast': enemy.get('IsBeast', False)
            })

        structure_guid = self.extract_guid(fight.get('Structure'))
        fights.append({
            'enemies': enemies,
            'structure': self.resolve_guid(structure_guid),
            'structure_guid': structure_guid,
            'value_of_fight': fight.get('ValueOfFight', 0)
        })

    # Extract other properties
    return {
        'name': data.get('m_Name'),
        'id': data.get('ID'),
        'use_custom_fights': data.get('DoUseCustomFights', False),
        'starting_coins': data.get('StartingCoins', 0),
        'num_levels': data.get('numLevels', 0),
        'fights': fights,
        # ... more fields
    }
```

### Step 5: Generate Complete JSON

```python
def generate_complete_json(self):
    """Generate complete JSON output with all data"""

    # Sort levels by world and level number
    sorted_levels = sorted(
        self.levels.values(),
        key=lambda x: x.get('sort_key', 999999)
    )

    # Calculate statistics
    stats = {
        'total_levels': len(self.levels),
        'custom_fight_levels': sum(1 for l in sorted_levels
                                  if l.get('use_custom_fights')),
        'procedural_levels': sum(1 for l in sorted_levels
                                if not l.get('use_custom_fights')),
        'total_fights': sum(l.get('fight_count', 0) for l in sorted_levels),
        'unique_enemies': len(set(...)),
        'unique_structures': len(set(...))
    }

    return {
        'game': 'Gear Fight 5.1.3',
        'extraction_date': '2025-09-15',
        'statistics': stats,
        'guid_mappings': self.guid_map,
        'chapters': self.chapters,
        'worlds': dict(worlds),
        'all_levels': sorted_levels
    }
```

## Data Transformation Examples

### Example 1: Level File Transformation

**Input (Unity YAML)**:
```yaml
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_Name: World 1 - Level 1
  <DoUseCustomFights>k__BackingField: 1
  <StartingCoins>k__BackingField: 15
  allFights:
  - <Enemies>k__BackingField:
    - <Character>k__BackingField: {fileID: 11400000, guid: 7cdd71bd9cf908041864f52b9522e486, type: 2}
      <Level>k__BackingField: 0
      <Delay>k__BackingField: 1
```

**Output (JSON)**:
```json
{
  "name": "World 1 - Level 1",
  "use_custom_fights": true,
  "starting_coins": 15,
  "fights": [
    {
      "enemies": [
        {
          "character": "TroopCaveman.asset",
          "character_guid": "7cdd71bd9cf908041864f52b9522e486",
          "level": 0,
          "delay": 1
        }
      ]
    }
  ]
}
```

### Example 2: GUID Resolution

**Input References**:
```yaml
difficultyProfile: {fileID: 11400000, guid: 2c632fcdc51b25943a943afe8973c24c, type: 2}
allStructures:
  - {fileID: 11400000, guid: 2edfea5bfdbf0bd46b051063a10ece31, type: 2}
```

**After GUID Resolution**:
```json
{
  "difficulty_profile": {
    "name": "Linear 50%.asset",
    "guid": "2c632fcdc51b25943a943afe8973c24c"
  },
  "structures": [
    {
      "name": "Desert_Structure_1.asset",
      "guid": "2edfea5bfdbf0bd46b051063a10ece31"
    }
  ]
}
```

### Example 3: Handling NULL References

**Input (Procedural Level)**:
```yaml
allFights:
  - <Enemies>k__BackingField:
    - <Character>k__BackingField: {fileID: 0}
      <Level>k__BackingField: 0
```

**Output**:
```json
{
  "fights": [
    {
      "enemies": [
        {
          "character": null,
          "character_guid": null,
          "level": 0
        }
      ]
    }
  ]
}
```

## Execution and Results

### Running the Extraction

```bash
cd /Users/tuha/Downloads/Gear Fight 5.1.3/ExportedProject/Assets
python3 extract_all_levels_to_json.py
```

### Output Files Generated

1. **gear_fight_complete_levels.json** (647KB)
   - Formatted with 2-space indentation
   - Human-readable
   - Includes all metadata

2. **gear_fight_complete_levels_compact.json** (381KB)
   - Minified format
   - No whitespace
   - Optimized for storage/transmission

### Extraction Statistics

```
Building GUID map...
Mapped 613 GUIDs

Extracting chapter data...
Found 11 chapter files
Extracted 11 chapters

Extracting level data...
Found 134 level files
Extracted 134 levels

Statistics:
- Total levels: 134
- Custom fight levels: 1 (World 1-1 only)
- Procedural levels: 133
- Total fights: 138 (from custom level)
- Total enemies: 407 (from custom level)
- Unique enemies: 4 (in custom level)
- Unique structures: 30
```

## Key Discoveries During Conversion

### 1. Empty Data Pattern
- 133/134 levels have `{fileID: 0}` for enemies
- This is intentional - they use procedural generation
- Only tutorial (World 1-1) has actual enemy data

### 2. Binary Serialized Data
- Grid layouts use `SerializedBytes` (binary format)
- Cannot be directly converted to JSON
- Referenced Unity objects listed separately

### 3. Property Naming Conventions
- Unity uses PascalCase: `DoUseCustomFights`
- Converted to snake_case: `use_custom_fights`
- Maintains consistency with JSON standards

### 4. Nested References
- Assets reference other assets via GUID
- Created two-level resolution:
  - First pass: Build GUID map
  - Second pass: Resolve all references

## Validation Methods

### 1. Check Extraction Completeness
```python
# Verify all levels extracted
assert len(data['all_levels']) == 134
assert len(data['chapters']) == 11
assert len(data['guid_mappings']) == 613
```

### 2. Verify Data Integrity
```python
# Check custom vs procedural split
custom = [l for l in data['all_levels'] if l['use_custom_fights']]
procedural = [l for l in data['all_levels'] if not l['use_custom_fights']]
assert len(custom) == 1
assert len(procedural) == 133
```

### 3. Validate GUID Resolution
```python
# Ensure no unresolved GUIDs in critical fields
for level in data['all_levels']:
    if level.get('difficulty_profile'):
        assert not level['difficulty_profile']['name'].startswith('Unknown_')
```

## Future Improvements

### Potential Enhancements

1. **Binary Data Decoding**:
   - Decode `SerializedBytes` for grid layouts
   - Extract peg positions and configurations

2. **Cross-Reference Validation**:
   - Verify all GUID references are valid
   - Check for orphaned assets

3. **Incremental Updates**:
   - Track changed files
   - Update only modified assets

4. **Schema Validation**:
   - Create JSON schema for output
   - Validate against expected structure

5. **Performance Optimization**:
   - Parallel processing for large datasets
   - Caching for repeated GUID lookups

## Conclusion

The data conversion pipeline successfully transforms Unity's complex YAML format into clean, analyzable JSON. The process handles Unity-specific syntax, resolves cross-references, and preserves all game data relationships. The discovery that 99% of levels use procedural generation was only possible through this systematic extraction and analysis.

This pipeline can be adapted for other Unity projects using ScriptableObjects, providing a reusable solution for game data analysis.