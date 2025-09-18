# Gear Fight Level Design System

A comprehensive level design and analysis system for Gear Fight mobile game, featuring advanced data extraction, visualization, and balancing tools.

## 🎮 Overview

Gear Fight Level Design System provides tools for analyzing, extracting, and managing level data from the Unity-based Gear Fight mobile game. The system includes automated level extraction, JSON data management, and detailed documentation of game mechanics and enemy configurations.

## 🚀 Features

### Level Data Extraction
- **Automated Unity Scene Analysis**: Extract complete level data from Unity scene files
- **JSON Export**: Convert Unity GameObjects to structured JSON format
- **Compact & Full Formats**: Support for both detailed and compact data representations

### Enemy & Boss Configuration
- **30+ Enemy Types**: Comprehensive enemy configurations with unique behaviors
- **Boss Mechanics**: Special boss patterns and multi-phase battles
- **Spawn System**: Wave-based enemy spawning with configurable patterns

### Game Mechanics Documentation
- **Tower System**: 8 unique tower types with upgrade paths
- **Resource Management**: Gold, gems, and energy systems
- **Special Abilities**: Freeze, poison, chain lightning, and more

## 📁 Project Structure

```
level-design-gear-fight/
├── Unity Project/              # Unity game project files
│   ├── GameObject/            # Game object definitions
│   ├── MonoBehaviour/         # Unity MonoBehaviour scripts
│   ├── Resources/             # Game resources and assets
│   └── Scripts/              # Game logic scripts
├── LEVEL_SYSTEM_DETAILED_DOCS/ # Comprehensive documentation
├── extract_all_levels_to_json.py # Level extraction tool
├── gear_fight_complete_levels.json # Full level data
└── gear_fight_complete_levels_compact.json # Compact level data
```

## 🛠️ Installation

### Prerequisites
- Python 3.8+
- Unity 2019.4+ (for accessing Unity project files)
- Git

### Setup
```bash
# Clone the repository
git clone https://github.com/the1studio/level-design-gear-fight.git

# Navigate to project directory
cd level-design-gear-fight

# Install Python dependencies (if any)
pip install -r requirements.txt
```

## 💻 Usage

### Extracting Level Data
```bash
# Run the level extraction script
python extract_all_levels_to_json.py

# This will generate:
# - gear_fight_complete_levels.json (full data)
# - gear_fight_complete_levels_compact.json (compact version)
```

### Working with Unity Project
1. Open Unity Hub
2. Add the `Unity Project` folder as a project
3. Open in Unity 2019.4 or compatible version

## 📊 Data Structure

### Level JSON Format
```json
{
  "level_id": "1-1",
  "enemies": [...],
  "waves": [...],
  "towers": [...],
  "resources": {...}
}
```

### Enemy Configuration
- Health points and damage values
- Movement patterns and speeds
- Special abilities and resistances
- Reward values (gold, gems)

## 🎯 Game Mechanics

### Tower Types
1. **Arrow Tower** - Basic single-target damage
2. **Cannon Tower** - Area damage with splash
3. **Magic Tower** - Elemental damage with effects
4. **Ice Tower** - Slowing and freezing enemies
5. **Lightning Tower** - Chain damage
6. **Poison Tower** - Damage over time
7. **Laser Tower** - Penetrating beam
8. **Support Tower** - Buffs nearby towers

### Enemy Categories
- **Basic**: Goblin, Orc, Troll
- **Flying**: Harpy, Dragon, Bat
- **Armored**: Knight, Tank, Shielded units
- **Magic**: Wizard, Necromancer, Elemental
- **Boss**: Multi-phase with unique mechanics

## 📚 Documentation

Detailed documentation available in `LEVEL_SYSTEM_DETAILED_DOCS/`:
- Enemy specifications and behaviors
- Tower mechanics and upgrade paths
- Level progression and difficulty scaling
- Resource economy balancing

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📝 License

This project is proprietary and confidential. All rights reserved by The 1 Studio.

## 📧 Contact

The 1 Studio - [Contact Information]

Project Link: [https://github.com/the1studio/level-design-gear-fight](https://github.com/the1studio/level-design-gear-fight)

## 🙏 Acknowledgments

- Unity Technologies for the game engine
- The game development team at The 1 Studio
- Community contributors and testers