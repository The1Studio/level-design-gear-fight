# CLAUDE.md - GearFight Level Design Tools

## CRITICAL: MECHANIC DISCOVERY IS PRIMARY GOAL
**🔍 The #1 purpose is finding ALL mechanics in Unity data.**
Never miss any game mechanic, component, or behavior.

## Game Overview
Gear Fight is a mobile action game with wave-based combat featuring procedurally generated fights and a gear/equipment economy system. The game has 134 levels across 10 worlds with 11 chapters.

## Quick Commands
```bash
# Complete data extraction (new modular system)
python3 extract_detailed_game_data.py

# Split levels from consolidated JSON (legacy)
cd converter && python3 split_levels_to_files.py

# Run API server (port 3205)
python3 api_server.py

# Access level editor
http://localhost:3205/level_editor.html

# Test API endpoints
curl http://localhost:3205/health
curl http://localhost:3205/api/levels/list
curl http://localhost:3205/api/chapters
curl http://localhost:3205/api/enemies/detailed    # 69 enemies with full data
curl http://localhost:3205/api/structures/detailed # 30 structures with full data
curl http://localhost:3205/api/gears/detailed      # 109 gears with full data
curl http://localhost:3205/api/behaviors/detailed  # 13 behaviors with full data
curl http://localhost:3205/api/currencies/detailed # 41 currencies with full data
curl http://localhost:3205/api/quests/detailed     # 11 quests with full data
```

## Project Structure
```
level-design-gear-fight/
├── UnityProject/              # Unity source data
│   ├── MonoBehaviour/         # Unity assets (613 assets)
│   ├── GameObject/            # Game objects
│   ├── Resources/             # Resources
│   └── LEVEL_SYSTEM_DETAILED_DOCS/  # Comprehensive documentation
├── LevelJsonData/             # Individual level files (134 files)
├── extract_detailed_game_data.py    # Clean modular extraction system
├── converter/                 # Legacy data processing scripts
│   └── split_levels_to_files.py
├── api_server.py             # Flask API server
├── level_editor.html         # Level editor interface
├── config.json               # Configuration
├── chapters.json             # Chapter data
├── enemies_catalog_detailed.json   # Detailed enemy catalog (69 enemies)
├── structures_catalog_detailed.json # Detailed structure catalog (30 structures)
├── gears_catalog_detailed.json     # Detailed gear catalog (109 gears)
├── behaviors_catalog_detailed.json # Detailed behavior catalog (13 behaviors)
├── currencies_catalog_detailed.json # Detailed currency catalog (41 currencies)
├── quests_catalog_detailed.json    # Detailed quest catalog (11 quests)
├── gear_fight_complete_data.json   # Complete extraction results
└── guid_mappings.json       # Unity GUID mappings
```

## Key Features

### Level System
- **134 Total Levels**: Across 10 worlds and 11 chapters
- **Procedural Generation**: 133 levels use procedural fight generation
- **Custom Fights**: Only 1 level (World 1-1) has custom fight configuration
- **Difficulty Profiles**: "Linear 50%" scaling system
- **NIV System**: Normalized Item Value for economy balancing

### Combat System
- **Fight Waves**: Multiple fights per level with enemy spawning
- **Enemy Types**: 69 different enemy types (Caveman, Viking, Spartan, etc.)
- **Structures**: 30 unique structure types for environmental elements
- **Spawn Timing**: Configurable delays and patterns
- **Beast Mode**: Special enemy variants
- **Procedural Generation**: 133/134 levels (99.3%) use procedural fight generation
- **Custom Fights**: Only Level 1-1 (World 1) has custom fight configuration

### Economy System
- **Gear Store**: Collections of equipment per fight
- **Premium Store**: Special gear collections
- **Starting Coins**: Initial currency per level
- **Spinners**: Reward mechanisms (1-5 per level)
- **Value System**: Fight values determine rewards

## Game Mechanics Discovered

### Core Mechanics
1. **Wave-based Combat**: Sequential fights with enemy waves
2. **Procedural Generation**: Dynamic fight creation based on difficulty curves (99.3% of levels)
3. **Grid System**: 7x7 puzzle grid for gameplay
4. **Equipment System**: Gear collections and stores
5. **Tutorial System**: Skip strings for tutorial levels
6. **Dual Fight System**: Custom fights vs procedural generation
7. **Animation Behaviors**: 13 behavior types (Size, Bounce, Dangle, Rotation, etc.)
8. **Currency System**: 41 currency types with exchange rates and capacity limits
9. **Quest System**: 11 quest types with daily/weekly mechanics

### Enemy Types
- TroopTutorialCaveman
- TroopCaveman
- TroopWolfOne
- TroopTribe
- TroopViking
- TroopSpartan
- TroopZombieGrunt
- TroopRobotMelee
- TroopRobotRange
- TroopOrc
- TroopAngel
- TroopMrD

### Structure Types (30 total)
- Forest structures
- Environmental obstacles
- Defensive structures

## Fight System Architecture

### Procedural vs Custom Fights
- **Procedural Levels**: 133 out of 134 levels (99.3%)
  - Use `useCustomFights: 0` in levelSettings
  - Runtime generation based on difficulty curves
  - Empty or minimal fight data by design
  - Parameters: difficultyProfile, startingCoins, numberOfSpinners, levelTime, levelDifficulty
  - NIV system controls economy balancing

- **Custom Levels**: Only 1 level (World 1-1)
  - Uses `useCustomFights: 1` in levelSettings
  - Detailed fight configuration with waves, enemies, and structures
  - Tutorial level with specific mechanics and "FIRSTTUTORIAL" skip string

### Level Editor UX Improvements
- **Procedural Warning Banner**: Orange gradient warning for procedural levels
- **Disabled Controls**: Add Fight button disabled for procedural levels
- **Parameter Display**: Shows difficulty profiles, NIV settings, and timing parameters
- **Visual Indicators**: Clear distinction between procedural and custom level types

## Modular Extraction System

### New Architecture (v2.0 - Clean Architecture)
The extraction system has been completely rewritten with a clean, maintainable architecture:

#### Core Components
1. **UnityParser**: Core YAML parsing and GUID resolution
   - Builds GUID mapping from 613 Unity assets
   - Handles Unity-specific YAML format and k__BackingField syntax
   - Resolves asset references between files

2. **AssetExtractor**: Base class for all specialized extractors
   - Common property extraction (ID, level, category, etc.)
   - Evolution chain processing
   - Gear reference handling
   - Sprite reference extraction

3. **Specialized Extractors**:
   - **TroopExtractor**: 69 enemies with evolution chains and combat data
   - **StructureExtractor**: 30 structures with environmental themes
   - **GearExtractor**: 109 gears with cost and rarity data

4. **GearFightExtractor**: Main orchestrator
   - Coordinates all specialized extractors
   - Generates comprehensive statistics
   - Creates API-compatible catalogs
   - Provides detailed reporting

#### Key Features
- **Complete Extraction**: 273 total assets (69 troops + 30 structures + 109 gears + 13 behaviors + 41 currencies + 11 quests)
- **Evolution Analysis**: 15/69 troops have evolution chains
- **Gear Integration**: 39/69 troops have associated gear
- **Environmental Themes**: Structures organized by City, Desert, Forest, Snow, Volcano
- **Animation Systems**: 13 behavior types with amplitude, frequency, and timing parameters
- **Economy Systems**: 41 currency types with exchange rates and capacity limits
- **Quest Mechanics**: 11 quest types with daily/weekly progression systems
- **Backward Compatibility**: Generates same API catalog format as previous system
- **Rich Metadata**: Extraction timestamps, version tracking, comprehensive statistics

#### Usage
```bash
# Run complete extraction
python3 extract_detailed_game_data.py

# Generated files:
# - gear_fight_complete_data.json (formatted)
# - gear_fight_complete_data.compact.json (minified)
# - enemies_catalog_detailed.json (API compatible)
# - structures_catalog_detailed.json (API compatible)
# - gears_catalog_detailed.json (API compatible)
# - behaviors_catalog_detailed.json (API compatible)
# - currencies_catalog_detailed.json (API compatible)
# - quests_catalog_detailed.json (API compatible)
```

## API Endpoints

### Level Management
- `GET /api/levels/list` - List all levels with metadata
- `GET /api/levels/{world}/{level}` - Get specific level data
- `PUT /api/levels/{world}/{level}` - Update level data
- `GET /api/export/all` - Export all levels as ZIP

### Game Data
- `GET /api/chapters` - Get chapter and world data
- `GET /api/enemies` - Get enemy catalog (basic list)
- `GET /api/enemies/detailed` - Get detailed enemy catalog with all properties (69 enemies)
- `GET /api/structures` - Get structure catalog (basic list)
- `GET /api/structures/detailed` - Get detailed structure catalog with all properties (30 structures)
- `GET /api/gears` - Get gear catalog (basic list)
- `GET /api/gears/detailed` - Get detailed gear catalog with all properties (109 gears)
- `GET /api/behaviors` - Get behavior catalog (basic list)
- `GET /api/behaviors/detailed` - Get detailed behavior catalog with all properties (13 behaviors)
- `GET /api/currencies` - Get currency catalog (basic list)
- `GET /api/currencies/detailed` - Get detailed currency catalog with all properties (41 currencies)
- `GET /api/quests` - Get quest catalog (basic list)
- `GET /api/quests/detailed` - Get detailed quest catalog with all properties (11 quests)
- `GET /api/analysis` - Get game analysis

### System
- `GET /health` - Health check
- `GET /api/config` - Configuration

## Level Data Structure
```json
{
  "levelNumber": 1001,
  "worldNumber": 1,
  "levelInWorld": 1,
  "name": "World 1 - Level 1",
  "guid": "346e207eb93fd9a4d99d87490b837da4",
  "levelSettings": {
    "useCustomFights": 1,
    "useCustomGears": 1,
    "startingCoins": 15,
    "numberOfSpinners": 1,
    "tutorialSkipString": "FIRSTTUTORIAL",
    "difficultyProfile": {...},
    "nivSettings": {...}
  },
  "fights": [...],
  "gearStoreCollections": [...],
  "metadata": {
    "isProcedurallyGenerated": false,
    "hasCustomFights": true,
    "fightCount": 5,
    "totalEnemies": 8,
    "hasStructures": false
  }
}
```

## Development Workflow

### Adding New Features
1. Check existing Unity data structure
2. Update converter if needed
3. Modify API endpoints
4. Update level editor interface
5. Test with actual game data

### Data Pipeline
```
Unity Assets (613 total) → extract_detailed_game_data.py → Detailed Catalogs
      ↓                              ↓                           ↓
MonoBehaviour/*.asset         GearFightExtractor           enemies_catalog_detailed.json
GameObject/*.asset         ↙        ↓        ↘           structures_catalog_detailed.json
Resources/*.asset    TroopExt  StructExt  GearExt        gears_catalog_detailed.json
                        ↓         ↓         ↓                       ↓
                    69 troops  30 struct  109 gears               API Server
                                    ↓                                ↓
                          gear_fight_complete_data.json        Level Editor
                                    ↓
                          LevelJsonData/*.json (legacy)
```

## Known Issues & Solutions

### Issue: Procedural Generation
- **Problem**: 133/134 levels have empty custom data (by design)
- **Solution**: This is intentional - they use procedural generation at runtime

### Issue: Complex Data Structure
- **Problem**: Nested fights, waves, enemies, and structures
- **Solution**: Hierarchical editor interface with tabs

### Issue: GUID References
- **Problem**: Unity uses GUIDs for asset references
- **Solution**: guid_mappings.json provides translations

## Testing

### API Testing
```bash
# Test level list
curl http://localhost:3205/api/levels/list | jq

# Test specific level
curl http://localhost:3205/api/levels/1/1 | jq

# Test chapters
curl http://localhost:3205/api/chapters | jq
```

### Editor Testing
1. Open http://localhost:3205/level_editor.html
2. Select a level from the list
3. Verify all tabs load correctly
4. Test save functionality
5. Check statistics display

## Deployment

### Docker
```bash
# Build image
docker build -t gear-fight-tools .

# Run container
docker run -p 3205:3205 gear-fight-tools
```

### Port Assignments
- Development: 3205
- Staging: 3105
- Production: 3005

## Important Notes

1. **Procedural Generation**: Most levels don't have detailed fight data - this is by design
2. **Tutorial Level**: World 1-1 is the only fully custom level
3. **Unity Data**: The Unity project contains much more data than currently extracted
4. **Difficulty Curves**: Animation curves control spawn timing and enemy counts
5. **NIV System**: Complex economy balancing system needs further investigation

## Future Enhancements

- [ ] Full validation system for fight configurations
- [ ] Procedural generation preview in editor
- [ ] Difficulty curve editor
- [ ] Gear collection manager
- [ ] Chapter progression editor
- [ ] Enemy and structure property editors
- [ ] Grid puzzle designer
- [ ] Analytics dashboard

## Session Continuity

When continuing work:
1. Check if API server is running: `curl http://localhost:3205/health`
2. Review LevelJsonData for current state
3. Check Unity data for new discoveries
4. Refer to LEVEL_SYSTEM_DETAILED_DOCS in UnityProject for deep dive