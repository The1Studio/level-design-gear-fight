# Fight Generation System - Detailed Documentation

## 1. Overview
The Fight Generation System dynamically creates combat encounters based on difficulty curves, NIV targets, and player progression. It balances procedural generation with designer-specified patterns.

## 2. Core Fight Generator

### 2.1 FightGenerator Class
**File**: `GearGame/Control/FightGenerator.cs`
**Type**: MonoBehaviour Singleton

#### Key Properties
```csharp
GameObject[] allBasicTroops          // Pool of basic enemy prefabs
GameObject[] allStartingProducers    // Initial spawner units
ScriptableTroop[] allGrunts         // Grunt-type enemies
ScriptableTroop[] allRangers        // Ranged enemies
ScriptableTroop[] allBrutes         // Heavy/tank enemies
```

#### Main Generation Method
```csharp
FightDetail GenerateFight(
    double nivTarget,                // Normalized Item Value target
    int fightLevel,                  // Current fight level
    float levelPercent,              // Progress through level (0-1)
    ScriptableDifficultyProfile difficultyProfile,  // Difficulty curves
    int fightPayout,                 // Reward amount
    int fightIndex,                  // Sequential fight number
    int seed,                        // Random seed
    ScriptableTroop structure        // Optional structure enemy
)
```

## 3. FightDetail Structure

### 3.1 FightDetail Class
**File**: `GearGame/Control/FightGenerator.cs` (Nested Class)

#### Core Properties
```csharp
class FightDetail {
    // Enemy Configuration
    List<EnemyDetail> Enemies        // All enemies in fight
    ScriptableTroop Structure        // Optional structure/building

    // Fight Metadata
    int ValueOfFight                 // Difficulty value
    int FightLevel                   // Level of this fight
    double FightNIVTarget            // Target NIV value
    int FightOffset                  // Position offset

    // Gameplay Modifiers
    bool ForceBasicShop              // Force basic shop after
    bool HasStructureChest           // Chest reward available

    // Structure Overrides
    bool overrideStructureLevel      // Custom structure level
    int structureLevelOverride       // Override level value

    // Progress Tracking
    int NumberKilled                 // Enemies defeated counter
}
```

#### Methods
```csharp
void AddNumberOfTroops(double multiplier)    // Scale enemy count
void ScaleBruteDensity(double multiplier)    // Adjust brute ratio
```

### 3.2 EnemyDetail Structure
```csharp
class EnemyDetail {
    ScriptableTroop Character        // Enemy type/prefab
    int Level                        // Enemy strength level
    float Delay                      // Spawn delay (seconds)
    bool IsBeast                     // Beast category flag

    event Action<EnemyDetail> OnCompleted  // Defeat callback
}
```

## 4. Fight Generation Algorithm

### 4.1 Generation Pipeline
```
1. Calculate Base Parameters
   ↓
2. Determine Enemy Count (based on difficulty curve)
   ↓
3. Select Enemy Types (weighted by progression)
   ↓
4. Assign Enemy Levels (distribution around target)
   ↓
5. Calculate Spawn Delays (based on pacing curve)
   ↓
6. Add Optional Structure
   ↓
7. Apply Modifiers (A/B testing, events)
   ↓
8. Validate and Return FightDetail
```

### 4.2 NIV-Based Generation
```csharp
// Pseudocode for NIV-based enemy selection
double remainingNIV = nivTarget;
while (remainingNIV > 0) {
    EnemyType enemy = SelectEnemyByWeight();
    int level = CalculateLevelForNIV(remainingNIV);
    float delay = CalculateSpawnDelay(enemyCount);

    enemies.Add(new EnemyDetail(enemy, level, delay));
    remainingNIV -= enemy.GetNIVValue(level);
}
```

### 4.3 Weighted Enemy Selection
```csharp
class TupleWrapper {
    float Proportion                 // Weight for selection
    ScriptableTroop Character        // Enemy type
}

// Selection based on level progress
WeightedTypeGroup GetEnemyWeights(float levelPercent) {
    // Early game: More grunts
    // Mid game: Balanced mix
    // Late game: More brutes and elites
}
```

## 5. Spawn Patterns and Timing

### 5.1 Delay Calculation
Spawn delays determined by:
- Base delay curve (time between spawns)
- Enemy count (more enemies = tighter spacing)
- Difficulty setting (harder = faster spawns)
- Player performance (adaptive difficulty)

### 5.2 Wave Patterns
Common patterns:
```
1. Steady Stream: Constant delay between spawns
2. Burst Waves: Groups with pauses
3. Escalating: Decreasing delays over time
4. Mixed: Combination of patterns
```

### 5.3 Spawn Timing Formula
```csharp
float CalculateDelay(int enemyIndex, AnimationCurve delayCurve) {
    float baseDelay = delayCurve.Evaluate(enemyIndex / totalEnemies);
    float variance = Random.Range(0.8f, 1.2f);
    return baseDelay * variance * difficultyMultiplier;
}
```

## 6. Structure Integration

### 6.1 Structure Spawn Rules
Structures appear based on:
- Level progression (every N fights)
- Special triggers (boss fights)
- Random chance (mini-bosses)
- Designer override (custom levels)

### 6.2 Structure Configuration
```csharp
// Structure spawn indices calculation
int[] AllStructureIndices = CalculateStructureIndices(totalFights);
// Typically: [3, 7, 11, 15, ...] for every 4th fight
```

### 6.3 Structure Types
- **Defensive**: Spawns troops, high health
- **Offensive**: Attacks player units
- **Support**: Buffs enemy units
- **Special**: Unique mechanics

## 7. Difficulty Scaling

### 7.1 Level-Based Scaling
```csharp
int[] ReturnAdjustedLevel(int numberEnemies, float percent01, Random rng) {
    // Distribute levels around target
    // Early enemies: -2 to +0 from target
    // Late enemies: -1 to +2 from target
}
```

### 7.2 Progressive Difficulty
Fight difficulty increases through:
1. **Enemy Count**: More enemies per fight
2. **Enemy Level**: Stronger individual enemies
3. **Enemy Mix**: More elite types
4. **Spawn Rate**: Faster spawn timing
5. **Special Modifiers**: Buffs, resistances

### 7.3 Difficulty Multipliers
```csharp
double difficultyMultiplier = 1.0;
difficultyMultiplier *= chapterMultiplier;      // 1.0, 1.2, 1.5...
difficultyMultiplier *= progressMultiplier;     // Based on level
difficultyMultiplier *= performanceMultiplier;  // Adaptive
difficultyMultiplier *= ABTestingMultiplier;    // A/B variations
```

## 8. Custom Fight Configuration

### 8.1 Designer-Specified Fights
When `DoUseCustomFights = true`:
- Bypass procedural generation
- Use pre-configured enemy arrays
- Exact spawn timing control
- Scripted encounters

### 8.2 Custom Fight Structure
```csharp
FightDetail customFight = new FightDetail {
    Enemies = new List<EnemyDetail> {
        new EnemyDetail(skeleton, 0.0f, 5, false),
        new EnemyDetail(skeleton, 2.0f, 5, false),
        new EnemyDetail(brute, 5.0f, 7, false)
    },
    Structure = castleStructure,
    ValueOfFight = 1000
};
```

## 9. Fight Validation

### 9.1 Validation Checks
Before returning a generated fight:
1. Minimum enemy count met
2. NIV target within tolerance (±10%)
3. Valid spawn delays (no negatives)
4. Enemy levels within bounds
5. Structure compatibility

### 9.2 Fallback Mechanisms
If generation fails:
```csharp
if (!ValidateFight(generatedFight)) {
    // Try with relaxed constraints
    // If still fails, use default template
    return GetDefaultFightTemplate(fightLevel);
}
```

## 10. Special Fight Types

### 10.1 Boss Fights
Special generation rules:
- Single powerful enemy
- Extended duration
- Multiple phases
- Special arena/grid

### 10.2 Mini-Boss Fights
```csharp
if (MiniBossSpawningController.IsCurrentLevelAMiniBossLevel()) {
    // Add mini-boss to regular fight
    // Increase rewards
    // Add special effects
}
```

### 10.3 Tutorial Fights
Simplified generation:
- Predictable patterns
- Reduced difficulty
- Guaranteed success paths
- Educational enemy placement

## 11. Reward Calculation

### 11.1 Fight Payout Formula
```csharp
int CalculatePayout(FightDetail fight) {
    int basePayout = fight.ValueOfFight;
    basePayout *= difficultyMultiplier;
    basePayout *= performanceBonus;
    basePayout += structureBonus;
    return basePayout;
}
```

### 11.2 Bonus Rewards
Additional rewards for:
- Perfect clear (no damage)
- Speed bonus (quick completion)
- Combo chains
- Special objectives

## 12. A/B Testing Integration

### 12.1 Testable Parameters
- Enemy density variations
- Spawn timing adjustments
- Difficulty curve shapes
- Reward multipliers
- Structure frequency

### 12.2 Configuration Files
- `ABTestingDifficultyConfig.cs`
- `ABTestingMiniBossesConfig.cs`
- Fight variation configs

## 13. Performance Optimization

### 13.1 Generation Caching
- Pre-generate next fight during current
- Cache common enemy combinations
- Reuse spawn patterns

### 13.2 Memory Management
- Pool enemy instances
- Lazy load enemy assets
- Clean up completed fights

## 14. Debug Features

### 14.1 Fight Simulation
```csharp
// Debug mode: Generate specific fight
FightDetail debugFight = GenerateFight(
    nivTarget: 1000,
    fightLevel: 10,
    levelPercent: 0.5f,
    // ... other params
);
```

### 14.2 Visualization Tools
- Spawn timeline viewer
- NIV distribution graph
- Difficulty curve display
- Enemy mix breakdown

## 15. Implementation Guidelines

### 15.1 Creating New Fight Patterns
1. Define enemy composition goals
2. Calculate appropriate NIV targets
3. Design spawn timing curve
4. Test difficulty progression
5. Validate reward balance

### 15.2 Balancing Considerations
- Early fights: 3-5 enemies, 10-15 seconds
- Mid fights: 8-12 enemies, 20-30 seconds
- Late fights: 15-20 enemies, 30-45 seconds
- Boss fights: Variable, 60+ seconds

### 15.3 Common Issues
- NIV overflow causing impossible fights
- Spawn delays creating dead time
- Enemy level spikes breaking progression
- Missing enemy prefab references

## 16. File References

### Core Files
- `GearGame/Control/FightGenerator.cs`
- `GearGame/Control/ScriptableFightConfiguration.cs`
- `GearGame/Gameplay/GameProgressManager.cs`

### Configuration
- `GearGame/Control/ScriptableDifficultyProfile.cs`
- `ABTestingDifficultyConfig.cs`
- `ABTestingMiniBossesConfig.cs`

### Supporting Systems
- `GearGame/Gameplay/Managers/EnemyManager.cs`
- `Assets/Scripts/Gameplay/Control/MiniBossSpawningController.cs`

---

*Generated from Gear Fight 5.1.3 Level System Analysis*