#!/usr/bin/env python3
"""
Split the consolidated JSON file into individual level files
"""

import json
from pathlib import Path

def split_levels_to_files():
    """Split the consolidated JSON into individual level files"""

    # Paths
    source_file = Path("../UnityProject/gear_fight_complete_levels.json")
    output_dir = Path("../LevelJsonData")

    # Create output directory
    output_dir.mkdir(exist_ok=True)

    # Load consolidated data
    print(f"Loading data from {source_file}...")
    with open(source_file, 'r') as f:
        data = json.load(f)

    print(f"Found {len(data['all_levels'])} levels")

    # Process each level
    for level_data in data['all_levels']:
        # Extract level number
        level_num = f"{level_data.get('world', 0)}_{level_data.get('level', 0)}"

        # Create level file structure
        level_json = {
            "levelNumber": level_data.get('sort_key', 0),
            "worldNumber": level_data.get('world', 0),
            "levelInWorld": level_data.get('level', 0),
            "name": level_data.get('name', 'Unknown'),
            "guid": level_data.get('id', ''),
            "levelSettings": {
                "useCustomFights": level_data.get('use_custom_fights', 0),
                "useCustomGears": level_data.get('use_custom_gears', 0),
                "puzzleConfiguration": level_data.get('puzzle_configuration', 0),
                "customLevelGrid": level_data.get('custom_level_grid'),
                "startingCoins": level_data.get('starting_coins', 0),
                "numLevels": level_data.get('num_levels', 0),
                "numberOfSpinners": level_data.get('number_of_spinners', 1),
                "tutorialSkipString": level_data.get('tutorial_skip_string', ''),
                "gridDimensions": {
                    "width": 7,
                    "height": 7
                },
                "nivSettings": level_data.get('niv_settings', {}),
                "difficultyProfile": level_data.get('difficulty_profile', {})
            },
            "fights": [],
            "gearStoreCollections": level_data.get('gear_store_collections', []),
            "premiumGearStoreCollections": level_data.get('premium_gear_store_collections', []),
            "metadata": {
                "isProcedurallyGenerated": level_data.get('use_custom_fights', 0) == 0,
                "hasCustomFights": level_data.get('use_custom_fights', 0) == 1,
                "fightCount": level_data.get('fight_count', 0),
                "totalEnemies": level_data.get('total_enemies', 0),
                "hasStructures": level_data.get('has_structures', False)
            },
            "enemies": set(),
            "structures": set()
        }

        # Process fights
        for fight_idx, fight in enumerate(level_data.get('fights', [])):
            fight_json = {
                "fightNumber": fight_idx + 1,
                "enemies": [],
                "structure": fight.get('structure'),
                "structureGuid": fight.get('structure_guid'),
                "valueOfFight": fight.get('value_of_fight', 0),
                "forceBasicShop": fight.get('force_basic_shop', 0),
                "fightOffset": fight.get('fight_offset', 0),
                "hasStructureChest": fight.get('has_structure_chest', 0),
                "overrideStructureLevel": fight.get('override_structure_level', 0),
                "structureLevelOverride": fight.get('structure_level_override', 0)
            }

            # Process enemies in fight
            for enemy in fight.get('enemies', []):
                character_name = enemy.get('character')
                if character_name:
                    character_name = character_name.replace('.asset', '')
                else:
                    character_name = ''

                enemy_json = {
                    "character": character_name,
                    "characterGuid": enemy.get('character_guid'),
                    "level": enemy.get('level', 0),
                    "delay": enemy.get('delay', 0),
                    "isBeast": enemy.get('is_beast', 0)
                }
                fight_json['enemies'].append(enemy_json)

                # Add to unique enemies set
                if character_name:
                    level_json['enemies'].add(character_name)

            # Add structure to set if exists
            if fight.get('structure'):
                level_json['structures'].add(fight.get('structure').replace('.asset', ''))

            level_json['fights'].append(fight_json)

        # Convert sets to sorted lists
        level_json['enemies'] = sorted(list(level_json['enemies']))
        level_json['structures'] = sorted(list(level_json['structures']))

        # Save level file
        output_file = output_dir / f"level_{level_num}.json"
        with open(output_file, 'w') as f:
            json.dump(level_json, f, indent=2)

        print(f"Saved {output_file.name} - {level_data.get('name', 'Unknown')}")

    # Also save supplemental data
    save_supplemental_data(data, output_dir.parent)

    print(f"✅ Split {len(data['all_levels'])} levels into individual files")

def save_supplemental_data(data, base_dir):
    """Save chapter and enemy data as separate files"""

    # Save chapters data
    chapters_file = base_dir / "chapters.json"
    chapters_data = {
        "chapters": data.get('chapters', {}),
        "worlds": data.get('worlds', {}),
        "total_chapters": data['statistics']['total_chapters'],
        "total_worlds": data['statistics']['total_worlds']
    }
    with open(chapters_file, 'w') as f:
        json.dump(chapters_data, f, indent=2)
    print(f"Saved chapters data to {chapters_file}")

    # Save GUID mappings
    guid_file = base_dir / "guid_mappings.json"
    with open(guid_file, 'w') as f:
        json.dump(data.get('guid_mappings', {}), f, indent=2)
    print(f"Saved GUID mappings to {guid_file}")

    # Extract unique enemies and structures from all levels
    all_enemies = set()
    all_structures = set()

    for level in data['all_levels']:
        for fight in level.get('fights', []):
            for enemy in fight.get('enemies', []):
                if enemy.get('character'):
                    all_enemies.add(enemy.get('character').replace('.asset', ''))
            if fight.get('structure'):
                all_structures.add(fight.get('structure').replace('.asset', ''))

    # Save enemies catalog
    enemies_file = base_dir / "enemies_catalog.json"
    enemies_data = {
        "enemies": sorted(list(all_enemies)),
        "total": len(all_enemies),
        "guid_mappings": {k: v for k, v in data.get('guid_mappings', {}).get('sample', {}).items() if 'Troop' in v}
    }
    with open(enemies_file, 'w') as f:
        json.dump(enemies_data, f, indent=2)
    print(f"Saved enemies catalog to {enemies_file}")

    # Save structures catalog
    structures_file = base_dir / "structures_catalog.json"
    structures_data = {
        "structures": sorted(list(all_structures)),
        "total": len(all_structures)
    }
    with open(structures_file, 'w') as f:
        json.dump(structures_data, f, indent=2)
    print(f"Saved structures catalog to {structures_file}")

if __name__ == "__main__":
    split_levels_to_files()