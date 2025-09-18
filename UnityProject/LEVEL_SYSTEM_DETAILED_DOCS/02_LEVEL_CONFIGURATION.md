# Level Configuration - Detailed Documentation

## 1. Overview
Levels are individual gameplay sessions within chapters, each containing multiple fights, puzzle configurations, and reward structures. The level system is highly configurable through ScriptableObjects.

## 2. Core Level Structure

### 2.1 ScriptableLevel
**File**: `GearGame/Gameplay/ScriptableLevel.cs`
**Type**: SerializedScriptableObject (Odin Inspector)
**Menu Path**: "Gameplay/Level"

#### Primary Configuration
```csharp
string ID                           // Unique level identifier (GUID)
int numLevels                       // Number of sub-levels/variations
int StartingCoins                   // Initial currency for the level
int NumberOfSpinners                // Available gear placement spinners
string TutorialSkipString           // Tutorial bypass identifier
```

#### Combat Configuration
```csharp
FightDetail[] allFights             // Array of all fights in the level
ScriptableTroop[] allStructures     // Available structure enemies
bool DoUseCustomFights              // Override procedural generation
bool DoUseCustomGears               // Use predefined gear sets
```

#### Economy System
```csharp
bool useLevelValueForNIV            // Use level-based NIV calculation
bool useCustomLevelForPayouts       // Override payout calculation
int customLevelForPayouts           // Custom payout multiplier
double levelNIVMax                  // Maximum Normalized Item Value
double levelNIVMin                  // Minimum Normalized Item Value
int targetLevelForNIV               // Target level for NIV scaling
bool overrideTargetLevelForMax      // Override max level targeting
int targetLevelMaxForNIV            // Maximum level for NIV
```

#### Store Configuration
```csharp
ItemCollection[] allGearStoreCollections         // Regular store items
ItemCollection[] allPremiumGearStoreCollections  // Premium store items

class ItemCollection {
    ScriptableGear[] AllItems     // Available gears in collection
}
```

#### Puzzle Configuration
```csharp
PuzzleConfigs PuzzleConfiguration   // Puzzle difficulty setting
ScriptableGridData CustomLevelGrid  // Custom grid layout
ScriptableDifficultyProfile difficultyProfile  // Difficulty curves
```

## 3. Level Types

### 3.1 Standard Levels
Regular progression levels with:
- 3-7 fights per level
- Progressive difficulty
- Standard rewards
- Optional structures

### 3.2 Boss Levels
Special levels featuring:
- Single boss fight
- Extended combat duration
- Special mechanics
- Enhanced rewards
- Custom grid layouts

### 3.3 Mini-Boss Levels
Random chance levels with:
- Mini-boss encounter
- Additional rewards
- Collectible drops
- Optional combat

### 3.4 Tutorial Levels
Guided levels with:
- Restricted mechanics
- Forced gear placement
- Guaranteed success paths
- Educational popups

### 3.5 Puzzle Levels
Focus on grid mechanics:
- Complex gear arrangements
- Limited resources
- Time constraints
- Bonus objectives

## 4. Level Progression System

### 4.1 GameProgressManager
**File**: `GearGame/Gameplay/GameProgressManager.cs`

#### Level State Management
```csharp
ScriptableLevel LevelOn             // Current active level
int FightIndex                      // Current fight within level
int TotalLevels                     // Total levels in game
bool IsMaxLevel                     // Maximum level reached
FightDetail[] AllFights             // All fights for current level
```

#### Progression Methods
- `SetLevel()`: Initialize level configuration
- `GenerateFights()`: Create fight sequence
- `ProgressForward(float delay)`: Advance to next fight
- `Initialize()`: Set up level resources

### 4.2 Level Indexing System
Absolute level index calculation:
```
AbsoluteIndex = ChapterIndex * LevelsPerChapter + LocalLevelIndex
```

Example:
- Chapter 2, Level 5 with 20 levels per chapter
- Absolute Index = 2 * 20 + 5 = 45

## 5. Fight Configuration Within Levels

### 5.1 FightDetail Structure
```csharp
class FightDetail {
    List<EnemyDetail> Enemies        // Enemy spawn configuration
    ScriptableTroop Structure        // Optional structure enemy
    int ValueOfFight                 // Fight difficulty value
    bool ForceBasicShop              // Force basic shop appearance
    int FightOffset                  // Position offset
    bool HasStructureChest           // Structure chest availability
    int FightLevel                   // Current fight level
    double FightNIVTarget            // Target NIV for fight

    // Structure overrides
    bool overrideStructureLevel      // Override structure level
    int structureLevelOverride       // Custom structure level
}
```

### 5.2 EnemyDetail Configuration
```csharp
class EnemyDetail {
    ScriptableTroop Character        // Enemy type reference
    int Level                        // Enemy level/strength
    float Delay                      // Spawn delay timing
    bool IsBeast                     // Beast category flag
}
```

## 6. Level Economy System

### 6.1 NIV (Normalized Item Value) System
NIV represents the relative power/value of items and enemies:

```
NIV Calculation:
- Base NIV = levelNIVMin + (levelNIVMax - levelNIVMin) * levelProgress
- Adjusted NIV = Base NIV * difficultyMultiplier
- Final NIV = Adjusted NIV * ABTestingModifier
```

### 6.2 Payout Calculation
```csharp
Tuple<double, double> GetFightPayout(int levelOn) {
    if (useCustomLevelForPayouts) {
        return CalculatePayout(customLevelForPayouts);
    }
    return CalculatePayout(levelOn);
}
```

### 6.3 Currency Distribution
- Starting coins: Defined per level
- Fight rewards: Based on NIV and difficulty
- Bonus rewards: Structure defeats, perfect clears
- Premium currency: Special achievements

## 7. Grid and Puzzle Integration

### 7.1 Grid Configuration per Level
```csharp
ScriptableGridData CustomLevelGrid  // Custom grid layout
```

Grid layouts can be:
- Standard (5x5, 6x6, 7x7)
- Custom shapes (L-shape, cross, diamond)
- Dynamic (changes per fight)
- Restricted (locked positions)

### 7.2 Puzzle Difficulty Settings
```csharp
enum PuzzleConfigs {
    Control = 0,    // Standard difficulty
    More = 1,       // Increased complexity
    Many = 2        // Maximum complexity
}
```

## 8. Store System Integration

### 8.1 Level Store Collections
Each level defines available items:
```csharp
ItemCollection[] allGearStoreCollections {
    // Tier 1: Common items
    // Tier 2: Uncommon items
    // Tier 3: Rare items
}

ItemCollection[] allPremiumGearStoreCollections {
    // Premium/paid items
    // Special offers
    // Time-limited deals
}
```

### 8.2 Store Appearance Logic
- After each fight (if not forced basic)
- Special triggers (structure defeat)
- Currency thresholds reached
- Premium store: Special conditions

## 9. Level Save System

### 9.1 ScriptableLevelData
**File**: `SaveSystem/SaveData/ScriptableLevelData.cs`

```csharp
class LevelData {
    bool Completed                   // Level completion status
    // Additional tracked data:
    // - Best score
    // - Stars earned
    // - Collectibles found
    // - Time spent
}

Dictionary<string, LevelData> LevelsData  // All level save data
```

### 9.2 Save Triggers
- Fight completion
- Level completion
- Game pause
- Background/foreground
- Checkpoint reached

## 10. Tutorial Integration

### 10.1 Tutorial Skip System
```csharp
string TutorialSkipString  // Identifier to bypass tutorials
```

Allows experienced players to skip:
- Gear placement tutorials
- Combat explanations
- Store introductions
- Upgrade guides

### 10.2 Level-Specific Tutorials
First appearance triggers:
- New enemy type
- New gear mechanic
- Special structure
- Boss encounter

## 11. A/B Testing Configurations

### 11.1 Level Variation Testing
- Fight count variations
- Enemy density adjustments
- Reward multipliers
- Difficulty curves

### 11.2 Configuration Files
- `ABTestingDifficultyConfig.cs`
- `ABTestingPuzzlesConfig.cs`
- `ABTestingStructureChestConfig.cs`

## 12. Special Level Features

### 12.1 Structure Chests
```csharp
bool HasStructureChest  // Chest availability after structure defeat
```

Rewards:
- Bonus currency
- Rare gears
- Premium items
- Unlock tokens

### 12.2 Level Modifiers
- Double speed mode
- No-fail mode (tutorial)
- Challenge mode
- Time attack

### 12.3 Environmental Effects
- Weather systems
- Day/night cycles
- Seasonal events
- Special visual effects

## 13. Level Generation Pipeline

### 13.1 Level Initialization Flow
```
1. Load ScriptableLevel asset
2. Initialize grid configuration
3. Generate/load fights array
4. Set starting resources
5. Configure store collections
6. Apply A/B testing modifiers
7. Initialize UI elements
8. Start first fight
```

### 13.2 Fight Transition Flow
```
Fight Complete →
    Calculate Rewards →
    Update Progress →
    Check Store Trigger →
    Save Progress →
    Load Next Fight/Complete Level
```

## 14. Performance Optimization

### 14.1 Level Asset Management
- Lazy loading of fight data
- Object pooling for enemies
- Texture streaming for backgrounds
- Audio clip management

### 14.2 Memory Footprint
Typical level memory usage:
- Base level data: 2-5 MB
- Grid configuration: 1-2 MB
- Enemy sprites: 10-20 MB
- Audio: 5-10 MB
- Total: ~40 MB per level

## 15. Debug and Testing

### 15.1 Simulation Level
**File**: `Resources/CombatSimulationLevel.asset`

Special configuration:
- 99 levels for extended testing
- 999 starting coins
- All features unlocked
- Debug grid layouts

### 15.2 Level Validation
Required checks:
- All fights have valid enemies
- NIV values within bounds
- Store collections not empty
- Grid data properly configured
- Tutorial strings valid

## 16. Implementation Guidelines

### 16.1 Creating New Levels
1. Create ScriptableLevel asset
2. Set unique ID (GUID)
3. Configure fights (3-7 recommended)
4. Set appropriate NIV range
5. Define store collections
6. Test difficulty curve
7. Validate save/load

### 16.2 Balancing Considerations
- Early levels: 3-4 fights, simple grids
- Mid levels: 5-6 fights, complex grids
- Late levels: 6-7 fights, challenge grids
- Boss levels: 1 extended fight

### 16.3 Common Issues
- Null fight arrays crash on load
- Missing grid data causes default grid
- Invalid NIV ranges break economy
- Circular level references freeze game

## 17. File References

### Core Files
- `GearGame/Gameplay/ScriptableLevel.cs`
- `GearGame/Gameplay/GameProgressManager.cs`
- `GearGame/Control/FightGenerator.cs`

### Configuration Files
- `GearGame/Control/ScriptableGridData.cs`
- `GearGame/Control/ScriptableDifficultyProfile.cs`
- `ABTestingPuzzlesConfig.cs`

### Save System
- `SaveSystem/SaveData/ScriptableLevelData.cs`
- `GearGame/Gameplay/Managers/GameProgressSaveManager.cs`

### Asset Examples
- `Resources/CombatSimulationLevel.asset`
- Grid configuration assets
- Difficulty profile assets

---

*Generated from Gear Fight 5.1.3 Level System Analysis*