# CLAUDE.md - GearFight Level Design Tools

## CRITICAL: MECHANIC DISCOVERY IS PRIMARY GOAL
**🔍 The #1 purpose is finding ALL mechanics in Unity data.**
Never miss any game mechanic, component, or behavior.

## Game Overview
Gear Fight is a mobile action game with wave-based combat featuring procedurally generated fights and a gear/equipment economy system. The game has 134 levels across 10 worlds with 11 chapters.

## Quick Commands
```bash
# Split levels from consolidated JSON
cd converter && python3 split_levels_to_files.py

# Run API server (port 3205)
python3 api_server.py

# Access level editor
http://localhost:3205/level_editor.html

# Test API endpoints
curl http://localhost:3205/health
curl http://localhost:3205/api/levels/list
curl http://localhost:3205/api/chapters
curl http://localhost:3205/api/enemies
```

## Project Structure
```
level-design-gear-fight/
├── UnityProject/              # Unity source data
│   ├── MonoBehaviour/         # Unity assets
│   ├── GameObject/            # Game objects
│   ├── Resources/             # Resources
│   └── gear_fight_complete_levels.json  # Extracted data
├── LevelJsonData/             # Individual level files (134 files)
├── converter/                 # Data processing scripts
│   └── split_levels_to_files.py
├── api_server.py             # Flask API server
├── level_editor.html         # Level editor interface
├── config.json               # Configuration
├── chapters.json             # Chapter data
├── enemies_catalog.json     # Enemy catalog
├── structures_catalog.json  # Structure catalog
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
- **Enemy Types**: 9+ different enemy types (Caveman, Viking, Spartan, etc.)
- **Structures**: 30 unique structure types for environmental elements
- **Spawn Timing**: Configurable delays and patterns
- **Beast Mode**: Special enemy variants

### Economy System
- **Gear Store**: Collections of equipment per fight
- **Premium Store**: Special gear collections
- **Starting Coins**: Initial currency per level
- **Spinners**: Reward mechanisms (1-5 per level)
- **Value System**: Fight values determine rewards

## Game Mechanics Discovered

### Core Mechanics
1. **Wave-based Combat**: Sequential fights with enemy waves
2. **Procedural Generation**: Dynamic fight creation based on difficulty curves
3. **Grid System**: 7x7 puzzle grid for gameplay
4. **Equipment System**: Gear collections and stores
5. **Tutorial System**: Skip strings for tutorial levels

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

## API Endpoints

### Level Management
- `GET /api/levels/list` - List all levels with metadata
- `GET /api/levels/{world}/{level}` - Get specific level data
- `PUT /api/levels/{world}/{level}` - Update level data
- `GET /api/export/all` - Export all levels as ZIP

### Game Data
- `GET /api/chapters` - Get chapter and world data
- `GET /api/enemies` - Get enemy catalog
- `GET /api/structures` - Get structure catalog
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
Unity Assets → extract_all_levels_to_json.py → gear_fight_complete_levels.json
                                                         ↓
                                              split_levels_to_files.py
                                                         ↓
                                                LevelJsonData/*.json
                                                         ↓
                                                    API Server
                                                         ↓
                                                   Level Editor
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