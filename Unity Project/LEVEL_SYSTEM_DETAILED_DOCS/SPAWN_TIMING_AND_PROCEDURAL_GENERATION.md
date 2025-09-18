# Spawn Timing and Procedural Generation Deep Dive

## Critical Discovery: Two Distinct Level Systems

After extracting all 134 levels to JSON, a crucial pattern emerged:
- **1 level** (World 1-1) uses custom/scripted fights with actual enemy data
- **133 levels** use procedural generation with empty placeholder data

## Why Asset Files Have "Default" Data

### The Empty Fight Pattern
```yaml
allFights:
  - <Enemies>k__BackingField:
    - <Character>k__BackingField: {fileID: 0}  # NULL reference
      <Level>k__BackingField: 0                # Default value
      <Delay>k__BackingField: 0                # Default value
      <IsBeast>k__BackingField: 0              # Default value
```

**These are NOT missing data** - they are intentional placeholder structures that get populated at runtime.

### Key Fields in Procedural Levels
```yaml
<DoUseCustomFights>k__BackingField: 0  # FALSE - use procedural generation
numLevels: 12                          # Generate 12 fights dynamically
useLevelValueForNIV: 1                 # Use NIV system for enemy selection
difficultyProfile: {guid: 2c632fcdc51b25943a943afe8973c24c}  # Difficulty curves
```

## Spawn Timing Systems

### 1. Custom/Scripted Timing (World 1-1 Tutorial Only)

Hand-crafted spawn patterns stored directly in the asset:

```
Fight 1: Tutorial Introduction
  Enemy 1: TroopTutorialCaveman | Delay: 1s | Level: 0

Fight 2-3: Single Enemy Pattern
  Enemy 1: TroopCaveman | Delay: 5s | Level: 0

Fight 4: Dual Enemy Introduction
  Enemy 1: TroopCaveman | Delay: 5s | Level: 0
  Enemy 2: TroopWolfOne | Delay: 8s | Level: 0

Fight 5: Multi-Enemy Combat
  Enemy 1: TroopCaveman | Delay: 5s  | Level: 0
  Enemy 2: TroopTribe   | Delay: 10s | Level: 0
  Enemy 3: TroopWolfOne | Delay: 15s | Level: 0
```

**Pattern Analysis:**
- Progressive complexity: 1 → 1 → 1 → 2 → 3 enemies
- Increasing spawn intervals: 5s base, +3s, +5s for additional enemies
- Introduces new enemy types gradually

### 2. Procedural Timing (All Other 133 Levels)

Dynamic calculation using ScriptableDifficultyProfile curves:

#### Core Components

```csharp
public class ScriptableDifficultyProfile : ScriptableObject
{
    // Animation curves that control spawn timing
    AnimationCurve delayPerTroopCurve;   // Delay between each enemy
    AnimationCurve baseDelayCurve;       // Initial delay before first enemy
    AnimationCurve troopNumberCurve;     // Number of enemies to spawn

    // Enemy type distribution
    WeightedTypeGroup[] weightTypeWrappers;  // Enemy type probabilities
}
```

#### Runtime Generation Process

1. **FightGenerator.GenerateFight() Parameters:**
   ```csharp
   GenerateFight(
       double nivTarget,                    // NIV target for enemy strength
       int fightLevel,                     // Current fight number
       float levelPercent,                 // Progress through level (0.0-1.0)
       ScriptableDifficultyProfile profile, // Difficulty curves
       int fightPayout,                    // Coins/rewards
       int fightIndex,                     // Fight sequence number
       int seed,                           // Random seed
       ScriptableTroop structure           // Structure/building type
   )
   ```

2. **Timing Calculation:**
   - `levelPercent` (0.0 to 1.0) is used to sample animation curves
   - Early fights (low percent): Longer delays, fewer enemies
   - Late fights (high percent): Shorter delays, more enemies
   - Example curve progression:
     ```
     Level 0%:  baseDelay=8s, perTroopDelay=5s, troopCount=1-2
     Level 50%: baseDelay=5s, perTroopDelay=3s, troopCount=2-3
     Level 100%: baseDelay=3s, perTroopDelay=2s, troopCount=3-5
     ```

## Enemy Selection and Order

### Custom Levels
- Manually specified enemy types in exact order
- Each enemy has predetermined stats and timing

### Procedural Levels

#### Enemy Categories
```csharp
ScriptableTroop[] allGrunts;   // Basic melee units
ScriptableTroop[] allRangers;  // Ranged attackers
ScriptableTroop[] allBrutes;   // Heavy/tank units
```

#### Selection Process
1. **Weight-based Category Selection:**
   ```csharp
   WeightedTypeWrapper[] {
       { Weight: 0.6, Category: Grunt },
       { Weight: 0.3, Category: Ranger },
       { Weight: 0.1, Category: Brute }
   }
   ```

2. **Elite Variant Chance:**
   - `ElitePercent01`: Probability of spawning stronger variant
   - Scales with player progression

3. **Spawn Order Pattern:**
   - Typically: Weakest → Strongest within each fight
   - May mix categories based on weights
   - Example spawn sequence:
     ```
     [Grunt, Grunt, Ranger, Grunt, Brute]  // Weighted random selection
     ```

## Structure Integration

Both systems reference structures (buildings/obstacles):
```yaml
allStructures:
  - {fileID: 11400000, guid: 2edfea5bfdbf0bd46b051063a10ece31}  # Desert_Structure_1
  - {fileID: 11400000, guid: aa2bfb1aee9a6e64ab133c150a817161}  # Desert_Structure_2
```

Structures are:
- Always predefined (not procedural)
- Provide environmental obstacles
- May spawn defensive units
- Affect pathfinding and strategy

## Key Insights

1. **Placeholder Design is Intentional**
   - Empty `{fileID: 0}` references are not bugs or missing data
   - They're template slots filled at runtime
   - Allows infinite variation from same level file

2. **Difficulty Scaling**
   - Animation curves provide smooth difficulty progression
   - Same level plays differently at different player levels
   - NIV system ensures appropriate challenge

3. **Randomization with Control**
   - Seed-based generation for reproducibility
   - Weighted probabilities maintain game balance
   - Progressive complexity through level percent

4. **Memory Efficiency**
   - 133 levels share same generation logic
   - No need to store thousands of enemy configurations
   - Reduces game size significantly

## File References

- **Custom Fight Example:** `/MonoBehaviour/World 1 - Level 1.asset`
- **Procedural Template:** `/MonoBehaviour/World 2 - Level 1.asset` (and 132 others)
- **Fight Generator:** `/Scripts/Assembly-CSharp/GearGame/Control/FightGenerator.cs`
- **Difficulty Profile:** `/Scripts/Assembly-CSharp/GearGame/Control/ScriptableDifficultyProfile.cs`
- **Level Configuration:** `/Scripts/Assembly-CSharp/GearGame/Gameplay/ScriptableLevel.cs`

## Extraction Statistics

From `gear_fight_complete_levels.json`:
```json
{
  "statistics": {
    "total_levels": 134,
    "custom_fight_levels": 1,    // Only World 1-1
    "procedural_levels": 133,     // Everything else
    "total_fights": 138,          // Only counts custom fights
    "total_enemies": 407,         // Only from custom fights
    "unique_enemies": 4,          // In custom fights
    "unique_structures": 30       // Across all levels
  }
}
```

## Important Notes for Future Development

1. **When Modifying Levels:**
   - Custom fights: Edit the asset file directly
   - Procedural levels: Modify difficulty curves or NIV parameters
   - Don't add enemy data to procedural levels - it will be ignored

2. **When Analyzing Difficulty:**
   - Look at difficulty profile curves, not level files
   - Level files only show structure options and basic parameters
   - Actual challenge comes from runtime generation

3. **When Creating New Content:**
   - Tutorial/scripted sequences: Use `DoUseCustomFights: 1`
   - Standard gameplay: Use `DoUseCustomFights: 0` with appropriate NIV settings
   - Structures can be mixed in both types