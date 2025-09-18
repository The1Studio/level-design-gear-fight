# Difficulty Curves and Animation Curves Deep Analysis

## Discovery: The Math Behind Procedural Generation

After extracting and analyzing the difficulty profile assets, we've uncovered the precise mathematical formulas that control enemy spawning, timing, and difficulty progression in Gear Fight.

## Difficulty Profile: "Linear 50%"

This is the primary difficulty profile used by 130+ levels (GUID: `2c632fcdc51b25943a943afe8973c24c`).

### 1. Difficulty Curve
Controls overall difficulty progression from 0 (start) to 1 (end):
```
Time: 0.0 → Value: 0.0 (slope: 2.0)
Time: 0.5 → Value: 1.0 (slope: 2.0)
```
This creates a linear ramp that reaches maximum difficulty at 50% level completion, then plateaus.

### 2. Enemy Level Variations
Adds randomness to enemy levels to create variety:
```
40% chance: +0 levels (same as base)
25% chance: +1 level (slightly stronger)
25% chance: -1 level (slightly weaker)
10% chance: -2 levels (much weaker)
```

### 3. Spawn Delay Curves (delayPerTroopCurve)

Controls the time between each enemy spawn based on level progression:

| Level Progress | Delay Between Spawns |
|---------------|---------------------|
| 0% (Start)    | 3.01 seconds       |
| 25%           | 2.84 seconds       |
| 50%           | 2.67 seconds       |
| 75%           | 2.48 seconds       |
| 100%          | 2.29 seconds       |
| 200%          | 2.27 seconds       |
| 300%          | 2.29 seconds       |
| 400%          | 2.08 seconds       |
| 500%          | 1.90 seconds       |
| 600%          | 1.44 seconds       |
| 800% (Max)    | 1.32 seconds       |

**Pattern**: Delays start at 3 seconds and gradually decrease to 1.3 seconds for intense late-game fights.

### 4. Enemy Count Curves (troopNumberCurve)

Determines how many enemies spawn in each fight:

| Level Progress | Enemy Count |
|---------------|-------------|
| 0% (Start)    | 3 enemies   |
| 100%          | 5.8 enemies |
| 200%          | 7.7 enemies |
| 300%          | 9.6 enemies |
| 400%          | 11.5 enemies|
| 600%          | 16.2 enemies|
| 800% (Max)    | 20.0 enemies|

**Formula**: Approximately `3 + (2 * progress)` with slight exponential growth.

### 5. Initial Delay Curves (baseDelayCurve)

Time before the first enemy appears:

| Level Progress | Initial Delay |
|---------------|--------------|
| 0% (Start)    | 5.0 seconds  |
| 100%          | 3.0 seconds  |
| 200%          | 1.5 seconds  |
| 300%          | 1.25 seconds |
| 400%          | 1.0 seconds  |
| 800% (Max)    | 0.0 seconds  |

**Pattern**: Gives players less preparation time as they progress.

### 6. Enemy Type Distribution (weightTypeWrappers)

The profile contains 5 different weight configurations that change based on progression:

#### Configuration 1 (Early Game):
- 83.5% Grunts (Category 0)
- 16.5% Rangers (Category 1)
- 0% Elite chance

#### Configuration 2:
- 80% Grunts
- 20% Grunts (duplicate weight)
- 0% Elite chance

#### Configuration 3 (Mid Game):
- 60% Grunts
- 27% Rangers
- 13% Brutes (Category 2)
- 5% Elite chance

#### Configuration 4:
- 55% Grunts
- 30% Rangers
- 15% Brutes
- 5% Elite chance

#### Configuration 5 (Late Game):
- 40% Grunts
- 30% Rangers
- 20% Brutes
- 10% Elite chance

**Pattern**: Progression from mostly weak enemies to a balanced mix with increasing elite chances.

## How It All Works Together

### Fight Generation Process

1. **Input Parameters**:
   - `levelPercent`: Player's progress (0.0 to 1.0)
   - `fightIndex`: Which fight in the level (1st, 2nd, etc.)
   - `nivTarget`: Normalized Item Value target for enemy strength
   - `seed`: Random seed for reproducibility

2. **Calculation Steps**:

   a. **Determine Enemy Count**:
   ```
   enemyCount = troopNumberCurve.Evaluate(levelPercent * 8)
   // Example: 50% progress = 0.5 * 8 = 4.0 → ~11.5 enemies
   ```

   b. **Calculate Spawn Timing**:
   ```
   initialDelay = baseDelayCurve.Evaluate(levelPercent * 8)
   delayBetween = delayPerTroopCurve.Evaluate(levelPercent * 8)

   spawnTimes = [
     initialDelay,
     initialDelay + delayBetween,
     initialDelay + (2 * delayBetween),
     ...
   ]
   ```

   c. **Select Enemy Types**:
   ```
   weightConfig = weightTypeWrappers[progressIndex]
   for each enemy:
     category = WeightedRandom(weightConfig.Wrappers)
     isElite = Random() < weightConfig.ElitePercent01
     enemy = SelectFromCategory(category, isElite)
   ```

   d. **Apply Level Variations**:
   ```
   baseLevel = CalculateFromNIV(nivTarget)
   for each enemy:
     variation = WeightedRandom(allLevelAddersProportion)
     enemy.level = baseLevel + variation.LevelAdder
   ```

### Example Fight Generation

**Scenario**: Player at 25% progress, Fight #3

1. **Enemy Count**: ~5 enemies (from curve)
2. **Timing**:
   - Initial delay: 4.0 seconds
   - Between spawns: 2.84 seconds
   - Total spawn times: [4.0, 6.84, 9.68, 12.52, 15.36]
3. **Enemy Types** (using Config 2):
   - 80% chance each is a Grunt
   - 20% chance each is a Grunt (different variant)
4. **Level Variations**:
   - 40% at base level
   - 25% at +1 level
   - 25% at -1 level
   - 10% at -2 levels

## Other Difficulty Profiles

### Profile 2: GUID `917c88483410f6d45b9ee6173002b75b`
- Unknown name (need to extract)
- Used by some levels

### Profile 3: GUID `621b225a282f40e40beff03c12f65d74`
- Unknown name (need to extract)
- Used by specific levels

## Key Insights

1. **Non-Linear Scaling**: While called "Linear 50%", the actual curves are carefully tuned non-linear functions
2. **Multi-Dimensional Difficulty**: Combines timing, count, type, and level variations
3. **Smooth Progression**: Curves ensure no sudden difficulty spikes
4. **Replayability**: Random variations keep fights unpredictable
5. **Performance Optimization**: Same curves reused across 130+ levels

## Implementation in Code

The `FightGenerator.GenerateFight()` method orchestrates all these curves:

```csharp
public FightDetail GenerateFight(
    double nivTarget,           // Target enemy strength
    int fightLevel,             // Current fight number
    float levelPercent,         // Progress (0.0-1.0)
    ScriptableDifficultyProfile difficultyProfile,
    int fightPayout,
    int fightIndex,
    int seed,
    ScriptableTroop structure
)
```

The method:
1. Evaluates all animation curves at `levelPercent * 8`
2. Uses the seed for deterministic randomness
3. Returns a `FightDetail` with all enemies, timings, and properties
4. The actual spawn happens at runtime using these pre-calculated values

## Why This Matters

This discovery explains why:
- 133/134 levels have empty fight data - it's all calculated
- The same level plays differently at different player levels
- Difficulty feels smooth and progressive
- File sizes are small despite 134 levels of content
- The game can generate infinite variations