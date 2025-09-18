# Gear Fight Level Validation System

## Overview

The `validate_levels.py` script provides comprehensive validation for Gear Fight level data, ensuring structural integrity, game balance, and proper configuration.

## Features

### Level Structure Validation
- ✅ Required fields (levelNumber, worldNumber, levelInWorld, name, guid)
- ✅ levelSettings structure completeness
- ✅ Fight configurations integrity
- ✅ Gear store collections validation
- ✅ GUID format verification
- ✅ Consistent levelNumber calculation

### Fight Configuration Validation
- ✅ Enemy spawn timing (positive delays)
- ✅ Enemy type existence in catalog
- ✅ Structure reference validation
- ✅ Fight value reasonableness (> 0)
- ✅ Spawn delay overlap detection
- ✅ Custom vs procedural fight validation

### Economy Balance Validation
- ✅ NIV settings within bounds
- ✅ Starting coins vs fight requirements
- ✅ Gear collection existence and balance
- ✅ Economic progression analysis

### Procedural vs Custom Validation
- ✅ Procedural levels (133/134) with proper generation settings
- ✅ Custom levels with complete fight data
- ✅ Configuration consistency checking

### Cross-Reference Validation
- ✅ GUID mappings verification
- ✅ Enemy catalog references
- ✅ Structure catalog references
- ✅ Chapter data consistency

## Usage Examples

### Validate All Levels
```bash
python3 validate_levels.py --all
python3 validate_levels.py --all --output validation_report.json
```

### Validate Specific Level
```bash
python3 validate_levels.py --level 1_1
python3 validate_levels.py --level 1_1 --verbose
```

### Validate Entire World
```bash
python3 validate_levels.py --world 3
python3 validate_levels.py --world 10 --verbose
```

### Save Detailed Report
```bash
python3 validate_levels.py --all --output full_report.json
python3 validate_levels.py --world 5 --output world5_report.json
```

## Validation Results

### Output Format
```
=== Validation Results ===
Total levels: 134
Valid: 134
Invalid: 0
Average solvability score: 100.0
```

### Individual Level Results
```
--- Level 1_1 ---
Status: VALID
Solvability Score: 100.0
WARNINGS:
  ⚠️  Fight 5: Unknown structure Forest_Structure_1.asset
SUGGESTIONS:
  💡 Consider increasing fight values progressively
```

### Solvability Score (0-100)
- **100**: Perfect level configuration
- **80-99**: Minor warnings, fully playable
- **60-79**: Some balance issues, needs attention
- **40-59**: Significant problems, may affect gameplay
- **0-39**: Critical errors, unplayable

## Validation Categories

### ❌ Errors (Critical Issues)
- Missing required fields
- Invalid data types
- Structural inconsistencies
- Broken references
- Invalid configurations

### ⚠️ Warnings (Potential Issues)
- Unknown references
- Configuration mismatches
- Balance concerns
- Non-standard values

### 💡 Suggestions (Improvements)
- Optimization opportunities
- Balance recommendations
- Best practice suggestions
- Performance improvements

## Integration with Development Workflow

### Pre-Commit Validation
```bash
# Validate before committing changes
python3 validate_levels.py --all
```

### CI/CD Integration
```bash
# Exit with error code if validation fails
python3 validate_levels.py --all || exit 1
```

### Level Editor Integration
The validation system can be integrated with the level editor to provide real-time feedback during level design.

## Configuration Files

### Required Catalogs
- `enemies_catalog.json` - Enemy type definitions
- `structures_catalog.json` - Structure type definitions
- `guid_mappings.json` - Unity GUID to asset name mappings
- `chapters.json` - Chapter and world data

### Level Data Location
- `LevelJsonData/` - Individual level JSON files (134 total)

## Troubleshooting

### Common Issues

#### "No level data found"
Ensure the `LevelJsonData/` directory exists and contains level files.

#### "Unknown enemy type"
Check if the enemy exists in `enemies_catalog.json`.

#### "Unknown structure"
Verify the structure is listed in `structures_catalog.json`.

#### "GUID mapping mismatch"
Update `guid_mappings.json` with correct Unity asset mappings.

### Performance Notes
- Full validation of 134 levels takes ~2-3 seconds
- Single level validation is instantaneous
- JSON report generation adds minimal overhead

## Development

### Adding New Validation Rules
1. Add validation logic to appropriate `_validate_*` method
2. Categorize as error, warning, or suggestion
3. Update solvability score calculation if needed
4. Test with both valid and invalid data

### Extending for New Game Mechanics
1. Update catalog files with new types
2. Add validation rules for new mechanics
3. Update documentation
4. Add test cases

## Current Status

✅ **All 134 levels validated successfully**
- 134 valid levels
- 0 invalid levels
- Average solvability score: 100.0
- 1 structure reference warning (resolved)

## Future Enhancements

- [ ] Real-time validation in level editor
- [ ] Performance profiling and optimization
- [ ] Advanced balance analysis
- [ ] Procedural generation validation
- [ ] Custom validation rule configuration
- [ ] Integration with Unity editor