#!/usr/bin/env python3
"""
Gear Fight Game Analysis Tool
============================ 

🔍 CRITICAL: MECHANIC DISCOVERY IS PRIMARY GOAL
This tool discovers and catalogs ALL game mechanics from Unity data.
Never miss any game mechanic, component, or behavior.

Comprehensive analysis of all 134 levels to discover:
- Enemy spawn patterns and frequencies
- Structure usage and placement patterns  
- Gear collection economics
- Difficulty progression curves
- Tutorial mechanics
- Procedural vs custom level distribution
- Combat timing patterns
- NIV economy scaling
"""

import json
import os
import glob
from collections import defaultdict, Counter
from datetime import datetime
import statistics
import re
from typing import Dict, List, Any, Tuple

class GearFightAnalyzer:
    def __init__(self, data_dir: str = "LevelJsonData"):
        self.data_dir = data_dir
        self.levels = []
        self.statistics = {}
        self.mechanics = {}
        self.progression = []
        self.patterns = {}
        self.analysis_results = {}
        
        # Load auxiliary data
        self.load_auxiliary_data()
        
    def load_auxiliary_data(self):
        """Load catalog and configuration data"""
        try:
            with open('enemies_catalog.json', 'r') as f:
                self.enemies_catalog = json.load(f)
        except:
            self.enemies_catalog = {"enemies": [], "total": 0}
            
        try:
            with open('structures_catalog.json', 'r') as f:
                self.structures_catalog = json.load(f)
        except:
            self.structures_catalog = {"structures": [], "total": 0}
            
        try:
            with open('chapters.json', 'r') as f:
                self.chapters_data = json.load(f)
        except:
            self.chapters_data = {"chapters": {}}
            
        try:
            with open('config.json', 'r') as f:
                self.config = json.load(f)
        except:
            self.config = {}

    def load_all_levels(self):
        """Load all level data from JSON files"""
        print("🔍 Loading all 134 levels for comprehensive analysis...")
        
        level_files = glob.glob(os.path.join(self.data_dir, "level_*.json"))
        level_files.sort(key=lambda x: self.extract_level_numbers(x))
        
        self.levels = []
        for file_path in level_files:
            try:
                with open(file_path, 'r') as f:
                    level_data = json.load(f)
                    self.levels.append(level_data)
            except Exception as e:
                print(f"❌ Error loading {file_path}: {e}")
                
        print(f"✅ Loaded {len(self.levels)} levels successfully")
        return len(self.levels)

    def extract_level_numbers(self, filename: str) -> Tuple[int, int]:
        """Extract world and level numbers for sorting"""
        match = re.search(r'level_(\d+)_(\d+)\.json', filename)
        if match:
            return (int(match.group(1)), int(match.group(2)))
        return (0, 0)

    def discover_all_enemies(self):
        """🔍 CRITICAL: Discover ALL enemy types across all levels"""
        print("\n🔍 DISCOVERING ALL ENEMY TYPES...")
        
        all_enemies = set()
        enemy_usage = Counter()
        enemy_first_appearance = {}
        enemy_level_distribution = defaultdict(list)
        enemy_delay_patterns = defaultdict(list)
        beast_mode_usage = Counter()
        
        for level in self.levels:
            world = level.get('worldNumber', 0)
            level_num = level.get('levelInWorld', 0)
            level_key = f"World {world}-{level_num}"
            
            # Extract from fights array
            for fight in level.get('fights', []):
                for enemy in fight.get('enemies', []):
                    enemy_type = enemy.get('character', '').strip()
                    if enemy_type and enemy_type != "":
                        all_enemies.add(enemy_type)
                        enemy_usage[enemy_type] += 1
                        
                        # Track first appearance
                        if enemy_type not in enemy_first_appearance:
                            enemy_first_appearance[enemy_type] = level_key
                            
                        # Track level distribution
                        enemy_level_distribution[enemy_type].append(level_key)
                        
                        # Track spawn delay patterns
                        delay = enemy.get('delay', 0)
                        enemy_delay_patterns[enemy_type].append(delay)
                        
                        # Track beast mode usage
                        if enemy.get('isBeast', 0):
                            beast_mode_usage[enemy_type] += 1
            
            # Extract from enemies summary (may catch additional ones)
            for enemy_type in level.get('enemies', []):
                if enemy_type and enemy_type.strip():
                    all_enemies.add(enemy_type.strip())
        
        # Compare with catalog to find missing enemies
        catalog_enemies = set(self.enemies_catalog.get('enemies', []))
        discovered_enemies = all_enemies
        missing_from_catalog = discovered_enemies - catalog_enemies
        missing_from_levels = catalog_enemies - discovered_enemies
        
        self.mechanics['enemies'] = {
            'total_discovered': len(discovered_enemies),
            'all_enemy_types': sorted(list(discovered_enemies)),
            'usage_frequency': dict(enemy_usage.most_common()),
            'first_appearance': enemy_first_appearance,
            'level_distribution': dict(enemy_level_distribution),
            'delay_patterns': {enemy: {
                'min_delay': min(delays) if delays else 0,
                'max_delay': max(delays) if delays else 0,
                'avg_delay': statistics.mean(delays) if delays else 0,
                'common_delays': Counter(delays).most_common(3)
            } for enemy, delays in enemy_delay_patterns.items()},
            'beast_mode_usage': dict(beast_mode_usage),
            'catalog_comparison': {
                'catalog_count': len(catalog_enemies),
                'discovered_count': len(discovered_enemies),
                'missing_from_catalog': sorted(list(missing_from_catalog)),
                'missing_from_levels': sorted(list(missing_from_levels))
            }
        }
        
        print(f"🎯 DISCOVERED {len(discovered_enemies)} ENEMY TYPES:")
        for i, enemy in enumerate(sorted(discovered_enemies), 1):
            usage = enemy_usage.get(enemy, 0)
            first = enemy_first_appearance.get(enemy, "Unknown")
            print(f"   {i:2d}. {enemy:<25} (Used {usage:3d} times, First: {first})")
            
        if missing_from_catalog:
            print(f"\n⚠️  CRITICAL: {len(missing_from_catalog)} enemies found in levels but MISSING from catalog:")
            for enemy in missing_from_catalog:
                print(f"   - {enemy}")
                
        return discovered_enemies

    def discover_all_structures(self):
        """🔍 CRITICAL: Discover ALL structure types across all levels"""
        print("\n🔍 DISCOVERING ALL STRUCTURE TYPES...")
        
        all_structures = set()
        structure_usage = Counter()
        structure_first_appearance = {}
        structure_level_distribution = defaultdict(list)
        structure_chest_usage = Counter()
        structure_value_correlation = defaultdict(list)
        
        for level in self.levels:
            world = level.get('worldNumber', 0)
            level_num = level.get('levelInWorld', 0)
            level_key = f"World {world}-{level_num}"
            
            # Extract from fights array
            for fight in level.get('fights', []):
                structure = fight.get('structure')
                if structure and structure.strip() and structure != "null":
                    # Clean structure name (remove .asset extension)
                    clean_structure = structure.replace('.asset', '').strip()
                    all_structures.add(clean_structure)
                    structure_usage[clean_structure] += 1
                    
                    # Track first appearance
                    if clean_structure not in structure_first_appearance:
                        structure_first_appearance[clean_structure] = level_key
                        
                    # Track level distribution
                    structure_level_distribution[clean_structure].append(level_key)
                    
                    # Track chest usage
                    if fight.get('hasStructureChest', 0):
                        structure_chest_usage[clean_structure] += 1
                        
                    # Track value correlation
                    fight_value = fight.get('valueOfFight', 0)
                    structure_value_correlation[clean_structure].append(fight_value)
            
            # Extract from structures summary
            for structure in level.get('structures', []):
                if structure and structure.strip():
                    clean_structure = structure.replace('.asset', '').strip()
                    all_structures.add(clean_structure)
        
        # Compare with catalog
        catalog_structures = set(self.structures_catalog.get('structures', []))
        discovered_structures = all_structures
        missing_from_catalog = discovered_structures - catalog_structures
        missing_from_levels = catalog_structures - discovered_structures
        
        self.mechanics['structures'] = {
            'total_discovered': len(discovered_structures),
            'all_structure_types': sorted(list(discovered_structures)),
            'usage_frequency': dict(structure_usage.most_common()),
            'first_appearance': structure_first_appearance,
            'level_distribution': dict(structure_level_distribution),
            'chest_usage': dict(structure_chest_usage),
            'value_correlation': {struct: {
                'min_value': min(values) if values else 0,
                'max_value': max(values) if values else 0,
                'avg_value': statistics.mean(values) if values else 0
            } for struct, values in structure_value_correlation.items()},
            'catalog_comparison': {
                'catalog_count': len(catalog_structures),
                'discovered_count': len(discovered_structures),
                'missing_from_catalog': sorted(list(missing_from_catalog)),
                'missing_from_levels': sorted(list(missing_from_levels))
            }
        }
        
        print(f"🎯 DISCOVERED {len(discovered_structures)} STRUCTURE TYPES:")
        for i, structure in enumerate(sorted(discovered_structures), 1):
            usage = structure_usage.get(structure, 0)
            first = structure_first_appearance.get(structure, "Unknown")
            print(f"   {i:2d}. {structure:<30} (Used {usage:3d} times, First: {first})")
            
        if missing_from_catalog:
            print(f"\n⚠️  CRITICAL: {len(missing_from_catalog)} structures found in levels but MISSING from catalog:")
            for structure in missing_from_catalog:
                print(f"   - {structure}")
                
        return discovered_structures

    def analyze_gear_economy(self):
        """Analyze gear collection patterns and economy"""
        print("\n🔍 ANALYZING GEAR ECONOMY SYSTEM...")
        
        gear_types = set()
        gear_usage = Counter()
        gear_collection_sizes = []
        premium_gear_usage = Counter()
        gear_progression = defaultdict(list)
        starting_coins_progression = []
        fight_values = []
        
        for level in self.levels:
            world = level.get('worldNumber', 0)
            level_num = level.get('levelInWorld', 0)
            
            # Starting coins progression
            starting_coins = level.get('levelSettings', {}).get('startingCoins', 0)
            starting_coins_progression.append((world, level_num, starting_coins))
            
            # Regular gear collections
            gear_collections = level.get('gearStoreCollections', [])
            for i, collection in enumerate(gear_collections):
                gear_collection_sizes.append(len(collection))
                for gear_item in collection:
                    gear_name = gear_item.get('name', '').replace('.asset', '').strip()
                    if gear_name:
                        gear_types.add(gear_name)
                        gear_usage[gear_name] += 1
                        gear_progression[gear_name].append((world, level_num, i+1))
            
            # Premium gear collections
            premium_collections = level.get('premiumGearStoreCollections', [])
            for collection in premium_collections:
                for gear_item in collection:
                    gear_name = gear_item.get('name', '').replace('.asset', '').strip()
                    if gear_name:
                        premium_gear_usage[gear_name] += 1
            
            # Fight values
            for fight in level.get('fights', []):
                fight_value = fight.get('valueOfFight', 0)
                if fight_value > 0:
                    fight_values.append(fight_value)
        
        self.mechanics['gear_economy'] = {
            'total_gear_types': len(gear_types),
            'all_gear_types': sorted(list(gear_types)),
            'gear_usage_frequency': dict(gear_usage.most_common()),
            'premium_gear_usage': dict(premium_gear_usage),
            'collection_size_stats': {
                'min_size': min(gear_collection_sizes) if gear_collection_sizes else 0,
                'max_size': max(gear_collection_sizes) if gear_collection_sizes else 0,
                'avg_size': statistics.mean(gear_collection_sizes) if gear_collection_sizes else 0,
                'size_distribution': dict(Counter(gear_collection_sizes))
            },
            'starting_coins_progression': {
                'min_coins': min([coins for _, _, coins in starting_coins_progression]) if starting_coins_progression else 0,
                'max_coins': max([coins for _, _, coins in starting_coins_progression]) if starting_coins_progression else 0,
                'avg_coins': statistics.mean([coins for _, _, coins in starting_coins_progression]) if starting_coins_progression else 0
            },
            'fight_value_stats': {
                'min_value': min(fight_values) if fight_values else 0,
                'max_value': max(fight_values) if fight_values else 0,
                'avg_value': statistics.mean(fight_values) if fight_values else 0,
                'value_distribution': dict(Counter(fight_values))
            }
        }
        
        print(f"🎯 DISCOVERED {len(gear_types)} GEAR TYPES")
        print(f"   Collection sizes: {min(gear_collection_sizes) if gear_collection_sizes else 0}-{max(gear_collection_sizes) if gear_collection_sizes else 0} items")
        print(f"   Starting coins: {min([coins for _, _, coins in starting_coins_progression]) if starting_coins_progression else 0}-{max([coins for _, _, coins in starting_coins_progression]) if starting_coins_progression else 0} coins")
        print(f"   Fight values: {min(fight_values) if fight_values else 0}-{max(fight_values) if fight_values else 0}")

    def analyze_level_distribution(self):
        """Analyze procedural vs custom level distribution"""
        print("\n🔍 ANALYZING LEVEL DISTRIBUTION...")
        
        procedural_count = 0
        custom_count = 0
        custom_fights_count = 0
        custom_gears_count = 0
        tutorial_levels = []
        
        difficulty_profiles = Counter()
        grid_configurations = Counter()
        spinner_distribution = Counter()
        niv_settings_analysis = defaultdict(list)
        
        for level in self.levels:
            world = level.get('worldNumber', 0)
            level_num = level.get('levelInWorld', 0)
            level_key = f"World {world}-{level_num}"
            
            # Check metadata
            metadata = level.get('metadata', {})
            if metadata.get('isProcedurallyGenerated', False):
                procedural_count += 1
            else:
                custom_count += 1
            
            # Check settings
            settings = level.get('levelSettings', {})
            if settings.get('useCustomFights', 0):
                custom_fights_count += 1
            if settings.get('useCustomGears', 0):
                custom_gears_count += 1
                
            # Tutorial detection
            tutorial_skip = settings.get('tutorialSkipString')
            if tutorial_skip:
                tutorial_levels.append((level_key, tutorial_skip))
            
            # Difficulty profiles
            diff_profile = (settings.get('difficultyProfile') or {}).get('name', 'Unknown')
            difficulty_profiles[diff_profile] += 1
            
            # Grid configurations
            grid_config = (settings.get('customLevelGrid') or {}).get('name', 'Default')
            grid_configurations[grid_config] += 1
            
            # Spinner distribution
            spinners = settings.get('numberOfSpinners', 0)
            spinner_distribution[spinners] += 1
            
            # NIV settings
            niv = settings.get('nivSettings', {})
            for key, value in niv.items():
                niv_settings_analysis[key].append(value)
        
        self.mechanics['level_distribution'] = {
            'total_levels': len(self.levels),
            'procedural_levels': procedural_count,
            'custom_levels': custom_count,
            'custom_fights_levels': custom_fights_count,
            'custom_gears_levels': custom_gears_count,
            'tutorial_levels': tutorial_levels,
            'difficulty_profiles': dict(difficulty_profiles),
            'grid_configurations': dict(grid_configurations),
            'spinner_distribution': dict(spinner_distribution),
            'niv_settings_analysis': {key: {
                'min': min(values) if values else 0,
                'max': max(values) if values else 0,
                'avg': statistics.mean(values) if values else 0,
                'distribution': dict(Counter(values))
            } for key, values in niv_settings_analysis.items()}
        }
        
        print(f"🎯 LEVEL DISTRIBUTION ANALYSIS:")
        print(f"   Total levels: {len(self.levels)}")
        print(f"   Procedural: {procedural_count} ({procedural_count/len(self.levels)*100:.1f}%)")
        print(f"   Custom: {custom_count} ({custom_count/len(self.levels)*100:.1f}%)")
        print(f"   Tutorial levels: {len(tutorial_levels)}")
        print(f"   Difficulty profiles: {len(difficulty_profiles)}")

    def analyze_combat_patterns(self):
        """Analyze wave-based combat patterns"""
        print("\n🔍 ANALYZING COMBAT PATTERNS...")
        
        fight_counts = []
        enemy_counts_per_fight = []
        delay_patterns = []
        beast_mode_frequency = 0
        total_enemies = 0
        
        fight_value_progression = []
        force_basic_shop_usage = 0
        structure_chest_frequency = 0
        
        for level in self.levels:
            world = level.get('worldNumber', 0)
            level_num = level.get('levelInWorld', 0)
            
            fights = level.get('fights', [])
            fight_counts.append(len(fights))
            
            for fight_idx, fight in enumerate(fights):
                enemies = fight.get('enemies', [])
                enemy_count = len([e for e in enemies if e.get('character', '').strip()])
                enemy_counts_per_fight.append(enemy_count)
                total_enemies += enemy_count
                
                # Analyze delays
                for enemy in enemies:
                    delay = enemy.get('delay', 0)
                    delay_patterns.append(delay)
                    
                    if enemy.get('isBeast', 0):
                        beast_mode_frequency += 1
                
                # Fight properties
                fight_value = fight.get('valueOfFight', 0)
                fight_value_progression.append((world, level_num, fight_idx+1, fight_value))
                
                if fight.get('forceBasicShop', 0):
                    force_basic_shop_usage += 1
                    
                if fight.get('hasStructureChest', 0):
                    structure_chest_frequency += 1
        
        self.mechanics['combat_patterns'] = {
            'fight_count_stats': {
                'min_fights': min(fight_counts) if fight_counts else 0,
                'max_fights': max(fight_counts) if fight_counts else 0,
                'avg_fights': statistics.mean(fight_counts) if fight_counts else 0,
                'fight_distribution': dict(Counter(fight_counts))
            },
            'enemy_count_stats': {
                'min_enemies_per_fight': min(enemy_counts_per_fight) if enemy_counts_per_fight else 0,
                'max_enemies_per_fight': max(enemy_counts_per_fight) if enemy_counts_per_fight else 0,
                'avg_enemies_per_fight': statistics.mean(enemy_counts_per_fight) if enemy_counts_per_fight else 0,
                'total_enemies': total_enemies
            },
            'timing_patterns': {
                'min_delay': min(delay_patterns) if delay_patterns else 0,
                'max_delay': max(delay_patterns) if delay_patterns else 0,
                'avg_delay': statistics.mean(delay_patterns) if delay_patterns else 0,
                'common_delays': Counter(delay_patterns).most_common(10)
            },
            'beast_mode_frequency': beast_mode_frequency,
            'force_basic_shop_usage': force_basic_shop_usage,
            'structure_chest_frequency': structure_chest_frequency
        }
        
        print(f"🎯 COMBAT PATTERNS:")
        print(f"   Fights per level: {min(fight_counts) if fight_counts else 0}-{max(fight_counts) if fight_counts else 0}")
        print(f"   Enemies per fight: {min(enemy_counts_per_fight) if enemy_counts_per_fight else 0}-{max(enemy_counts_per_fight) if enemy_counts_per_fight else 0}")
        print(f"   Total enemies: {total_enemies}")
        print(f"   Beast mode uses: {beast_mode_frequency}")

    def analyze_progression_timeline(self):
        """Create mechanic progression timeline"""
        print("\n🔍 ANALYZING PROGRESSION TIMELINE...")
        
        timeline = []
        mechanic_introductions = {}
        
        # Sort levels by world and level number
        sorted_levels = sorted(self.levels, key=lambda x: (x.get('worldNumber', 0), x.get('levelInWorld', 0)))
        
        for level in sorted_levels:
            world = level.get('worldNumber', 0)
            level_num = level.get('levelInWorld', 0)
            level_key = f"World {world}-{level_num}"
            
            level_mechanics = {
                'level': level_key,
                'world': world,
                'level_in_world': level_num,
                'new_enemies': [],
                'new_structures': [],
                'new_gears': [],
                'mechanics': []
            }
            
            # Check for new enemies
            for fight in level.get('fights', []):
                for enemy in fight.get('enemies', []):
                    enemy_type = enemy.get('character', '').strip()
                    if enemy_type and enemy_type not in mechanic_introductions:
                        mechanic_introductions[enemy_type] = level_key
                        level_mechanics['new_enemies'].append(enemy_type)
            
            # Check for new structures  
            for fight in level.get('fights', []):
                structure = fight.get('structure')
                if structure and structure.strip():
                    clean_structure = structure.replace('.asset', '').strip()
                    if clean_structure not in mechanic_introductions:
                        mechanic_introductions[clean_structure] = level_key
                        level_mechanics['new_structures'].append(clean_structure)
            
            # Check for tutorial mechanics
            tutorial_skip = level.get('levelSettings', {}).get('tutorialSkipString')
            if tutorial_skip:
                level_mechanics['mechanics'].append(f"Tutorial: {tutorial_skip}")
            
            # Check for special settings
            settings = level.get('levelSettings', {})
            if settings.get('useCustomFights', 0):
                level_mechanics['mechanics'].append("Custom Fights")
            if settings.get('useCustomGears', 0):
                level_mechanics['mechanics'].append("Custom Gears")
            
            timeline.append(level_mechanics)
        
        self.progression = timeline
        
        # Count significant introductions
        significant_levels = [entry for entry in timeline 
                            if entry['new_enemies'] or entry['new_structures'] or entry['mechanics']]
        
        print(f"🎯 PROGRESSION TIMELINE:")
        print(f"   {len(significant_levels)} levels introduce new mechanics")
        print(f"   Tutorial level: World 1-1")
        
        # Show first few introductions
        for entry in timeline[:5]:
            if entry['new_enemies'] or entry['new_structures'] or entry['mechanics']:
                print(f"   {entry['level']}: {', '.join(entry['new_enemies'] + entry['new_structures'] + entry['mechanics'])}")

    def calculate_statistics(self):
        """Calculate comprehensive game statistics"""
        print("\n🔍 CALCULATING COMPREHENSIVE STATISTICS...")
        
        self.statistics = {
            'game_overview': {
                'total_levels': len(self.levels),
                'total_worlds': len(set(level.get('worldNumber', 0) for level in self.levels)),
                'total_chapters': len(self.chapters_data.get('chapters', {})),
                'version': self.config.get('version', 'Unknown')
            },
            'level_distribution': {
                'procedural_levels': sum(1 for level in self.levels 
                                       if level.get('metadata', {}).get('isProcedurallyGenerated', False)),
                'custom_levels': sum(1 for level in self.levels 
                                   if not level.get('metadata', {}).get('isProcedurallyGenerated', False)),
                'levels_with_custom_fights': sum(1 for level in self.levels 
                                               if level.get('levelSettings', {}).get('useCustomFights', 0)),
                'levels_with_custom_gears': sum(1 for level in self.levels 
                                              if level.get('levelSettings', {}).get('useCustomGears', 0))
            },
            'combat_statistics': {
                'total_fights': sum(len(level.get('fights', [])) for level in self.levels),
                'total_enemies': sum(level.get('metadata', {}).get('totalEnemies', 0) for level in self.levels),
                'unique_enemy_types': len(self.mechanics.get('enemies', {}).get('all_enemy_types', [])),
                'unique_structure_types': len(self.mechanics.get('structures', {}).get('all_structure_types', []))
            },
            'economy_statistics': {
                'unique_gear_types': len(self.mechanics.get('gear_economy', {}).get('all_gear_types', [])),
                'avg_starting_coins': self.mechanics.get('gear_economy', {}).get('starting_coins_progression', {}).get('avg_coins', 0),
                'avg_fight_value': self.mechanics.get('gear_economy', {}).get('fight_value_stats', {}).get('avg_value', 0)
            }
        }

    def identify_patterns(self):
        """Identify gameplay patterns and relationships"""
        print("\n🔍 IDENTIFYING GAMEPLAY PATTERNS...")
        
        self.patterns = {
            'difficulty_scaling': self.analyze_difficulty_scaling(),
            'enemy_progression': self.analyze_enemy_progression(),
            'structure_usage': self.analyze_structure_usage(),
            'economy_balance': self.analyze_economy_balance(),
            'tutorial_design': self.analyze_tutorial_design()
        }

    def analyze_difficulty_scaling(self):
        """Analyze how difficulty scales across worlds"""
        world_stats = defaultdict(list)
        
        for level in self.levels:
            world = level.get('worldNumber', 0)
            total_enemies = level.get('metadata', {}).get('totalEnemies', 0)
            fight_count = level.get('metadata', {}).get('fightCount', 0)
            starting_coins = level.get('levelSettings', {}).get('startingCoins', 0)
            
            world_stats[world].append({
                'enemies': total_enemies,
                'fights': fight_count,
                'coins': starting_coins
            })
        
        scaling_analysis = {}
        for world, stats in world_stats.items():
            if stats:
                scaling_analysis[f"World {world}"] = {
                    'avg_enemies': statistics.mean([s['enemies'] for s in stats]),
                    'avg_fights': statistics.mean([s['fights'] for s in stats]),
                    'avg_starting_coins': statistics.mean([s['coins'] for s in stats]),
                    'level_count': len(stats)
                }
        
        return scaling_analysis

    def analyze_enemy_progression(self):
        """Analyze how enemies are introduced across worlds"""
        enemy_introductions = {}
        
        for level in self.levels:
            world = level.get('worldNumber', 0)
            for enemy_type in level.get('enemies', []):
                if enemy_type not in enemy_introductions:
                    enemy_introductions[enemy_type] = world
        
        progression = defaultdict(list)
        for enemy, world in enemy_introductions.items():
            progression[world].append(enemy)
        
        return dict(progression)

    def analyze_structure_usage(self):
        """Analyze structure usage patterns"""
        structure_by_world = defaultdict(set)
        
        for level in self.levels:
            world = level.get('worldNumber', 0)
            for structure in level.get('structures', []):
                structure_by_world[world].add(structure)
        
        return {f"World {w}": list(structures) for w, structures in structure_by_world.items()}

    def analyze_economy_balance(self):
        """Analyze economic balance across progression"""
        world_economy = defaultdict(list)
        
        for level in self.levels:
            world = level.get('worldNumber', 0)
            starting_coins = level.get('levelSettings', {}).get('startingCoins', 0)
            fight_values = [f.get('valueOfFight', 0) for f in level.get('fights', [])]
            total_value = sum(fight_values)
            
            world_economy[world].append({
                'starting_coins': starting_coins,
                'total_fight_value': total_value,
                'avg_fight_value': statistics.mean(fight_values) if fight_values else 0
            })
        
        balance_analysis = {}
        for world, data in world_economy.items():
            if data:
                balance_analysis[f"World {world}"] = {
                    'avg_starting_coins': statistics.mean([d['starting_coins'] for d in data]),
                    'avg_total_value': statistics.mean([d['total_fight_value'] for d in data]),
                    'avg_fight_value': statistics.mean([d['avg_fight_value'] for d in data])
                }
        
        return balance_analysis

    def analyze_tutorial_design(self):
        """Analyze tutorial mechanics and design"""
        tutorial_levels = []
        
        for level in self.levels:
            tutorial_skip = level.get('levelSettings', {}).get('tutorialSkipString')
            if tutorial_skip:
                world = level.get('worldNumber', 0)
                level_num = level.get('levelInWorld', 0)
                tutorial_levels.append({
                    'level': f"World {world}-{level_num}",
                    'tutorial_type': tutorial_skip,
                    'enemies': level.get('enemies', []),
                    'structures': level.get('structures', []),
                    'fight_count': len(level.get('fights', [])),
                    'starting_coins': level.get('levelSettings', {}).get('startingCoins', 0)
                })
        
        return tutorial_levels

    def generate_recommendations(self):
        """Generate recommendations based on analysis"""
        recommendations = []
        
        # Enemy discovery recommendations
        enemy_data = self.mechanics.get('enemies', {})
        if enemy_data.get('catalog_comparison', {}).get('missing_from_catalog'):
            recommendations.append({
                'priority': 'P0',
                'category': 'Data Integrity',
                'issue': 'Missing enemies in catalog',
                'description': f"{len(enemy_data['catalog_comparison']['missing_from_catalog'])} enemies found in levels not in catalog",
                'action': 'Update enemies_catalog.json with discovered enemies',
                'owner': 'code-archaeologist'
            })
        
        # Structure discovery recommendations
        structure_data = self.mechanics.get('structures', {})
        if structure_data.get('catalog_comparison', {}).get('missing_from_catalog'):
            recommendations.append({
                'priority': 'P0',
                'category': 'Data Integrity', 
                'issue': 'Missing structures in catalog',
                'description': f"{len(structure_data['catalog_comparison']['missing_from_catalog'])} structures found in levels not in catalog",
                'action': 'Update structures_catalog.json with discovered structures',
                'owner': 'code-archaeologist'
            })
        
        # Config validation
        config_enemies = set(self.config.get('game_specifics', {}).get('enemy_types', []))
        discovered_enemies = set(enemy_data.get('all_enemy_types', []))
        if config_enemies != discovered_enemies:
            recommendations.append({
                'priority': 'P1',
                'category': 'Configuration',
                'issue': 'Config enemy types mismatch',
                'description': 'Enemy types in config.json do not match discovered enemies',
                'action': 'Synchronize config.json enemy_types with actual data',
                'owner': 'backend-developer'
            })
        
        # Gear economy balance
        gear_data = self.mechanics.get('gear_economy', {})
        if gear_data.get('total_gear_types', 0) < 10:
            recommendations.append({
                'priority': 'P2',
                'category': 'Game Balance',
                'issue': 'Limited gear variety',
                'description': f"Only {gear_data.get('total_gear_types', 0)} gear types discovered",
                'action': 'Investigate Unity data for additional gear types',
                'owner': 'code-archaeologist'
            })
        
        return recommendations

    def run_comprehensive_analysis(self):
        """Run complete analysis pipeline"""
        print("🚀 STARTING COMPREHENSIVE GEAR FIGHT ANALYSIS")
        print("=" * 60)
        
        # Load data
        if self.load_all_levels() == 0:
            print("❌ No levels loaded. Cannot proceed with analysis.")
            return None
        
        # Discovery phase
        print("\n🔍 DISCOVERY PHASE - Finding ALL game mechanics")
        self.discover_all_enemies()
        self.discover_all_structures() 
        self.analyze_gear_economy()
        self.analyze_level_distribution()
        self.analyze_combat_patterns()
        
        # Analysis phase
        print("\n📊 ANALYSIS PHASE - Understanding patterns and progression")
        self.analyze_progression_timeline()
        self.calculate_statistics()
        self.identify_patterns()
        
        # Synthesis phase
        print("\n🎯 SYNTHESIS PHASE - Generating insights and recommendations")
        recommendations = self.generate_recommendations()
        
        # Compile results
        self.analysis_results = {
            'game': 'Gear Fight',
            'version': self.config.get('version', '5.1.3'),
            'analysis_date': datetime.now().isoformat(),
            'total_levels_analyzed': len(self.levels),
            'statistics': self.statistics,
            'mechanics': self.mechanics,
            'progression': self.progression,
            'patterns': self.patterns,
            'recommendations': recommendations,
            'metadata': {
                'analyzer_version': '1.0.0',
                'analysis_type': 'comprehensive_mechanic_discovery',
                'data_sources': ['LevelJsonData', 'enemies_catalog.json', 'structures_catalog.json', 'chapters.json', 'config.json']
            }
        }
        
        print("\n✅ ANALYSIS COMPLETE!")
        print(f"   Analyzed {len(self.levels)} levels")
        print(f"   Discovered {len(self.mechanics.get('enemies', {}).get('all_enemy_types', []))} enemy types")
        print(f"   Discovered {len(self.mechanics.get('structures', {}).get('all_structure_types', []))} structure types") 
        print(f"   Discovered {len(self.mechanics.get('gear_economy', {}).get('all_gear_types', []))} gear types")
        print(f"   Generated {len(recommendations)} recommendations")
        
        return self.analysis_results

    def save_analysis(self, filename: str = 'game_analysis.json'):
        """Save analysis results to JSON file"""
        if not self.analysis_results:
            print("❌ No analysis results to save. Run analysis first.")
            return False
            
        try:
            with open(filename, 'w') as f:
                json.dump(self.analysis_results, f, indent=2, default=str)
            print(f"✅ Analysis saved to {filename}")
            return True
        except Exception as e:
            print(f"❌ Error saving analysis: {e}")
            return False

    def print_summary_report(self):
        """Print a human-readable summary report"""
        if not self.analysis_results:
            print("❌ No analysis results available. Run analysis first.")
            return
            
        print("\n" + "="*80)
        print("🎮 GEAR FIGHT COMPREHENSIVE ANALYSIS REPORT")
        print("="*80)
        
        stats = self.analysis_results['statistics']
        mechanics = self.analysis_results['mechanics']
        recommendations = self.analysis_results['recommendations']
        
        print(f"\n📊 OVERVIEW")
        print(f"   Game: {self.analysis_results['game']} v{self.analysis_results['version']}")
        print(f"   Total Levels: {stats['game_overview']['total_levels']}")
        print(f"   Worlds: {stats['game_overview']['total_worlds']}")
        print(f"   Chapters: {stats['game_overview']['total_chapters']}")
        
        print(f"\n🎯 MECHANICS DISCOVERED")
        enemy_data = mechanics.get('enemies', {})
        print(f"   Enemies: {enemy_data.get('total_discovered', 0)} types")
        for enemy in enemy_data.get('all_enemy_types', [])[:10]:
            count = enemy_data.get('usage_frequency', {}).get(enemy, 0)
            print(f"     • {enemy:<25} (used {count} times)")
        if len(enemy_data.get('all_enemy_types', [])) > 10:
            print(f"     ... and {len(enemy_data.get('all_enemy_types', [])) - 10} more")
            
        structure_data = mechanics.get('structures', {})
        print(f"   Structures: {structure_data.get('total_discovered', 0)} types")
        for structure in structure_data.get('all_structure_types', [])[:5]:
            count = structure_data.get('usage_frequency', {}).get(structure, 0)
            print(f"     • {structure:<25} (used {count} times)")
            
        gear_data = mechanics.get('gear_economy', {})
        print(f"   Gear Types: {gear_data.get('total_gear_types', 0)}")
        
        print(f"\n⚠️  CRITICAL ISSUES ({len([r for r in recommendations if r['priority'] == 'P0'])} P0 issues)")
        p0_issues = [r for r in recommendations if r['priority'] == 'P0']
        for issue in p0_issues:
            print(f"   🔥 {issue['issue']}: {issue['description']}")
            
        print(f"\n🔧 RECOMMENDATIONS ({len(recommendations)} total)")
        for rec in recommendations[:5]:
            print(f"   {rec['priority']} | {rec['category']}: {rec['issue']}")
            
        print(f"\n📈 PROGRESSION")
        significant_introductions = [p for p in self.analysis_results['progression'] 
                                   if p['new_enemies'] or p['new_structures'] or p['mechanics']]
        print(f"   {len(significant_introductions)} levels introduce new mechanics")
        
        print("\n" + "="*80)

if __name__ == "__main__":
    print("🎮 Gear Fight Comprehensive Game Analysis Tool")
    print("🔍 PRIMARY GOAL: Discover ALL game mechanics from Unity data")
    print("-" * 60)
    
    analyzer = GearFightAnalyzer()
    
    # Run comprehensive analysis
    results = analyzer.run_comprehensive_analysis()
    
    if results:
        # Save results
        analyzer.save_analysis('game_analysis.json')
        
        # Print summary
        analyzer.print_summary_report()
        
        print(f"\n📁 Full analysis saved to: game_analysis.json")
        print(f"📊 Use this data for:")
        print(f"   • Game balance optimization")
        print(f"   • Mechanic discovery validation") 
        print(f"   • Performance tuning")
        print(f"   • Content gap analysis")
    else:
        print("❌ Analysis failed. Check data files and try again.")
