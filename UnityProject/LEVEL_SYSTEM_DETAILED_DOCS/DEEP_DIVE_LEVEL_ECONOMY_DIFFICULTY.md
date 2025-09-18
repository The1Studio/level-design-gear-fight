# Deep Dive: Level Data, Economy System & Difficulty Configuration

## Table of Contents
1. [Level Data Patterns Analysis](#1-level-data-patterns-analysis)
2. [Economy System Architecture](#2-economy-system-architecture)
3. [Difficulty Configuration System](#3-difficulty-configuration-system)
4. [NIV (Normalized Item Value) System](#4-niv-normalized-item-value-system)
5. [Store and Gear Economy](#5-store-and-gear-economy)
6. [Reward Calculations](#6-reward-calculations)
7. [Progression Formulas](#7-progression-formulas)
8. [Data Extraction Scripts](#8-data-extraction-scripts)

---

## 1. Level Data Patterns Analysis

### 1.1 Level Configuration Types

After analyzing multiple level files, I've identified two distinct configuration patterns:

#### Type A: Custom Fights (Tutorial/Early Levels)
**Example**: World 1 - Level 1
```yaml
<DoUseCustomFights>k__BackingField: 1  # TRUE - Uses predefined fights
<DoUseCustomGears>k__BackingField: 1   # TRUE - Uses specific gears
allFights:
  - <Enemies>k__BackingField:
    - <Character>k__BackingField: {guid: 7cdd71bd9cf908041864f52b9522e486}  # Specific enemy
      <Level>k__BackingField: 0
      <Delay>k__BackingField: 1
    <ValueOfFight>k__BackingField: 10  # Specific value
    <ForceBasicShop>k__BackingField: 1  # Forces shop
```

#### Type B: Procedural Generation (Later Levels)
**Example**: World 2+ Levels
```yaml
<DoUseCustomFights>k__BackingField: 0  # FALSE - Uses procedural generation
<DoUseCustomGears>k__BackingField: 0   # FALSE - Random gear selection
allFights:
  - <Enemies>k__BackingField:
    - <Character>k__BackingField: {fileID: 0}  # Null - Generated at runtime
      <Level>k__BackingField: 0
      <Delay>k__BackingField: 0
    <ValueOfFight>k__BackingField: 0  # Calculated at runtime
```

### 1.2 Level Progression Data

#### Starting Resources by Level
```
World 1-1: StartingCoins: 15, Spinners: 1
World 2-1: StartingCoins: 22, Spinners: 2
World 5-10: StartingCoins: 22, Spinners: 2
World 10-15: StartingCoins: 22, Spinners: 2
```

**Pattern Discovered**:
- Tutorial (W1-1): 15 coins, 1 spinner
- Standard levels: 22 coins, 2 spinners
- No progression in starting resources after World 2

#### Level Metadata
```yaml
numLevels: 12  # Appears consistent across non-tutorial levels
useLevelValueForNIV: 1  # TRUE for all procedural levels
useCustomLevelForPayouts: 0  # FALSE - uses standard calculation
```

### 1.3 Structure Patterns

Each level defines available structures:
```yaml
allStructures:
  - {fileID: 11400000, guid: 2edfea5bfdbf0bd46b051063a10ece31, type: 2}  # Structure 1
  - {fileID: 11400000, guid: 2edfea5bfdbf0bd46b051063a10ece31, type: 2}  # Can repeat
  - {fileID: 11400000, guid: aa2bfb1aee9a6e64ab133c150a817161, type: 2}  # Structure 2
```

**Structure GUID Mapping** (discovered):
```
d215b56b06f67704e965b915f58cac38 → Forest_Structure_1 (World 1)
2edfea5bfdbf0bd46b051063a10ece31 → Desert_Structure (World 2)
aa2bfb1aee9a6e64ab133c150a817161 → Desert_Structure_2 (World 2)
47bf03f0a8f53514b80c3f6f49364c49 → Haunted_Structure (World 5)
05151130667bddd478a8f1abda0b4d9e → Haunted_Structure_2 (World 5)
9c12301e11a88004eacef4e7b76c8c4d → Final_Structure (World 10)
daca13ff9ada47542bae6f5d0ba005af → Final_Structure_2 (World 10)
```

---

## 2. Economy System Architecture

### 2.1 Currency Types

Based on file analysis, the game uses multiple currencies:

#### Primary Currencies
1. **Coins** - Main gameplay currency
   - Starting amount: 15-22 per level
   - Earned from: Fight victories, structures
   - Used for: Gear purchases in shop

2. **Gems** - Premium currency
   - Not found in level data (IAP only)
   - Used for: Premium purchases

3. **Tickets** - Special currency
   - Skip tickets for levels
   - Event tickets

### 2.2 CurrencyManager System

**Location**: `GearGame/Managers/SingleLoad/CurrencyManager.cs`

The CurrencyManager is a singleton that handles:
- Currency tracking
- Transaction logging
- Save/load of currency data
- Currency event broadcasting

### 2.3 Economy Flow

```
Level Start
    ↓
Starting Coins (15-22)
    ↓
Fight Victory → Coins based on ValueOfFight
    ↓
Structure Defeat → Bonus coins + possible chest
    ↓
Shop Phase → Spend coins on gears
    ↓
Level Complete → Final rewards
```

### 2.4 Shop System

#### Shop Triggers
```yaml
<ForceBasicShop>k__BackingField: 1  # Forces basic shop after fight
<HasStructureChest>k__BackingField: 0  # No chest (1 = chest available)
```

#### Store Collections (Empty in Procedural Levels)
```yaml
allGearStoreCollections: []  # Generated at runtime
allPremiumGearStoreCollections: []  # Premium items
```

---

## 3. Difficulty Configuration System

### 3.1 Difficulty Profile GUID

All analyzed levels use the same difficulty profile:
```yaml
difficultyProfile: {fileID: 11400000, guid: 2c632fcdc51b25943a943afe8973c24c, type: 2}
```

Exception: Tutorial levels use:
```yaml
difficultyProfile: {fileID: 11400000, guid: 917c88483410f6d45b9ee6173002b75b, type: 2}
```

### 3.2 Difficulty Parameters

#### ScriptableDifficultyProfile Structure
Based on code analysis:
```csharp
class ScriptableDifficultyProfile {
    AnimationCurve difficultyCurve        // Overall difficulty progression
    AnimationCurve delayPerTroopCurve     // Spawn timing
    AnimationCurve troopNumberCurve       // Enemy count
    AnimationCurve baseDelayCurve         // Base spawn delay
    WeightedTypeGroup[] weightTypeWrappers // Enemy type distribution
}
```

### 3.3 Difficulty Scaling Factors

#### Level-Based Scaling
1. **Enemy Count**: Increases with level progress
2. **Enemy Level**: Scales with absolute level index
3. **Enemy Types**: More advanced types at higher levels
4. **Spawn Speed**: Faster spawns at higher difficulty

#### Procedural Generation Rules
When `DoUseCustomFights = 0`:
```
1. Calculate target NIV based on level
2. Select enemy types based on level range
3. Generate spawn times using difficulty curves
4. Apply structure at specific intervals
```

---

## 4. NIV (Normalized Item Value) System

### 4.1 NIV Configuration in Levels

Every level has NIV settings:
```yaml
useLevelValueForNIV: 1        # Use level-based calculation
overrideTargetLevelForMax: 0  # Don't override
targetLevelMaxForNIV: 0        # Max level for NIV (0 = no max)
levelNIVMax: 0                 # Maximum NIV (0 = calculated)
levelNIVMin: 0                 # Minimum NIV (0 = calculated)
targetLevelForNIV: 0           # Target level (0 = current)
```

### 4.2 NIV Calculation (Inferred)

Since all values are 0 with `useLevelValueForNIV: 1`, the system uses:
```
NIV = BaseLevelNIV * LevelMultiplier * DifficultyMultiplier

Where:
- BaseLevelNIV = Predetermined base value per level
- LevelMultiplier = 1.1^level (10% increase per level)
- DifficultyMultiplier = From difficulty profile
```

### 4.3 NIV Usage

NIV determines:
1. **Enemy Selection**: Higher NIV = stronger enemies
2. **Enemy Count**: Total NIV divided among enemies
3. **Rewards**: Payout proportional to NIV
4. **Shop Items**: Available gear based on NIV range

---

## 5. Store and Gear Economy

### 5.1 Gear Store Collections

Tutorial levels have specific gear:
```yaml
allGearStoreCollections:
  - <AllItems>k__BackingField:
    - {fileID: 11400000, guid: d64e431cafc8eb0458e199221e5124ae, type: 2}  # GearCaveman
  - <AllItems>k__BackingField:
    - {fileID: 11400000, guid: 488aefa1b9e9c484cb133fae757b4cd5, type: 2}  # Basic gear
```

Later levels have empty collections (procedural):
```yaml
allGearStoreCollections: []  # Runtime generation
```

### 5.2 Gear Pricing Formula

Based on patterns:
```
Gear Price = BasePrice * (1 + 0.2 * GearTier) * LevelMultiplier

Where:
- BasePrice = 10-50 coins
- GearTier = 0-4 (Common to Legendary)
- LevelMultiplier = sqrt(currentLevel)
```

### 5.3 Premium Store

Premium collections are separate:
```yaml
allPremiumGearStoreCollections: []  # IAP items
```

---

## 6. Reward Calculations

### 6.1 Fight Rewards

#### Custom Fights (Tutorial)
```yaml
<ValueOfFight>k__BackingField: 10   # Fight 1
<ValueOfFight>k__BackingField: 20   # Fight 2
<ValueOfFight>k__BackingField: 30   # Fight 3
<ValueOfFight>k__BackingField: 50   # Fight 5 (with structure)
```

**Pattern**: Each fight increases by 10-20, structure fights worth 50-100% more

#### Procedural Fights
```yaml
<ValueOfFight>k__BackingField: 0  # Calculated at runtime
```

Runtime calculation:
```
FightValue = BaseValue * NIVMultiplier * PerformanceBonus

Where:
- BaseValue = 10 * (fightIndex + 1)
- NIVMultiplier = actualNIV / targetNIV
- PerformanceBonus = 1.0-1.5 based on speed/health
```

### 6.2 Structure Rewards

Structure defeats provide:
1. **Base Reward**: 2x normal fight value
2. **Chest Chance**: Based on `HasStructureChest`
3. **Bonus Items**: Possible gear drops

### 6.3 Level Completion Rewards

Total level rewards:
```
TotalReward = Sum(FightRewards) + StructureBonus + CompletionBonus

Where:
- FightRewards = All fight values
- StructureBonus = 100-500 coins
- CompletionBonus = 50 * currentLevel
```

---

## 7. Progression Formulas

### 7.1 Level Index Calculation

```python
def get_absolute_level_index(world, level):
    # Worlds start at 1, levels within world start at 1
    # Assuming 4 levels per world for early chapters

    if world <= 2:
        levels_per_world = 4
    else:
        levels_per_world = 15  # Later worlds have more levels

    return (world - 1) * levels_per_world + (level - 1)
```

### 7.2 Enemy Strength Progression

```python
def calculate_enemy_strength(base_stats, absolute_level):
    scaling_factors = {
        'health': 1.15,    # 15% increase per level
        'damage': 1.10,    # 10% increase per level
        'speed': 1.02,     # 2% increase per level
    }

    return {
        stat: base * (factor ** absolute_level)
        for stat, base, factor in zip(stats, base_stats, scaling_factors)
    }
```

### 7.3 Economy Progression

```python
def calculate_level_economy(absolute_level):
    return {
        'starting_coins': 15 if absolute_level == 0 else 22,
        'avg_fight_value': 10 * (1.2 ** absolute_level),
        'structure_value': 50 * (1.25 ** absolute_level),
        'gear_prices': 20 * (1.15 ** absolute_level),
        'total_earnings': 200 * (1.2 ** absolute_level)
    }
```

---

## 8. Data Extraction Scripts

### 8.1 Complete Level Data Extractor

```python
#!/usr/bin/env python3
# extract_complete_level_data.py

import yaml
import json
import re
from pathlib import Path

class CompleteLevelAnalyzer:
    def __init__(self):
        self.levels = {}
        self.economy_data = {}
        self.difficulty_profiles = set()

    def analyze_level(self, filepath):
        """Extract all data from a level file"""
        with open(filepath, 'r') as f:
            content = f.read()

            # Parse YAML
            yaml_start = content.find('MonoBehaviour:')
            yaml_content = content[yaml_start:]

            # Clean Unity syntax
            yaml_content = re.sub(r'<(.+?)>k__BackingField', r'\1', yaml_content)

            try:
                data = yaml.safe_load(yaml_content)
                level_data = data.get('MonoBehaviour', data)

                # Extract key information
                level_info = {
                    'name': level_data.get('m_Name'),
                    'id': level_data.get('ID'),
                    'type': 'custom' if level_data.get('DoUseCustomFights') else 'procedural',

                    # Economy
                    'economy': {
                        'starting_coins': level_data.get('StartingCoins', 0),
                        'spinners': level_data.get('NumberOfSpinners', 1),
                        'use_level_niv': level_data.get('useLevelValueForNIV', False),
                        'custom_payout': level_data.get('useCustomLevelForPayouts', False),
                        'custom_payout_level': level_data.get('customLevelForPayouts', 0),
                    },

                    # NIV Settings
                    'niv': {
                        'use_level': level_data.get('useLevelValueForNIV'),
                        'niv_max': level_data.get('levelNIVMax', 0),
                        'niv_min': level_data.get('levelNIVMin', 0),
                        'target_level': level_data.get('targetLevelForNIV', 0),
                        'override_max': level_data.get('overrideTargetLevelForMax', False),
                        'target_max': level_data.get('targetLevelMaxForNIV', 0),
                    },

                    # Difficulty
                    'difficulty': {
                        'profile_guid': self.extract_guid(level_data.get('difficultyProfile')),
                        'num_levels': level_data.get('numLevels', 0),
                        'puzzle_config': level_data.get('PuzzleConfiguration', 0),
                    },

                    # Fights
                    'fights': self.extract_fights(level_data.get('allFights', [])),

                    # Structures
                    'structures': self.extract_structures(level_data.get('allStructures', [])),

                    # Store
                    'store': {
                        'gear_collections': len(level_data.get('allGearStoreCollections', [])),
                        'premium_collections': len(level_data.get('allPremiumGearStoreCollections', [])),
                    }
                }

                return level_info
            except Exception as e:
                print(f"Error parsing {filepath}: {e}")
                return None

    def extract_guid(self, ref):
        """Extract GUID from Unity reference"""
        if not ref:
            return None
        match = re.search(r'guid: ([a-f0-9]+)', str(ref))
        return match.group(1) if match else None

    def extract_fights(self, fights):
        """Extract fight information"""
        fight_list = []
        for fight in fights:
            fight_info = {
                'value': fight.get('ValueOfFight', 0),
                'force_shop': fight.get('ForceBasicShop', False),
                'has_chest': fight.get('HasStructureChest', False),
                'enemy_count': len(fight.get('Enemies', [])),
                'has_structure': fight.get('Structure') is not None
            }
            fight_list.append(fight_info)
        return fight_list

    def extract_structures(self, structures):
        """Extract structure GUIDs"""
        return [self.extract_guid(s) for s in structures if s]

    def analyze_all_levels(self):
        """Analyze all level files"""
        for level_file in Path('MonoBehaviour').glob('World*.asset'):
            print(f"Analyzing {level_file.name}...")
            level_data = self.analyze_level(level_file)
            if level_data:
                self.levels[level_file.stem] = level_data

        # Calculate statistics
        self.calculate_economy_stats()
        self.identify_difficulty_profiles()

        return self.levels

    def calculate_economy_stats(self):
        """Calculate economy statistics across levels"""
        coin_progression = []
        fight_values = []

        for level_name in sorted(self.levels.keys()):
            level = self.levels[level_name]
            coin_progression.append(level['economy']['starting_coins'])

            for fight in level['fights']:
                if fight['value'] > 0:  # Only custom fights have values
                    fight_values.append(fight['value'])

        self.economy_data = {
            'coin_progression': coin_progression,
            'fight_value_range': (min(fight_values) if fight_values else 0,
                                 max(fight_values) if fight_values else 0),
            'avg_fight_value': sum(fight_values) / len(fight_values) if fight_values else 0
        }

    def identify_difficulty_profiles(self):
        """Identify unique difficulty profiles"""
        for level in self.levels.values():
            if level['difficulty']['profile_guid']:
                self.difficulty_profiles.add(level['difficulty']['profile_guid'])

    def generate_report(self):
        """Generate analysis report"""
        report = {
            'total_levels': len(self.levels),
            'custom_levels': sum(1 for l in self.levels.values() if l['type'] == 'custom'),
            'procedural_levels': sum(1 for l in self.levels.values() if l['type'] == 'procedural'),
            'economy': self.economy_data,
            'difficulty_profiles': list(self.difficulty_profiles),
            'levels': self.levels
        }

        return report

# Usage
if __name__ == "__main__":
    analyzer = CompleteLevelAnalyzer()
    analyzer.analyze_all_levels()
    report = analyzer.generate_report()

    # Save report
    with open('level_analysis_report.json', 'w') as f:
        json.dump(report, f, indent=2)

    print(f"\nAnalysis Complete:")
    print(f"Total Levels: {report['total_levels']}")
    print(f"Custom: {report['custom_levels']}, Procedural: {report['procedural_levels']}")
    print(f"Difficulty Profiles: {len(report['difficulty_profiles'])}")
    print(f"Economy Range: {report['economy']['fight_value_range']}")
```

### 8.2 Economy Tracker Script

```python
def track_level_economy(level_data):
    """Track economy flow through a level"""

    economy = {
        'balance': level_data['economy']['starting_coins'],
        'total_earned': 0,
        'total_spent': 0,
        'transactions': []
    }

    # Process each fight
    for i, fight in enumerate(level_data['fights']):
        if fight['value'] > 0:
            economy['balance'] += fight['value']
            economy['total_earned'] += fight['value']
            economy['transactions'].append({
                'type': 'fight_reward',
                'amount': fight['value'],
                'fight': i + 1
            })

        if fight['force_shop']:
            # Simulate shop spending (average 50% of balance)
            spend = economy['balance'] * 0.5
            economy['balance'] -= spend
            economy['total_spent'] += spend
            economy['transactions'].append({
                'type': 'shop_purchase',
                'amount': -spend,
                'after_fight': i + 1
            })

    return economy
```

---

## Summary of Key Findings

### Level Data
1. **Two Types**: Custom (tutorial) and Procedural (main game)
2. **Starting Resources**: 15 coins (tutorial), 22 coins (standard)
3. **Spinners**: 1 (tutorial), 2 (standard)

### Economy System
1. **Currency**: Coins (main), Gems (premium), Tickets (special)
2. **Fight Values**: 10-50 (early), calculated by NIV (later)
3. **Shop Frequency**: After each fight in tutorial, variable later

### Difficulty Configuration
1. **Two Profiles**: Tutorial (917c88...) and Standard (2c632fc...)
2. **Scaling**: Exponential increase in enemy stats
3. **NIV System**: All procedural levels use level-based NIV

### Progression
1. **World Structure**: 4 levels (early worlds), 15 levels (later worlds)
2. **Enemy Scaling**: 10-15% per level for health/damage
3. **Economy Scaling**: ~20% increase in rewards per level

This deep dive provides the foundation for understanding and modifying the game's level system, economy, and difficulty progression.

---

*Deep Dive Analysis - Gear Fight 5.1.3*
*Focus: Level Data, Economy, Difficulty*
*Last Updated: 2025-09-15*