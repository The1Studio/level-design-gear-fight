#!/usr/bin/env python3
"""
Complete Level Data Extractor for Gear Fight
Converts all Unity YAML level files to JSON format
"""

import yaml
import json
import re
from pathlib import Path
from collections import defaultdict

class GearFightLevelExtractor:
    def __init__(self, base_path="MonoBehaviour"):
        self.base_path = Path(base_path)
        self.guid_map = {}
        self.levels = {}
        self.chapters = {}
        self.troops = {}
        self.structures = {}
        self.gears = {}

    def build_guid_map(self):
        """Build complete GUID to asset name mapping"""
        print("Building GUID map...")

        for meta_file in self.base_path.glob("*.asset.meta"):
            try:
                with open(meta_file, 'r') as f:
                    content = f.read()
                    guid_match = re.search(r'guid:\s*([a-f0-9]+)', content)
                    if guid_match:
                        asset_name = meta_file.stem
                        self.guid_map[guid_match.group(1)] = asset_name
            except Exception as e:
                print(f"Error reading {meta_file}: {e}")

        print(f"Mapped {len(self.guid_map)} GUIDs")
        return self.guid_map

    def parse_unity_yaml(self, filepath):
        """Parse Unity YAML file into Python dict"""
        try:
            with open(filepath, 'r', encoding='utf-8') as f:
                content = f.read()

                # Find MonoBehaviour section
                mono_start = content.find('MonoBehaviour:')
                if mono_start == -1:
                    return None

                # Extract YAML portion
                yaml_lines = content[mono_start:].split('\n')

                # Clean Unity-specific syntax
                cleaned_lines = []
                for line in yaml_lines:
                    # Remove k__BackingField
                    line = re.sub(r'<(.+?)>k__BackingField', r'\1', line)
                    cleaned_lines.append(line)

                yaml_content = '\n'.join(cleaned_lines)

                # Parse YAML
                data = yaml.safe_load(yaml_content)
                return data.get('MonoBehaviour', data) if isinstance(data, dict) else data

        except Exception as e:
            print(f"Error parsing {filepath}: {e}")
            return None

    def extract_guid(self, ref):
        """Extract GUID from Unity reference"""
        if not ref:
            return None

        if isinstance(ref, dict):
            # Handle {fileID: ..., guid: ..., type: ...} format
            guid = ref.get('guid')
            if guid:
                return guid

        # Handle string format
        match = re.search(r'guid:\s*([a-f0-9]+)', str(ref))
        return match.group(1) if match else None

    def resolve_guid(self, guid):
        """Resolve GUID to asset name"""
        if not guid:
            return None
        return self.guid_map.get(guid, f"Unknown_{guid[:8]}")

    def extract_enemy_data(self, enemy):
        """Extract enemy information from fight data"""
        if not enemy:
            return None

        character_ref = enemy.get('Character')
        character_guid = self.extract_guid(character_ref)

        return {
            'character': self.resolve_guid(character_guid),
            'character_guid': character_guid,
            'level': enemy.get('Level', 0),
            'delay': enemy.get('Delay', 0),
            'is_beast': enemy.get('IsBeast', False)
        }

    def extract_fight_data(self, fight):
        """Extract fight information"""
        if not fight:
            return None

        enemies = []
        for enemy in fight.get('Enemies', []):
            enemy_data = self.extract_enemy_data(enemy)
            if enemy_data:
                enemies.append(enemy_data)

        structure_ref = fight.get('Structure')
        structure_guid = self.extract_guid(structure_ref)

        return {
            'enemies': enemies,
            'structure': self.resolve_guid(structure_guid),
            'structure_guid': structure_guid,
            'value_of_fight': fight.get('ValueOfFight', 0),
            'force_basic_shop': fight.get('ForceBasicShop', False),
            'fight_offset': fight.get('FightOffset', 0),
            'has_structure_chest': fight.get('HasStructureChest', False),
            'override_structure_level': fight.get('overrideStructureLevel', False),
            'structure_level_override': fight.get('structureLevelOverride', 0)
        }

    def extract_level_data(self, filepath):
        """Extract complete level data"""
        data = self.parse_unity_yaml(filepath)
        if not data:
            return None

        # Extract fights
        fights = []
        for fight in data.get('allFights', []):
            fight_data = self.extract_fight_data(fight)
            if fight_data:
                fights.append(fight_data)

        # Extract structures
        structures = []
        for struct_ref in data.get('allStructures', []):
            struct_guid = self.extract_guid(struct_ref)
            structures.append({
                'name': self.resolve_guid(struct_guid),
                'guid': struct_guid
            })

        # Extract gear collections
        gear_collections = []
        for collection in data.get('allGearStoreCollections', []):
            items = []
            for item_ref in collection.get('AllItems', []):
                item_guid = self.extract_guid(item_ref)
                items.append({
                    'name': self.resolve_guid(item_guid),
                    'guid': item_guid
                })
            if items:
                gear_collections.append(items)

        # Extract premium gear collections
        premium_collections = []
        for collection in data.get('allPremiumGearStoreCollections', []):
            items = []
            for item_ref in collection.get('AllItems', []):
                item_guid = self.extract_guid(item_ref)
                items.append({
                    'name': self.resolve_guid(item_guid),
                    'guid': item_guid
                })
            if items:
                premium_collections.append(items)

        # Extract difficulty profile
        difficulty_guid = self.extract_guid(data.get('difficultyProfile'))

        # Extract custom grid
        grid_guid = self.extract_guid(data.get('CustomLevelGrid'))

        level_info = {
            'name': data.get('m_Name', filepath.stem),
            'id': data.get('ID', ''),
            'use_custom_fights': data.get('DoUseCustomFights', False),
            'use_custom_gears': data.get('DoUseCustomGears', False),
            'puzzle_configuration': data.get('PuzzleConfiguration', 0),
            'custom_level_grid': {
                'name': self.resolve_guid(grid_guid),
                'guid': grid_guid
            } if grid_guid else None,
            'starting_coins': data.get('StartingCoins', 0),
            'num_levels': data.get('numLevels', 0),
            'number_of_spinners': data.get('NumberOfSpinners', 1),
            'tutorial_skip_string': data.get('TutorialSkipString', ''),
            'niv_settings': {
                'use_level_value': data.get('useLevelValueForNIV', False),
                'use_custom_level_for_payouts': data.get('useCustomLevelForPayouts', False),
                'custom_level_for_payouts': data.get('customLevelForPayouts', 0),
                'override_target_level_for_max': data.get('overrideTargetLevelForMax', False),
                'target_level_max': data.get('targetLevelMaxForNIV', 0),
                'level_niv_max': data.get('levelNIVMax', 0),
                'level_niv_min': data.get('levelNIVMin', 0),
                'target_level_for_niv': data.get('targetLevelForNIV', 0)
            },
            'difficulty_profile': {
                'name': self.resolve_guid(difficulty_guid),
                'guid': difficulty_guid
            } if difficulty_guid else None,
            'fights': fights,
            'structures': structures,
            'gear_store_collections': gear_collections,
            'premium_gear_store_collections': premium_collections,
            'fight_count': len(fights),
            'total_enemies': sum(len(f['enemies']) for f in fights),
            'has_structures': len(structures) > 0
        }

        return level_info

    def extract_all_levels(self):
        """Extract all level data from World*.asset files"""
        print("\nExtracting level data...")

        level_files = sorted(self.base_path.glob("World*.asset"))
        print(f"Found {len(level_files)} level files")

        for filepath in level_files:
            print(f"Processing {filepath.name}...")
            level_data = self.extract_level_data(filepath)
            if level_data:
                # Parse world and level numbers
                match = re.match(r'World (\d+) - Level (\d+)', filepath.stem)
                if match:
                    world_num = int(match.group(1))
                    level_num = int(match.group(2))
                    level_data['world'] = world_num
                    level_data['level'] = level_num
                    level_data['sort_key'] = world_num * 1000 + level_num

                self.levels[filepath.stem] = level_data

        print(f"Extracted {len(self.levels)} levels")
        return self.levels

    def extract_chapter_data(self, filepath):
        """Extract chapter data"""
        data = self.parse_unity_yaml(filepath)
        if not data:
            return None

        # Extract level references
        level_refs = []
        for level_ref in data.get('Levels', []):
            level_guid = self.extract_guid(level_ref)
            level_refs.append({
                'name': self.resolve_guid(level_guid),
                'guid': level_guid
            })

        # Extract mini-bosses
        mini_bosses = []
        for boss_ref in data.get('AllMiniBosses', []):
            boss_guid = self.extract_guid(boss_ref)
            mini_bosses.append({
                'name': self.resolve_guid(boss_guid),
                'guid': boss_guid
            })

        # Extract environment theme
        theme_guid = self.extract_guid(data.get('EnvironmentTheme'))

        # Extract music
        music_guid = self.extract_guid(data.get('MainMusic'))

        return {
            'name': data.get('m_Name', filepath.stem),
            'id': data.get('ID', ''),
            'display_name_key': data.get('DisplayNameLocalizationKey', ''),
            'show_world_unlock': data.get('ShowWorldUnlock', False),
            'environment_theme': {
                'name': self.resolve_guid(theme_guid),
                'guid': theme_guid
            } if theme_guid else None,
            'main_music': {
                'name': self.resolve_guid(music_guid),
                'guid': music_guid
            } if music_guid else None,
            'localization_strings': data.get('LocalizationStrings', []),
            'levels': level_refs,
            'mini_bosses': mini_bosses,
            'level_count': len(level_refs)
        }

    def extract_all_chapters(self):
        """Extract all chapter data"""
        print("\nExtracting chapter data...")

        chapter_files = sorted(self.base_path.glob("Chapter*.asset"))
        print(f"Found {len(chapter_files)} chapter files")

        for filepath in chapter_files:
            print(f"Processing {filepath.name}...")
            chapter_data = self.extract_chapter_data(filepath)
            if chapter_data:
                self.chapters[filepath.stem] = chapter_data

        print(f"Extracted {len(self.chapters)} chapters")
        return self.chapters

    def generate_complete_json(self):
        """Generate complete JSON output with all data"""

        # Sort levels by world and level number
        sorted_levels = sorted(
            self.levels.values(),
            key=lambda x: x.get('sort_key', 999999)
        )

        # Build world structure
        worlds = defaultdict(list)
        for level in sorted_levels:
            world_num = level.get('world', 0)
            worlds[world_num].append(level)

        # Calculate statistics
        stats = {
            'total_levels': len(self.levels),
            'total_chapters': len(self.chapters),
            'total_worlds': len(worlds),
            'custom_fight_levels': sum(1 for l in sorted_levels if l.get('use_custom_fights')),
            'procedural_levels': sum(1 for l in sorted_levels if not l.get('use_custom_fights')),
            'total_fights': sum(l.get('fight_count', 0) for l in sorted_levels),
            'total_enemies': sum(l.get('total_enemies', 0) for l in sorted_levels),
            'unique_enemies': len(set(
                enemy['character_guid']
                for level in sorted_levels
                for fight in level.get('fights', [])
                for enemy in fight.get('enemies', [])
                if enemy.get('character_guid')
            )),
            'unique_structures': len(set(
                struct['guid']
                for level in sorted_levels
                for struct in level.get('structures', [])
                if struct.get('guid')
            ))
        }

        complete_data = {
            'game': 'Gear Fight 5.1.3',
            'extraction_date': '2025-09-15',
            'statistics': stats,
            'guid_mappings': {
                'total_mapped': len(self.guid_map),
                'sample': dict(list(self.guid_map.items())[:20])  # Sample for reference
            },
            'chapters': self.chapters,
            'worlds': dict(worlds),
            'all_levels': sorted_levels
        }

        return complete_data

    def save_json(self, output_file="gear_fight_levels.json"):
        """Save complete data to JSON file"""
        print(f"\nSaving to {output_file}...")

        data = self.generate_complete_json()

        with open(output_file, 'w', encoding='utf-8') as f:
            json.dump(data, f, indent=2, ensure_ascii=False)

        print(f"Successfully saved {len(self.levels)} levels to {output_file}")

        # Also save a compact version
        compact_file = output_file.replace('.json', '_compact.json')
        with open(compact_file, 'w', encoding='utf-8') as f:
            json.dump(data, f, ensure_ascii=False, separators=(',', ':'))

        print(f"Also saved compact version to {compact_file}")

        return output_file

def main():
    """Main extraction process"""
    print("=" * 60)
    print("Gear Fight Level Data Extractor")
    print("=" * 60)

    extractor = GearFightLevelExtractor("MonoBehaviour")

    # Build GUID map first
    extractor.build_guid_map()

    # Extract all data
    extractor.extract_all_chapters()
    extractor.extract_all_levels()

    # Save to JSON
    output_file = extractor.save_json("gear_fight_complete_levels.json")

    print("\n" + "=" * 60)
    print("Extraction Complete!")
    print(f"Output: {output_file}")
    print("=" * 60)

if __name__ == "__main__":
    main()