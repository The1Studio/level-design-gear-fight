# Enemy & Troop System - Detailed Documentation

## 1. Overview
The Enemy & Troop System defines all hostile entities in the game, from basic grunts to complex bosses. Each enemy has unique behaviors, stats, and visual representations.

## 2. Core Troop Architecture

### 2.1 ScriptableTroop
**File**: `GearGame/Control/ScriptableTroop.cs`
**Type**: ScriptableUnlockableUpgradable

#### Base Properties
```csharp
class ScriptableTroop : ScriptableUnlockableUpgradable {
    // Identification
    string ID                        // Unique troop identifier

    // Categories
    TroopCategory Category           // Grunt/Ranger/Brute/Structure/Boss

    // Unlock System
    bool UnlockedByDefault           // Available from start
    int EvolveLevel                  // Level for evolution
    int StartingLevel                // Initial power level
    ScriptableUnlockableUpgradable EvolvesInto  // Evolution target
}
```

### 2.2 TroopCategory Enum
```csharp
enum TroopCategory {
    Grunt,          // Basic melee units
    Ranger,         // Ranged attackers
    Brute,          // Heavy/tank units
    Structure,      // Buildings/spawners
    Boss,           // Major enemies
    MiniBoss,       // Mid-level bosses
    Special         // Unique mechanics
}
```

## 3. Enemy Types Catalog

### 3.1 Grunt Category (Melee)
Basic close-combat enemies:

#### Primitive/Tribal
- **TutorialCaveman** - Basic tutorial enemy
- **Caveman** - Standard early-game grunt
- **Tribe** - Group-based tribal warrior
- **Viking** - Stronger melee with shield

#### Undead
- **Skeleton** - Basic undead grunt
- **ZombieGrunt** - Slower but tougher
- **RaiseUndeadSkeleton** - Summoned variant
- **PossessedRat** - Small, fast undead

#### Advanced
- **Ninja** - Fast, evasive melee
- **Samurai** - High damage, honor mechanics
- **Spartan** - Defensive melee with counters

### 3.2 Ranger Category (Ranged)
Distance attackers:

#### Basic Ranged
- **Shaman** - Magic projectiles
- **ZombieRanged** - Thrown attacks

#### Mechanical
- **RobotRanged** - Laser/projectile attacks
- **BeamBot** - Continuous beam damage

#### Special Ranged
- **FlyingDemon** - Aerial ranged attacks
- **CaveBat** - Swooping attacks
- **MohawkBat** - Enhanced bat variant

### 3.3 Brute Category (Heavy)
Tank enemies with high health:

#### Undead Brutes
- **ZombieBrute** - Heavy undead tank
- **DeathKnight** - Armored undead warrior
- **TheCount** - Vampire lord (mini-boss tier)

#### Mechanical Brutes
- **RobotMelee** - Heavy mechanical unit
- **RobotBossTwo** - Second tier boss
- **RobotBossThree** - Third tier boss

#### Nature Brutes
- **ForestGuardian** - Nature-themed tank
- **IceGolem** - Frozen elemental
- **ForestGolem** - Earth elemental
- **Minotaur** - Mythical beast

### 3.4 Structure Category
Stationary enemies/spawners:

#### Spawning Structures
- **Castle** - Spawns knights
- **Barracks** - Spawns soldiers
- **NecromancerTower** - Spawns undead

#### Defensive Structures
- **Tower** - Ranged defense
- **Wall** - Blocking structure
- **Trap** - Damage dealing

### 3.5 Boss Category
Major encounter enemies:

#### Chapter Bosses
- **RobotBossTwo** - Chapter 2 boss
- **RobotBossThree** - Chapter 3 boss
- **TheFactoryBoss** - Factory chapter boss

#### Mini-Bosses
- **TheCount** - Vampire mini-boss
- **DeathKnight** - Undead champion
- **KingMonkey** - Beast mini-boss
- **Anubis** - Egyptian themed

### 3.6 Special Enemies
Unique mechanics:

#### Summoners
- **Necromancer** - Summons skeletons
- **TheCountSkeleton** - Count's minions

#### Transformers
- **InfectedWolf** - Infection spreader
- **InfectedRat** - Small infector

#### Environmental
- **Mushroom** - Spore attacks
- **Cactus** - Area denial
- **FlyTrap** - Trap enemy
- **Worm** - Underground attacker

## 4. Troop Controller System

### 4.1 Base TroopController
**File**: `GearGame/Gameplay/TroopController.cs`

Core functionality for all troops:
```csharp
class TroopController : MonoBehaviour {
    // Components
    TroopHealthController healthController
    TroopMovementController movementController
    TroopCombatController combatController
    TroopAnimationController animationController
    TroopStateController stateController

    // Core Methods
    void Initialize(ScriptableTroop troopData)
    void Update()
    void OnDeath()
    void OnDamage(float damage)
}
```

### 4.2 Specialized Controllers
Each enemy type has specialized controllers:

#### Example: TroopNinjaController
```csharp
class TroopNinjaController : TroopController {
    // Ninja-specific features
    float dodgeChance = 0.3f
    float criticalHitChance = 0.2f

    override void OnDamage(float damage) {
        if (Random.value < dodgeChance) {
            // Dodge animation
            return;
        }
        base.OnDamage(damage);
    }
}
```

## 5. Enemy Component Systems

### 5.1 TroopHealthController
**File**: `GearGame/Gameplay/TroopHealthController.cs`

Health management:
```csharp
class TroopHealthController {
    float maxHealth
    float currentHealth
    float armor
    float magicResistance

    event Action<float> OnHealthChanged
    event Action OnDeath

    void TakeDamage(float damage, DamageType type)
    void Heal(float amount)
    void Die()
}
```

### 5.2 TroopMovementController
**File**: `GearGame/Gameplay/TroopMovementController.cs`

Movement behavior:
```csharp
class TroopMovementController {
    float moveSpeed
    float acceleration
    MovementType movementType  // Walk/Fly/Teleport

    void MoveTo(Vector3 position)
    void FollowPath(Path path)
    void Patrol(Vector3[] waypoints)
}
```

### 5.3 TroopCombatController
**File**: `GearGame/Gameplay/TroopCombatController.cs`

Combat mechanics:
```csharp
class TroopCombatController {
    float attackDamage
    float attackSpeed
    float attackRange
    AttackType attackType  // Melee/Ranged/Magic

    void Attack(GameObject target)
    void UseAbility(int abilityIndex)
    bool IsInRange(GameObject target)
}
```

### 5.4 TroopAnimationController
**File**: `GearGame/Gameplay/TroopAnimationController.cs`

Visual representation:
```csharp
class TroopAnimationController {
    Animator animator

    void PlayAnimation(string animationName)
    void SetMovementSpeed(float speed)
    void TriggerAttack()
    void TriggerDeath()
}
```

### 5.5 TroopStateController
**File**: `GearGame/Gameplay/TroopStateController.cs`

State machine:
```csharp
enum TroopState {
    Idle,
    Moving,
    Attacking,
    Stunned,
    Dead
}

class TroopStateController {
    TroopState currentState

    void ChangeState(TroopState newState)
    void UpdateState()
}
```

## 6. Enemy Data Classes

### 6.1 Individual Enemy Data
Each enemy type has a data class:

#### Example: VikingData
```csharp
class VikingData {
    // Base Stats
    float baseHealth = 100
    float baseDamage = 15
    float baseSpeed = 3.5f

    // Scaling
    float healthPerLevel = 10
    float damagePerLevel = 2

    // Special Properties
    float shieldBlockChance = 0.2f
    float berserkerThreshold = 0.3f  // Health % for rage mode
}
```

### 6.2 Data Inheritance
```
BaseEnemyData
    ├── MeleeEnemyData
    │   ├── VikingData
    │   ├── SpartanData
    │   └── NinjaData
    ├── RangedEnemyData
    │   ├── ShamanData
    │   └── RobotRangedData
    └── BossEnemyData
        ├── RobotBossTwoData
        └── RobotBossThreeData
```

## 7. Enemy Spawning System

### 7.1 EnemyManager
**File**: `GearGame/Gameplay/Managers/EnemyManager.cs`

Manages all enemy instances:
```csharp
class EnemyManager {
    List<TroopController> activeEnemies
    ObjectPool<TroopController> enemyPool

    TroopController SpawnEnemy(ScriptableTroop type, Vector3 position)
    void DespawnEnemy(TroopController enemy)
    void UpdateAllEnemies()
}
```

### 7.2 Spawn Configuration
```csharp
class EnemySpawnConfig {
    ScriptableTroop enemyType
    Vector3 spawnPosition
    float spawnDelay
    int enemyLevel
    SpawnEffect spawnEffect
}
```

## 8. Enemy Abilities System

### 8.1 Common Abilities
Standard abilities across enemy types:

#### Offensive
- **BasicAttack** - Standard damage
- **ChargeAttack** - Dash with damage
- **AreaAttack** - AOE damage

#### Defensive
- **Block** - Damage reduction
- **Dodge** - Evasion chance
- **Shield** - Temporary barrier

#### Special
- **Summon** - Spawn allies
- **Buff** - Enhance allies
- **Debuff** - Weaken players

### 8.2 Unique Abilities

#### Necromancer
```csharp
class NecromancerAbilities {
    void SummonSkeleton() {
        // Spawn skeleton minion
    }

    void DeathAura() {
        // Damage over time area
    }

    void CorpseExplosion() {
        // Explode dead units
    }
}
```

## 9. Boss Systems

### 9.1 Boss Phases
Multi-phase boss encounters:
```csharp
class BossPhaseManager {
    int currentPhase = 1
    float[] phaseHealthThresholds = {0.75f, 0.5f, 0.25f}

    void CheckPhaseTransition(float healthPercent) {
        if (healthPercent < phaseHealthThresholds[currentPhase]) {
            TransitionToNextPhase();
        }
    }
}
```

### 9.2 Boss Mechanics
Special boss features:
- **Invulnerability Windows** - Temporary immunity
- **Rage Mode** - Enhanced stats at low health
- **Summon Waves** - Spawn minions
- **Arena Changes** - Modify battlefield

## 10. Mini-Boss System

### 10.1 Mini-Boss Controller
**File**: `GearGame/Gameplay/EnemyMiniBossController.cs`

Special features:
```csharp
class EnemyMiniBossController : EnemyStructureController {
    Sprite headSprite              // Collectible head trophy
    Transform headSpawnTransform   // Head spawn point
    float startingDelay            // Entrance delay
    AudioSource bossMusic          // Special music

    static bool MiniBossThisWave
    static bool MiniBossDefeatedThisWave
}
```

### 10.2 Mini-Boss Spawning
**File**: `Assets/Scripts/Gameplay/Control/MiniBossSpawningController.cs`

Spawn chance calculation:
```csharp
static bool IsCurrentLevelAMiniBossLevel() {
    int seed = GetMiniBossSeed();
    float chance = CalculateSpawnChance(currentLevel);
    return Random.Range(0f, 1f) < chance;
}
```

## 11. Enemy Scaling System

### 11.1 Level Scaling
Enemy stats scale with level:
```csharp
float CalculateStat(float baseStat, int level, float scaling) {
    return baseStat * Mathf.Pow(scaling, level);
}

// Example scaling
Health = 100 * 1.1^level
Damage = 10 * 1.08^level
Speed = 3 * 1.02^level
```

### 11.2 Difficulty Modifiers
Additional scaling factors:
- Chapter multiplier
- A/B testing modifiers
- Event modifiers
- Player performance adjustment

## 12. Enemy AI System

### 12.1 AI Behavior Types
```csharp
enum AIBehaviorType {
    Aggressive,     // Always attack
    Defensive,      // Prioritize survival
    Strategic,      // Smart targeting
    Berserker,      // Reckless attacks
    Support         // Help allies
}
```

### 12.2 Target Selection
```csharp
GameObject SelectTarget() {
    switch (targetingStrategy) {
        case TargetingStrategy.Nearest:
            return GetNearestTarget();
        case TargetingStrategy.Weakest:
            return GetWeakestTarget();
        case TargetingStrategy.Strongest:
            return GetStrongestTarget();
    }
}
```

## 13. Visual and Audio

### 13.1 Enemy Visuals
- Sprite animations
- Particle effects
- Damage numbers
- Status indicators
- Death animations

### 13.2 Audio Components
- Attack sounds
- Movement sounds
- Damage reactions
- Death sounds
- Special ability audio

## 14. Performance Optimization

### 14.1 Object Pooling
All enemies use object pooling:
```csharp
class EnemyPool {
    Dictionary<ScriptableTroop, Queue<TroopController>> pools

    TroopController Get(ScriptableTroop type)
    void Return(TroopController enemy)
}
```

### 14.2 LOD System
Level of detail for performance:
- Full detail: < 10 enemies
- Reduced effects: 10-20 enemies
- Minimal effects: > 20 enemies

## 15. File References

### Core Files
- `GearGame/Control/ScriptableTroop.cs`
- `GearGame/Gameplay/TroopController.cs`
- `GearGame/Gameplay/Managers/EnemyManager.cs`

### Individual Enemy Controllers
- `GearGame/Gameplay/Troop*.cs` (50+ files)
- Each enemy type has dedicated controller

### Data Classes
- `*Data.cs` files (VikingData, SpartanData, etc.)
- Located in Scripts/Assembly-CSharp/

### Boss/Mini-Boss
- `GearGame/Gameplay/EnemyMiniBossController.cs`
- `Assets/Scripts/Gameplay/Control/MiniBossSpawningController.cs`
- Boss popup controllers in UI/Refactor/Popups/

---

*Generated from Gear Fight 5.1.3 Level System Analysis*