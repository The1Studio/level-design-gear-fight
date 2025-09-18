# Gear Fight Level Data Documentation

## Table of Contents

1. [Overview](#1-overview)
2. [Level Hierarchy Structure](#2-level-hierarchy-structure)
3. [Chapter System](#3-chapter-system)
4. [Level Configuration](#4-level-configuration)
5. [Fight System](#5-fight-system)
6. [Enemy & Troop System](#6-enemy--troop-system)
7. [Difficulty System](#7-difficulty-system)
8. [Grid & Puzzle System](#8-grid--puzzle-system)
9. [Progression System](#9-progression-system)
10. [Rewards System](#10-rewards-system)
11. [Boss System](#11-boss-system)
12. [Save System](#12-save-system)
13. [File Structure Reference](#13-file-structure-reference)

---

## 1. Overview

Gear Fight uses a hierarchical level system with the following structure:
- **Worlds/Chapters** → **Levels** → **Fights** → **Enemy Waves**

The game employs a puzzle-based combat system where players place gears on a grid to defeat waves of enemies across multiple fights within each level.

---

## 2. Level Hierarchy Structure

### 2.1 Hierarchy Breakdown

```
Game
├── Chapters (Worlds)
│   ├── Chapter 1
│   │   ├── Level 1
│   │   │   ├── Fight 1
│   │   │   │   ├── Enemy Wave 1
│   │   │   │   ├── Enemy Wave 2
│   │   │   │   └── ...
│   │   │   ├── Fight 2
│   │   │   └── ...
│   │   ├── Level 2
│   │   └── ...
│   ├── Chapter 2
│   └── ...
```

### 2.2 Key Components

- **Chapters**: Major game segments with unique themes and environments
- **Levels**: Individual gameplay sessions within chapters
- **Fights**: Combat encounters within levels
- **Waves**: Enemy spawn patterns within fights

---

## 3. Chapter System

### 3.1 Chapter Configuration (`ChapterSettings.cs`)

Each chapter is defined by a `ChapterSettings` ScriptableObject containing:

#### General Settings
- `ID`: Unique chapter identifier
- `DisplayNameLocalizationKey`: Localization key for chapter name
- `ShowWorldUnlock`: Boolean for world unlock display
- `EnvironmentTheme`: Visual theme (EnvironmentThemeView)
- `MainMusic`: Background music (AudioClip)
- `SlopeSprite`: Terrain sprite

#### Content Arrays
- `Levels[]`: Array of ScriptableLevel objects
- `AllMiniBosses[]`: Array of mini-boss troops
- `ChapterSpecificUnlocks[]`: Unlockable upgrades

#### UI Elements
- `LocalizationStrings[]`: One-time unlock sequence text
- `ShowPopupEveryLevelStart`: Boss level popup configuration

### 3.2 Chapter Progression (`ChaptersProgressionSettings.cs`)

Manages the overall chapter progression:
- `ProgressionName`: Name of the progression set
- `chapters[]`: Ordered array of ChapterSettings
- Methods for chapter/level indexing and navigation

---

## 4. Level Configuration

### 4.1 ScriptableLevel Structure (`ScriptableLevel.cs`)

Each level is a ScriptableObject containing:

#### Core Properties
- `ID`: Unique level identifier
- `numLevels`: Total number of sub-levels
- `StartingCoins`: Initial currency amount
- `NumberOfSpinners`: Available gear spinners
- `TutorialSkipString`: Tutorial skip identifier

#### Fight Configuration
- `allFights[]`: Array of FightDetail configurations
- `allStructures[]`: Array of structure troops
- `DoUseCustomFights`: Use custom fight patterns
- `DoUseCustomGears`: Use custom gear sets

#### Economy Settings
- `useLevelValueForNIV`: Use level value for NIV calculation
- `useCustomLevelForPayouts`: Custom payout configuration
- `customLevelForPayouts`: Custom payout level value
- `levelNIVMax`: Maximum NIV value
- `levelNIVMin`: Minimum NIV value
- `targetLevelForNIV`: Target level for NIV calculation

#### Store Collections
- `allGearStoreCollections[]`: Regular gear store items
- `allPremiumGearStoreCollections[]`: Premium gear store items

#### Puzzle Configuration
- `PuzzleConfiguration`: Puzzle difficulty setting (Control/More/Many)
- `CustomLevelGrid`: Custom grid layout data

#### Difficulty
- `difficultyProfile`: Reference to ScriptableDifficultyProfile

---

## 5. Fight System

### 5.1 Fight Generation (`FightGenerator.cs`)

The FightGenerator creates dynamic combat encounters:

#### Generation Parameters
- `nivTarget`: Normalized Item Value target
- `fightLevel`: Current fight level
- `levelPercent`: Progress percentage
- `difficultyProfile`: Difficulty configuration
- `fightPayout`: Reward amount
- `fightIndex`: Fight sequence number
- `seed`: Random seed for generation
- `structure`: Optional structure enemy

### 5.2 FightDetail Structure

Each fight contains:

#### Enemy Configuration
```csharp
class EnemyDetail {
    ScriptableTroop Character    // Enemy type
    int Level                     // Enemy level
    float Delay                   // Spawn delay
    bool IsBeast                  // Beast type flag
}
```

#### Fight Properties
- `Enemies[]`: List of enemy details
- `Structure`: Optional structure/building enemy
- `ValueOfFight`: Fight difficulty value
- `ForceBasicShop`: Force basic shop appearance
- `FightOffset`: Fight position offset
- `HasStructureChest`: Structure chest availability
- `FightLevel`: Current fight level
- `FightNIVTarget`: Target NIV value

---

## 6. Enemy & Troop System

### 6.1 Troop Categories (`ScriptableTroop.cs`)

Troops are categorized as:
- **Grunts**: Basic melee enemies
- **Rangers**: Ranged attackers
- **Brutes**: Heavy/tank enemies
- **Structures**: Defensive buildings
- **Bosses**: Major enemies
- **Mini-Bosses**: Mid-level bosses

### 6.2 Enemy Types

#### Standard Enemies
- Caveman, Skeleton, Zombie Grunt
- Viking, Spartan, Ninja, Samurai
- Robot Melee, Robot Ranged
- Possessed Rat, Infected Wolf
- Shaman, Tribe

#### Special Enemies
- The Count, Death Knight
- Necromancer (spawns skeletons)
- Flying Demon, Cave Bat
- Forest Guardian, Ice Golem

#### Bosses
- Robot Boss Two
- Robot Boss Three
- The Factory Boss
- Mini-Bosses (various)

### 6.3 Enemy Data Structure

Each enemy type has a data class containing:
- Health points
- Attack damage
- Movement speed
- Attack range
- Special abilities
- Visual/animation references

---

## 7. Difficulty System

### 7.1 Difficulty Profile (`ScriptableDifficultyProfile.cs`)

Controls difficulty scaling:

#### Curves
- `difficultyCurve`: Overall difficulty progression
- `delayPerTroopCurve`: Enemy spawn timing
- `troopNumberCurve`: Enemy quantity scaling
- `baseDelayCurve`: Base spawn delay

#### Level Adjustment
- `allLevelAddersProportion[]`: Level modifier proportions
- `weightTypeWrappers[]`: Enemy type weight groups
- `ElitePercent01`: Elite enemy spawn percentage

### 7.2 Difficulty Factors

Difficulty is influenced by:
1. Player progression (level/chapter)
2. NIV (Normalized Item Value) targets
3. Enemy level scaling
4. Spawn timing and density
5. Elite enemy frequency

---

## 8. Grid & Puzzle System

### 8.1 Grid Configuration (`ScriptableGridData.cs`)

Grid layouts define gear placement puzzles:

```csharp
class PegGears {
    GearPeg PegObject           // Peg placement point
    GameObject GearObject        // Gear visual
    string PegInformation       // Peg metadata
    string GearInformation      // Gear metadata
    ScriptableGear ScriptableGear  // Gear data
    LockType LockType           // Lock state
}
```

### 8.2 Puzzle Configurations

Three difficulty levels (`ABTestingPuzzlesConfig.cs`):
- **Control**: Standard puzzle complexity
- **More**: Increased complexity
- **Many**: Maximum complexity

---

## 9. Progression System

### 9.1 Game Progress Manager (`GameProgressManager.cs`)

Manages level progression:

#### Key Properties
- `CurrentChapterIndex`: Active chapter
- `FightIndex`: Current fight in level
- `TotalLevels`: Total level count
- `IsMaxLevel`: Maximum level reached flag

#### Progression Methods
- `SetLevel()`: Initialize level
- `ProgressForward()`: Advance to next fight
- `GenerateFights()`: Create fight sequence

### 9.2 Save Points

Progress is saved at:
- Level completion
- Fight victories
- Chapter completion
- Gear/troop unlocks

---

## 10. Rewards System

### 10.1 Reward Types

#### Level Rewards
- Coins (currency)
- Gems (premium currency)
- Gear unlocks
- Troop unlocks

#### Chapter Rewards (`ChapterRewardsManager.cs`)
- Chapter completion bonuses
- Milestone rewards
- Special unlocks

### 10.2 Reward Calculation

Rewards based on:
- Fight difficulty (NIV)
- Player performance
- Level progression
- Chapter milestones

---

## 11. Boss System

### 11.1 Boss Types

#### Main Bosses
- Chapter-ending bosses
- Special mechanics
- Multiple phases

#### Mini-Bosses (`MiniBossController.cs`)
- Random spawn chances
- Special rewards
- Optional encounters

### 11.2 Boss Configuration

Boss levels include:
- Custom grid layouts
- Special enemy patterns
- Unique rewards
- Story elements

---

## 12. Save System

### 12.1 Level Save Data (`ScriptableLevelData.cs`)

```csharp
class LevelData {
    bool Completed          // Level completion status
    // Additional level-specific data
}
```

### 12.2 Chapter Save Data (`ChapterSave.cs`)

```csharp
class ChapterSave {
    int ChapterRewardsPending      // Unclaimed rewards
    int ChapterRewardsClaimed      // Claimed rewards
    int ChapterRewardsChestsClaimed // Chest rewards
}
```

### 12.3 Progress Persistence

Saved data includes:
- Level completion states
- Fight progress
- Unlocked content
- Player statistics
- Currency amounts

---

## 13. File Structure Reference

### 13.1 Core Level Files

#### Configuration
- `/ScriptableTemplates/ChapterSettings.cs` - Chapter configuration
- `/ScriptableTemplates/ChaptersProgressionSettings.cs` - Progression management
- `/GearGame/Gameplay/ScriptableLevel.cs` - Level definitions

#### Management
- `/GearGame/Gameplay/GameProgressManager.cs` - Progress tracking
- `/GearGame/Control/WorldSettingsManager.cs` - World settings
- `/GearGame/Managers/SingleLoad/ChapterRewardsManager.cs` - Rewards

#### Fight System
- `/GearGame/Control/FightGenerator.cs` - Fight generation
- `/GearGame/Control/ScriptableFightConfiguration.cs` - Fight config
- `/GearGame/Gameplay/Managers/GameStateManager.cs` - Game states

#### Enemies
- `/GearGame/Control/ScriptableTroop.cs` - Troop definitions
- `/GearGame/Gameplay/Troop*.cs` - Individual troop controllers
- `/GearGame/Gameplay/Managers/EnemyManager.cs` - Enemy management

#### Grid/Puzzle
- `/GearGame/Control/ScriptableGridData.cs` - Grid layouts
- `/GearGame/Control/GridData.cs` - Grid data structures
- `/GearGame/Gameplay/GearGridController.cs` - Grid gameplay

#### Difficulty
- `/GearGame/Control/ScriptableDifficultyProfile.cs` - Difficulty curves
- `/ABTestingDifficultyConfig.cs` - A/B testing configs

#### Save System
- `/SaveSystem/SaveData/ScriptableLevelData.cs` - Level saves
- `/SaveSystem/SaveData/ChapterSave.cs` - Chapter saves
- `/GearGame/Gameplay/Managers/GameProgressSaveManager.cs` - Save management

### 13.2 Data Organization

```
Scripts/Assembly-CSharp/
├── GearGame/
│   ├── Gameplay/          # Gameplay mechanics
│   ├── Control/           # Game control systems
│   ├── Managers/          # Singleton managers
│   ├── UI/                # UI controllers
│   └── Tutorials/         # Tutorial systems
├── ScriptableTemplates/   # ScriptableObject templates
├── SaveSystem/            # Save/load functionality
└── ABTesting*.cs          # A/B testing configurations
```

---

## Notes

1. **Decompiled Code**: This codebase appears to be decompiled from Unity assemblies, so some implementation details may be obfuscated
2. **ScriptableObjects**: Heavy use of Unity's ScriptableObject system for data configuration
3. **A/B Testing**: Multiple A/B testing configurations for gameplay tuning
4. **Modular Design**: Level, fight, and enemy systems are highly modular and configurable
5. **Dynamic Generation**: Fights and enemy waves are procedurally generated based on difficulty curves and NIV targets

---

*Document generated from Gear Fight 5.1.3 codebase analysis*