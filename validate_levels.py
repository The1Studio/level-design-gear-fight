#!/usr/bin/env python3
"""
Comprehensive Level Validation System for Gear Fight
Validates level data integrity, game balance, and structural correctness.
"""

import json
import os
import sys
import argparse
from typing import Dict, List, Any, Optional, Tuple
from dataclasses import dataclass, asdict
from datetime import datetime
import glob

@dataclass
class ValidationResult:
    """Container for validation results."""
    level_id: str
    errors: List[str]
    warnings: List[str]
    suggestions: List[str]
    solvability_score: float
    is_valid: bool

@dataclass
class ValidationSummary:
    """Summary of validation across multiple levels."""
    total_levels: int
    valid_levels: int
    invalid_levels: int
    total_errors: int
    total_warnings: int
    average_solvability: float
    results: List[ValidationResult]
    timestamp: str

class LevelValidator:
    """Main validation engine for Gear Fight levels."""

    def __init__(self, base_path: str = "."):
        self.base_path = base_path
        self.level_data_path = os.path.join(base_path, "LevelJsonData")
        self.enemies_catalog = self._load_catalog("enemies_catalog.json")
        self.structures_catalog = self._load_catalog("structures_catalog.json")
        self.guid_mappings = self._load_catalog("guid_mappings.json")
        self.chapters_data = self._load_catalog("chapters.json")

        # Load all level files for cross-validation
        self.all_levels = self._load_all_levels()

    def _load_catalog(self, filename: str) -> Dict[str, Any]:
        """Load catalog files with error handling."""
        catalog_path = os.path.join(self.base_path, filename)
        try:
            with open(catalog_path, 'r', encoding='utf-8') as f:
                return json.load(f)
        except FileNotFoundError:
            print(f"Warning: {filename} not found at {catalog_path}")
            return {}
        except json.JSONDecodeError as e:
            print(f"Error: Invalid JSON in {filename}: {e}")
            return {}

    def _load_all_levels(self) -> Dict[str, Dict[str, Any]]:
        """Load all level files for cross-validation."""
        levels = {}
        if not os.path.exists(self.level_data_path):
            return levels

        for file_path in glob.glob(os.path.join(self.level_data_path, "level_*.json")):
            try:
                with open(file_path, 'r', encoding='utf-8') as f:
                    level_data = json.load(f)
                    level_id = f"{level_data['worldNumber']}_{level_data['levelInWorld']}"
                    levels[level_id] = level_data
            except Exception as e:
                print(f"Warning: Could not load {file_path}: {e}")

        return levels

    def validate_level(self, level_data: Dict[str, Any]) -> ValidationResult:
        """Validate a single level comprehensively."""
        level_id = f"{level_data.get('worldNumber', 'X')}_{level_data.get('levelInWorld', 'X')}"
        errors = []
        warnings = []
        suggestions = []

        # Core structure validation
        errors.extend(self._validate_level_structure(level_data))

        # Level settings validation
        level_settings_errors, level_settings_warnings = self._validate_level_settings(level_data)
        errors.extend(level_settings_errors)
        warnings.extend(level_settings_warnings)

        # Fight configuration validation
        fight_errors, fight_warnings, fight_suggestions = self._validate_fights(level_data)
        errors.extend(fight_errors)
        warnings.extend(fight_warnings)
        suggestions.extend(fight_suggestions)

        # Economy balance validation
        econ_errors, econ_warnings, econ_suggestions = self._validate_economy(level_data)
        errors.extend(econ_errors)
        warnings.extend(econ_warnings)
        suggestions.extend(econ_suggestions)

        # Procedural vs Custom validation
        proc_errors, proc_warnings = self._validate_procedural_custom(level_data)
        errors.extend(proc_errors)
        warnings.extend(proc_warnings)

        # Cross-reference validation
        ref_errors, ref_warnings = self._validate_references(level_data)
        errors.extend(ref_errors)
        warnings.extend(ref_warnings)

        # Calculate solvability score
        solvability_score = self._calculate_solvability_score(level_data, errors, warnings)

        return ValidationResult(
            level_id=level_id,
            errors=errors,
            warnings=warnings,
            suggestions=suggestions,
            solvability_score=solvability_score,
            is_valid=len(errors) == 0
        )

    def _validate_level_structure(self, level_data: Dict[str, Any]) -> List[str]:
        """Validate required level structure fields."""
        errors = []

        # Required top-level fields
        required_fields = ['levelNumber', 'worldNumber', 'levelInWorld', 'name', 'guid']
        for field in required_fields:
            if field not in level_data:
                errors.append(f"Missing required field: {field}")
            elif level_data[field] is None:
                errors.append(f"Field {field} cannot be null")

        # Validate levelNumber consistency
        if 'levelNumber' in level_data and 'worldNumber' in level_data and 'levelInWorld' in level_data:
            expected_level_number = level_data['worldNumber'] * 1000 + level_data['levelInWorld']
            if level_data['levelNumber'] != expected_level_number:
                errors.append(f"levelNumber {level_data['levelNumber']} doesn't match expected {expected_level_number}")

        # Validate GUID format
        if 'guid' in level_data and level_data['guid']:
            guid = level_data['guid']
            if not isinstance(guid, str) or len(guid) != 32:
                errors.append(f"Invalid GUID format: {guid}")

        # Required nested structures
        if 'levelSettings' not in level_data:
            errors.append("Missing levelSettings object")

        if 'fights' not in level_data:
            errors.append("Missing fights array")
        elif not isinstance(level_data['fights'], list):
            errors.append("fights must be an array")

        if 'gearStoreCollections' not in level_data:
            errors.append("Missing gearStoreCollections array")
        elif not isinstance(level_data['gearStoreCollections'], list):
            errors.append("gearStoreCollections must be an array")

        return errors

    def _validate_level_settings(self, level_data: Dict[str, Any]) -> Tuple[List[str], List[str]]:
        """Validate levelSettings configuration."""
        errors = []
        warnings = []

        if 'levelSettings' not in level_data:
            return errors, warnings

        settings = level_data['levelSettings']

        # Required settings fields
        required_settings = ['useCustomFights', 'useCustomGears', 'startingCoins', 'numberOfSpinners']
        for field in required_settings:
            if field not in settings:
                errors.append(f"Missing levelSettings.{field}")

        # Validate numeric ranges
        if 'startingCoins' in settings:
            coins = settings['startingCoins']
            if not isinstance(coins, int) or coins < 0:
                errors.append(f"startingCoins must be non-negative integer, got {coins}")
            elif coins > 1000:
                warnings.append(f"Very high startingCoins: {coins}")

        if 'numberOfSpinners' in settings:
            spinners = settings['numberOfSpinners']
            if not isinstance(spinners, int) or spinners < 1 or spinners > 5:
                warnings.append(f"numberOfSpinners should be 1-5, got {spinners}")

        # Validate grid dimensions
        if 'gridDimensions' in settings:
            grid = settings['gridDimensions']
            if 'width' not in grid or 'height' not in grid:
                errors.append("gridDimensions missing width or height")
            else:
                if grid['width'] != 7 or grid['height'] != 7:
                    warnings.append(f"Non-standard grid size: {grid['width']}x{grid['height']}")

        # Validate NIV settings
        if 'nivSettings' in settings:
            niv = settings['nivSettings']
            if 'use_level_value' in niv and niv['use_level_value'] not in [0, 1]:
                errors.append("nivSettings.use_level_value must be 0 or 1")

        # Validate difficulty profile
        if 'difficultyProfile' in settings and settings['difficultyProfile']:
            profile = settings['difficultyProfile']
            if 'name' not in profile or 'guid' not in profile:
                errors.append("difficultyProfile missing name or guid")

        return errors, warnings

    def _validate_fights(self, level_data: Dict[str, Any]) -> Tuple[List[str], List[str], List[str]]:
        """Validate fight configurations comprehensively."""
        errors = []
        warnings = []
        suggestions = []

        if 'fights' not in level_data:
            return errors, warnings, suggestions

        fights = level_data['fights']
        if not fights:
            errors.append("Level must have at least one fight")
            return errors, warnings, suggestions

        # Check if this is a custom or procedural level
        is_custom = level_data.get('levelSettings', {}).get('useCustomFights', 0) == 1

        for i, fight in enumerate(fights):
            fight_num = i + 1

            # Validate fight structure
            if 'fightNumber' not in fight:
                errors.append(f"Fight {fight_num}: missing fightNumber")
            elif fight['fightNumber'] != fight_num:
                warnings.append(f"Fight {fight_num}: fightNumber mismatch")

            # Validate enemies
            if 'enemies' not in fight:
                errors.append(f"Fight {fight_num}: missing enemies array")
                continue

            enemies = fight['enemies']
            if not isinstance(enemies, list):
                errors.append(f"Fight {fight_num}: enemies must be array")
                continue

            if is_custom:
                # Custom levels should have proper enemy data
                for j, enemy in enumerate(enemies):
                    enemy_errors, enemy_warnings = self._validate_enemy(enemy, fight_num, j + 1)
                    errors.extend(enemy_errors)
                    warnings.extend(enemy_warnings)
            else:
                # Procedural levels may have empty enemy data
                if all(e.get('character') == '' for e in enemies):
                    # This is expected for procedural levels
                    pass
                else:
                    warnings.append(f"Fight {fight_num}: Procedural level has non-empty enemy data")

            # Validate fight value
            if 'valueOfFight' in fight:
                value = fight['valueOfFight']
                if is_custom and (not isinstance(value, (int, float)) or value <= 0):
                    errors.append(f"Fight {fight_num}: valueOfFight must be positive, got {value}")
                elif value > 1000:
                    warnings.append(f"Fight {fight_num}: Very high valueOfFight: {value}")

            # Validate structure references
            if fight.get('structure') and fight.get('structureGuid'):
                structure_name = fight['structure']
                # Remove .asset extension for comparison
                clean_structure_name = structure_name.replace('.asset', '')
                if clean_structure_name not in self.structures_catalog.get('structures', []):
                    warnings.append(f"Fight {fight_num}: Unknown structure {structure_name}")

        # Check fight progression
        if is_custom:
            fight_values = [f.get('valueOfFight', 0) for f in fights]
            if fight_values and fight_values != sorted(fight_values):
                suggestions.append("Consider increasing fight values progressively")

        return errors, warnings, suggestions

    def _validate_enemy(self, enemy: Dict[str, Any], fight_num: int, enemy_num: int) -> Tuple[List[str], List[str]]:
        """Validate individual enemy configuration."""
        errors = []
        warnings = []

        enemy_id = f"Fight {fight_num}, Enemy {enemy_num}"

        # Check required fields
        if 'character' not in enemy:
            errors.append(f"{enemy_id}: missing character")
            return errors, warnings

        character = enemy['character']
        if character and character not in self.enemies_catalog.get('enemies', []):
            warnings.append(f"{enemy_id}: Unknown enemy type {character}")

        # Validate spawn delay
        if 'delay' in enemy:
            delay = enemy['delay']
            if not isinstance(delay, (int, float)) or delay < 0:
                errors.append(f"{enemy_id}: delay must be non-negative, got {delay}")
            elif delay > 60:
                warnings.append(f"{enemy_id}: Very long spawn delay: {delay}s")

        # Validate level
        if 'level' in enemy:
            level = enemy['level']
            if not isinstance(level, int) or level < 0:
                warnings.append(f"{enemy_id}: Invalid enemy level: {level}")

        # Validate beast flag
        if 'isBeast' in enemy and enemy['isBeast'] not in [0, 1]:
            errors.append(f"{enemy_id}: isBeast must be 0 or 1")

        return errors, warnings

    def _validate_economy(self, level_data: Dict[str, Any]) -> Tuple[List[str], List[str], List[str]]:
        """Validate economic balance and gear systems."""
        errors = []
        warnings = []
        suggestions = []

        settings = level_data.get('levelSettings', {})
        fights = level_data.get('fights', [])
        gear_collections = level_data.get('gearStoreCollections', [])

        # Check if fights is actually a list
        if not isinstance(fights, list):
            errors.append("fights must be an array")
            fights = []  # Reset to empty list to prevent further errors

        # Check starting coins vs fight requirements
        starting_coins = settings.get('startingCoins', 0)
        total_fight_value = sum(f.get('valueOfFight', 0) for f in fights if isinstance(f, dict))

        if starting_coins == 0 and total_fight_value > 0:
            warnings.append("No starting coins but fights have value")
        elif starting_coins > total_fight_value * 2:
            suggestions.append("Starting coins might be too high compared to fight values")

        # Validate gear store collections
        if settings.get('useCustomGears', 0) == 1:
            if not gear_collections:
                warnings.append("Custom gears enabled but no gear collections defined")
            else:
                # Check gear collection structure
                for i, collection in enumerate(gear_collections):
                    if not isinstance(collection, list):
                        errors.append(f"Gear collection {i+1} must be an array")
                        continue

                    for j, gear in enumerate(collection):
                        if not isinstance(gear, dict):
                            errors.append(f"Gear collection {i+1}, item {j+1} must be object")
                        elif 'name' not in gear or 'guid' not in gear:
                            errors.append(f"Gear collection {i+1}, item {j+1} missing name or guid")

        # Check NIV settings balance
        niv_settings = settings.get('nivSettings', {})
        if niv_settings.get('use_level_value', 0) == 1:
            if 'level_niv_max' in niv_settings and 'level_niv_min' in niv_settings:
                max_niv = niv_settings['level_niv_max']
                min_niv = niv_settings['level_niv_min']
                if max_niv < min_niv:
                    errors.append("NIV max cannot be less than NIV min")

        return errors, warnings, suggestions

    def _validate_procedural_custom(self, level_data: Dict[str, Any]) -> Tuple[List[str], List[str]]:
        """Validate procedural vs custom level configuration."""
        errors = []
        warnings = []

        settings = level_data.get('levelSettings', {})
        use_custom_fights = settings.get('useCustomFights', 0)
        use_custom_gears = settings.get('useCustomGears', 0)

        fights = level_data.get('fights', [])
        gear_collections = level_data.get('gearStoreCollections', [])

        if use_custom_fights == 1:
            # Custom level should have complete fight data
            if not fights:
                errors.append("Custom fights enabled but no fights defined")
            else:
                for i, fight in enumerate(fights):
                    enemies = fight.get('enemies', [])
                    if not enemies or all(e.get('character') == '' for e in enemies):
                        warnings.append(f"Custom fight {i+1} has no enemy data")
        else:
            # Procedural level - check for proper procedural settings
            if 'numLevels' not in settings:
                warnings.append("Procedural level missing numLevels setting")
            elif settings['numLevels'] == 0:
                warnings.append("Procedural level has numLevels = 0")

        if use_custom_gears == 1:
            if not gear_collections:
                warnings.append("Custom gears enabled but no gear collections")

        return errors, warnings

    def _validate_references(self, level_data: Dict[str, Any]) -> Tuple[List[str], List[str]]:
        """Validate GUID references and cross-references."""
        errors = []
        warnings = []

        guid_map = self.guid_mappings.get('sample', {}) if self.guid_mappings else {}

        # Validate level GUID
        level_guid = level_data.get('guid')
        if level_guid and level_guid in guid_map:
            expected_name = f"World {level_data['worldNumber']} - Level {level_data['levelInWorld']}.asset"
            actual_name = guid_map[level_guid]
            if expected_name not in actual_name:
                warnings.append(f"GUID mapping mismatch: expected {expected_name}, got {actual_name}")

        # Validate enemy GUIDs
        fights = level_data.get('fights', [])
        if isinstance(fights, list):
            for fight in fights:
                if not isinstance(fight, dict):
                    continue
                enemies = fight.get('enemies', [])
                if not isinstance(enemies, list):
                    continue
                for enemy in enemies:
                    if not isinstance(enemy, dict):
                        continue
                    char_guid = enemy.get('characterGuid')
                    if char_guid and char_guid in guid_map:
                        mapped_name = guid_map[char_guid]
                        expected_char = enemy.get('character', '')
                        if expected_char and expected_char not in mapped_name:
                            warnings.append(f"Enemy GUID mismatch: {expected_char} -> {mapped_name}")

        return errors, warnings

    def _calculate_solvability_score(self, level_data: Dict[str, Any], errors: List[str], warnings: List[str]) -> float:
        """Calculate a solvability score (0-100) for the level."""
        base_score = 100.0

        # Deduct for errors (more severe)
        base_score -= len(errors) * 20

        # Deduct for warnings (less severe)
        base_score -= len(warnings) * 5

        # Bonus for proper configuration
        settings = level_data.get('levelSettings', {})

        # Bonus for having proper economic balance
        starting_coins = settings.get('startingCoins', 0)
        if 10 <= starting_coins <= 100:
            base_score += 5

        # Bonus for having proper fight count
        fight_count = len(level_data.get('fights', []))
        if 3 <= fight_count <= 8:
            base_score += 5

        # Bonus for custom levels with complete data
        if settings.get('useCustomFights', 0) == 1:
            fights = level_data.get('fights', [])
            if all(any(e.get('character') for e in f.get('enemies', [])) for f in fights):
                base_score += 10

        return max(0.0, min(100.0, base_score))

    def validate_all_levels(self) -> ValidationSummary:
        """Validate all levels in the project."""
        results = []

        for level_id, level_data in self.all_levels.items():
            result = self.validate_level(level_data)
            results.append(result)

        # Calculate summary statistics
        total_levels = len(results)
        valid_levels = sum(1 for r in results if r.is_valid)
        invalid_levels = total_levels - valid_levels
        total_errors = sum(len(r.errors) for r in results)
        total_warnings = sum(len(r.warnings) for r in results)
        average_solvability = sum(r.solvability_score for r in results) / total_levels if total_levels > 0 else 0

        return ValidationSummary(
            total_levels=total_levels,
            valid_levels=valid_levels,
            invalid_levels=invalid_levels,
            total_errors=total_errors,
            total_warnings=total_warnings,
            average_solvability=average_solvability,
            results=results,
            timestamp=datetime.now().isoformat()
        )

    def validate_world(self, world_number: int) -> List[ValidationResult]:
        """Validate all levels in a specific world."""
        results = []

        for level_id, level_data in self.all_levels.items():
            if level_data.get('worldNumber') == world_number:
                result = self.validate_level(level_data)
                results.append(result)

        return results

    def validate_single_level(self, world: int, level: int) -> Optional[ValidationResult]:
        """Validate a single level by world and level number."""
        level_id = f"{world}_{level}"

        if level_id not in self.all_levels:
            return None

        return self.validate_level(self.all_levels[level_id])

def main():
    """Command line interface for level validation."""
    parser = argparse.ArgumentParser(description="Validate Gear Fight level data")
    parser.add_argument('--all', action='store_true', help='Validate all levels')
    parser.add_argument('--level', help='Validate specific level (format: world_level, e.g., 1_1)')
    parser.add_argument('--world', type=int, help='Validate all levels in specific world')
    parser.add_argument('--output', help='Output file for validation report (JSON format)')
    parser.add_argument('--verbose', '-v', action='store_true', help='Verbose output')
    parser.add_argument('--path', default='.', help='Base path to game data')

    args = parser.parse_args()

    # Create validator
    validator = LevelValidator(args.path)

    if not validator.all_levels:
        print("Error: No level data found. Check that LevelJsonData directory exists.")
        sys.exit(1)

    # Determine what to validate
    results = None
    summary = None

    if args.all:
        print("Validating all levels...")
        summary = validator.validate_all_levels()
        results = summary.results

    elif args.world:
        print(f"Validating world {args.world}...")
        results = validator.validate_world(args.world)

    elif args.level:
        parts = args.level.split('_')
        if len(parts) != 2:
            print("Error: Level format should be 'world_level' (e.g., '1_1')")
            sys.exit(1)

        try:
            world, level = int(parts[0]), int(parts[1])
        except ValueError:
            print("Error: World and level must be integers")
            sys.exit(1)

        print(f"Validating level {world}-{level}...")
        result = validator.validate_single_level(world, level)
        if result:
            results = [result]
        else:
            print(f"Error: Level {world}-{level} not found")
            sys.exit(1)

    else:
        parser.print_help()
        sys.exit(1)

    # Output results
    if results:
        # Console output
        valid_count = sum(1 for r in results if r.is_valid)
        invalid_count = len(results) - valid_count

        print(f"\n=== Validation Results ===")
        print(f"Total levels: {len(results)}")
        print(f"Valid: {valid_count}")
        print(f"Invalid: {invalid_count}")

        if summary:
            print(f"Average solvability score: {summary.average_solvability:.1f}")

        # Show detailed results if verbose or single level
        if args.verbose or len(results) == 1:
            for result in results:
                print(f"\n--- Level {result.level_id} ---")
                print(f"Status: {'VALID' if result.is_valid else 'INVALID'}")
                print(f"Solvability Score: {result.solvability_score:.1f}")

                if result.errors:
                    print("ERRORS:")
                    for error in result.errors:
                        print(f"  ❌ {error}")

                if result.warnings:
                    print("WARNINGS:")
                    for warning in result.warnings:
                        print(f"  ⚠️  {warning}")

                if result.suggestions:
                    print("SUGGESTIONS:")
                    for suggestion in result.suggestions:
                        print(f"  💡 {suggestion}")

        else:
            # Summary for multiple levels
            print(f"\nLevels with errors:")
            for result in results:
                if result.errors:
                    print(f"  {result.level_id}: {len(result.errors)} errors, {len(result.warnings)} warnings")

        # Save JSON report if requested
        if args.output:
            output_data = summary if summary else {
                'results': [asdict(r) for r in results],
                'timestamp': datetime.now().isoformat()
            }

            with open(args.output, 'w', encoding='utf-8') as f:
                json.dump(asdict(output_data) if summary else output_data, f, indent=2, ensure_ascii=False)

            print(f"\nDetailed report saved to: {args.output}")

    # Exit with appropriate code
    if results and any(not r.is_valid for r in results):
        sys.exit(1)

if __name__ == "__main__":
    main()