# Chapter System - Detailed Documentation

## 1. Overview
The Chapter System represents the highest level of game organization, dividing the game into thematic worlds with unique environments, enemies, and progression paths.

## 2. Core Architecture

### 2.1 ChaptersProgressionSettings
**File**: `ScriptableTemplates/ChaptersProgressionSettings.cs`
**Type**: ScriptableObject
**Menu Path**: "GearFight/Game Data/Chapters Progression"

#### Properties
```csharp
string ProgressionName           // Name identifier for the progression set
ChapterSettings[] chapters       // Ordered array of all chapters
int TotalChapters               // Total number of chapters (computed)
```

#### Key Methods
- `TryGetChapterSettings(int currentChapterIndex, out ChapterSettings chapterSettings)`
  - Retrieves chapter settings for a given index
  - Returns false if index is out of bounds

- `GetIndexForChapter(int chapter, int level)`
  - Converts chapter and level indices to absolute level index
  - Used for save system and progression tracking

- `GetWorldIndexForLevel(int level)`
  - Returns which chapter/world a given absolute level belongs to
  - Critical for theme switching and resource loading

- `GetLevelIndexForLevel(int level)`
  - Returns the level index within its chapter
  - Used for UI display and local progression

### 2.2 ChapterSettings
**File**: `ScriptableTemplates/ChapterSettings.cs`
**Type**: ScriptableObject
**Menu Path**: "GearFight/Game Data/Chapter"

#### Configuration Sections

##### General Settings
```csharp
string ID                              // Unique chapter identifier (GUID format)
string DisplayNameLocalizationKey      // Localization key for UI display
bool ShowWorldUnlock                   // Display unlock animation/popup
```

##### Visual & Audio Theme
```csharp
EnvironmentThemeView EnvironmentTheme  // Prefab containing environment visuals
AudioClip MainMusic                    // Background music for the chapter
Sprite SlopeSprite                     // Terrain/slope visual sprite
```

##### Level Content
```csharp
ScriptableLevel[] Levels               // All levels in this chapter
ScriptableTroop[] AllMiniBosses       // Available mini-bosses for this chapter
ScriptableUnlockableUpgradable[] ChapterSpecificUnlocks  // Special unlocks
```

##### UI & Popups
```csharp
string[] LocalizationStrings          // One-time unlock sequence text
BossLevelPopup ShowPopupEveryLevelStart  // Boss intro popup configuration
```

## 3. Chapter Types & Themes

### 3.1 Environment Themes
Each chapter has a unique `EnvironmentThemeView` that includes:
- Background parallax layers
- Color palette
- Particle effects
- Lighting configuration
- Terrain textures

### 3.2 Known Chapter Types (Based on Code Analysis)
1. **Forest Theme** - Natural environment with plant-based enemies
2. **Undead Theme** - Dark atmosphere with skeleton/zombie enemies
3. **Robot/Factory Theme** - Industrial setting with mechanical enemies
4. **Tribal Theme** - Primitive setting with tribal warriors
5. **Simulation Theme** - Special testing/tutorial environment

## 4. Chapter Progression Flow

### 4.1 Linear Progression
```
Start Game
    ↓
Chapter 1, Level 1
    ↓
Complete all Chapter 1 levels
    ↓
Chapter Completion Rewards
    ↓
World Unlock Animation (if ShowWorldUnlock = true)
    ↓
Chapter 2, Level 1
    ↓
... continues ...
```

### 4.2 Chapter Unlock Conditions
- Complete all levels in previous chapter
- Specific level count requirements (configurable via AB testing)
- Special event unlocks (time-limited chapters)

## 5. Chapter-Specific Features

### 5.1 Mini-Boss System
Each chapter defines available mini-bosses:
- Random spawn chance per level
- Chapter-themed mini-boss types
- Special rewards and collectibles

### 5.2 Chapter Unlocks
```csharp
ScriptableUnlockableUpgradable[] ChapterSpecificUnlocks
```
- New gear types
- Troop upgrades
- Special abilities
- Cosmetic items

### 5.3 Difficulty Scaling
Chapters progressively increase difficulty through:
- Enemy level scaling
- Increased enemy density
- New enemy types introduction
- Complex puzzle configurations

## 6. Chapter Rewards System

### 6.1 ChapterRewardsManager
**File**: `GearGame/Managers/SingleLoad/ChapterRewardsManager.cs`

Manages chapter completion rewards:
- Milestone rewards (25%, 50%, 75%, 100% completion)
- Chapter completion chest
- Currency bonuses
- Unlock tokens

### 6.2 ChapterSave Data
**File**: `SaveSystem/SaveData/ChapterSave.cs`
```csharp
int ChapterRewardsPending        // Unclaimed reward count
int ChapterRewardsClaimed        // Already claimed rewards
int ChapterRewardsChestsClaimed  // Special chest claims
```

## 7. Chapter Setup Controller
**File**: `ChapterSetupController.cs`

Responsible for:
- Loading chapter resources
- Initializing environment theme
- Setting up audio/music
- Configuring enemy spawn pools
- Loading level progression

## 8. A/B Testing Integration

### 8.1 ABTestingChapterLength
**File**: `ABTestingChapterLength.cs`

Controls chapter length variations:
```csharp
int[] levelOffsets  // Adjusts number of levels per chapter
```

### 8.2 Chapter Variation Testing
- Different level counts per chapter
- Reward frequency adjustments
- Difficulty curve modifications
- Unlock pacing changes

## 9. Resource Management

### 9.1 Chapter Asset Loading
Chapters use lazy loading for optimization:
1. Core assets loaded on chapter start
2. Level-specific assets loaded per level
3. Enemy sprites/animations loaded on-demand
4. Audio clips streamed as needed

### 9.2 Memory Management
- Previous chapter assets unloaded on transition
- Shared assets cached in memory
- Environment themes use object pooling

## 10. Chapter Transition System

### 10.1 World Unlock Sequence
When `ShowWorldUnlock = true`:
1. Display completion statistics
2. Play unlock animation
3. Show new chapter preview
4. Present localization strings
5. Transition to new environment

### 10.2 Save Points
Chapter progress saved at:
- Each level completion
- Chapter milestone achievements
- Reward claims
- Game pause/background

## 11. Special Chapter Types

### 11.1 Tutorial Chapter
- Simplified mechanics
- Guided progression
- Guaranteed gear drops
- No failure states

### 11.2 Event Chapters
- Time-limited availability
- Special reward structures
- Unique enemy types
- Leaderboard integration

### 11.3 Simulation Chapter
**File**: `Resources/CombatSimulationChapter.asset`
- Testing environment
- All features unlocked
- Configurable difficulty
- Debug tools enabled

## 12. Implementation Notes

### 12.1 Best Practices
- Chapters should have 10-30 levels for optimal pacing
- Mini-boss frequency: 1 per 5-10 levels
- New mechanic introduction: Every 3-5 levels
- Difficulty spike: 20-30% per chapter

### 12.2 Configuration Guidelines
- Always set unique IDs (GUID format)
- Provide all localization keys
- Test environment theme transitions
- Verify reward balance

### 12.3 Common Issues
- Missing localization keys cause display errors
- Null environment themes crash on load
- Circular unlock dependencies freeze progression
- Mismatched level counts break save system

## 13. File References

### Core Files
- `ScriptableTemplates/ChaptersProgressionSettings.cs`
- `ScriptableTemplates/ChapterSettings.cs`
- `ChapterSetupController.cs`
- `GearGame/Managers/SingleLoad/ChapterRewardsManager.cs`

### Data Files
- `SaveSystem/SaveData/ChapterSave.cs`
- `ABTestingChapterLength.cs`
- `ABTestingChapterRewardsConfig.cs`

### Asset Examples
- `Resources/CombatSimulationChapter.asset`
- `Resources/CombatSimulationProgressionSettings.asset`

---

*Generated from Gear Fight 5.1.3 Level System Analysis*