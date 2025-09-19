#!/usr/bin/env python3
"""
Template Data Extractor for Level 2+ Data
Extracts template configuration information from procedural levels
"""

import re
import json
import yaml
from pathlib import Path

def parse_unity_yaml_simple(file_path):
    """Simple Unity YAML parser for template data extraction."""
    with open(file_path, 'r') as f:
        content = f.read()

    # Clean Unity-specific YAML syntax
    content = re.sub(r'<([^>]+)>k__BackingField:', r'\1:', content)
    content = re.sub(r'%YAML.*\n', '', content)
    content = re.sub(r'%TAG.*\n', '', content)
    content = re.sub(r'--- !u!\d+ &\d+\n', '', content)

    # Extract MonoBehaviour section manually
    mono_match = re.search(r'MonoBehaviour:(.*)', content, re.DOTALL)
    if not mono_match:
        return None

    mono_content = mono_match.group(1).strip()

    # Simple key-value parsing
    data = {}
    lines = mono_content.split('\n')

    for line in lines:
        line = line.strip()
        if ':' in line and not line.startswith('-'):
            key, value = line.split(':', 1)
            key = key.strip()
            value = value.strip()

            # Basic type conversion
            if value.isdigit():
                data[key] = int(value)
            elif value == 'true':
                data[key] = True
            elif value == 'false':
                data[key] = False
            else:
                data[key] = value

    return data

def extract_level_template(level_file):
    """Extract template configuration from a level file."""
    try:
        # Read and parse the Unity file
        with open(level_file, 'r') as f:
            content = f.read()

        template_info = {
            'level_name': level_file.name.replace('.asset', ''),
            'file_path': str(level_file),
            'is_procedural': False,
            'fight_template': {},
            'structure_pool': [],
            'economic_template': {},
            'raw_findings': []
        }

        # Check if procedural
        if 'DoUseCustomFights>k__BackingField: 0' in content:
            template_info['is_procedural'] = True

        # Extract fight template structure
        fight_match = re.search(r'allFights:(.*?)allStructures:', content, re.DOTALL)
        if fight_match:
            fight_section = fight_match.group(1)

            # Count enemy slots
            enemy_slots = fight_section.count('Character>k__BackingField: {fileID: 0}')
            placeholder_slots = fight_section.count('{fileID: 0}')

            template_info['fight_template'] = {
                'enemy_slots': enemy_slots,
                'placeholder_slots': placeholder_slots,
                'template_purpose': f'Defines {enemy_slots} enemy positions for procedural generation'
            }

            template_info['raw_findings'].append(f'Found {enemy_slots} enemy template slots')

        # Extract structure pool
        structures_match = re.search(r'allStructures:(.*?)StartingCoins', content, re.DOTALL)
        if structures_match:
            structures_section = structures_match.group(1)
            structure_guids = re.findall(r'guid: ([a-f0-9]{32})', structures_section)

            template_info['structure_pool'] = [
                {'guid': guid, 'purpose': 'Available for procedural selection'}
                for guid in structure_guids
            ]

            template_info['raw_findings'].append(f'Found {len(structure_guids)} structures in pool')

        # Extract economic parameters
        coins_match = re.search(r'StartingCoins>k__BackingField: (\d+)', content)
        spinners_match = re.search(r'NumberOfSpinners>k__BackingField: (\d+)', content)
        levels_match = re.search(r'numLevels: (\d+)', content)

        template_info['economic_template'] = {
            'starting_coins': int(coins_match.group(1)) if coins_match else 0,
            'number_of_spinners': int(spinners_match.group(1)) if spinners_match else 0,
            'num_levels_param': int(levels_match.group(1)) if levels_match else 0
        }

        # Extract difficulty profile
        difficulty_match = re.search(r'difficultyProfile: \{fileID: 11400000, guid: ([a-f0-9]{32})', content)
        if difficulty_match:
            template_info['economic_template']['difficulty_profile_guid'] = difficulty_match.group(1)

        return template_info

    except Exception as e:
        return {'error': str(e), 'level_name': level_file.name}

def main():
    """Extract template data from all levels."""
    print("=== TEMPLATE DATA EXTRACTION ===")
    print("Extracting template configurations from procedural levels...")
    print()

    unity_dir = Path("UnityProject/MonoBehaviour")
    level_files = list(unity_dir.glob("World*Level*.asset"))

    all_templates = {
        'extraction_info': {
            'total_levels': len(level_files),
            'procedural_levels': 0,
            'custom_levels': 0
        },
        'templates': {}
    }

    # Extract Level 2 specifically first
    level_2_file = unity_dir / "World 1 - Level 2.asset"
    if level_2_file.exists():
        print("🎯 ANALYZING LEVEL 2 TEMPLATE DATA:")
        template = extract_level_template(level_2_file)
        all_templates['templates']['World 1 - Level 2'] = template

        if template.get('is_procedural'):
            print(f"✅ Level 2 is procedural with rich template data:")
            print(f"   - Enemy Slots: {template['fight_template']['enemy_slots']}")
            print(f"   - Structure Pool: {len(template['structure_pool'])} types")
            print(f"   - Starting Coins: {template['economic_template']['starting_coins']}")
            print(f"   - Spinners: {template['economic_template']['number_of_spinners']}")
            for finding in template['raw_findings']:
                print(f"   - {finding}")
            print()

        all_templates['extraction_info']['procedural_levels'] += 1

    # Extract a few more levels for comparison
    sample_levels = [
        "World 1 - Level 3.asset",
        "World 1 - Level 4.asset",
        "World 2 - Level 1.asset",
        "World 5 - Level 10.asset"
    ]

    print("📊 SAMPLING OTHER LEVELS:")
    for level_name in sample_levels:
        level_file = unity_dir / level_name
        if level_file.exists():
            template = extract_level_template(level_file)
            all_templates['templates'][level_name.replace('.asset', '')] = template

            if template.get('is_procedural'):
                print(f"   {level_name}: {template['fight_template']['enemy_slots']} slots, {len(template['structure_pool'])} structures")
                all_templates['extraction_info']['procedural_levels'] += 1
            else:
                all_templates['extraction_info']['custom_levels'] += 1

    # Save results
    output_file = "level_template_configurations.json"
    with open(output_file, 'w') as f:
        json.dump(all_templates, f, indent=2)

    print()
    print(f"📁 Template data saved to: {output_file}")
    print(f"🎯 KEY FINDING: Level 2+ data exists as template configurations!")
    print(f"   - Procedural levels have sophisticated template systems")
    print(f"   - Templates define enemy slots, structure pools, economic params")
    print(f"   - Current level editor needs to show template info, not expect filled data")

    return all_templates

if __name__ == "__main__":
    main()