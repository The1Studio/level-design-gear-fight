#!/usr/bin/env python3
"""
Main converter entry point
Comprehensive Unity → JSON converter for Gear Fight
"""

import argparse
import sys
import time
from pathlib import Path

# Add current directory to Python path for imports
sys.path.insert(0, str(Path(__file__).parent))

from core_processor import CoreProcessor

def main():
    """Main converter entry point"""
    parser = argparse.ArgumentParser(
        description='Comprehensive Unity → JSON converter for Gear Fight',
        formatter_class=argparse.RawDescriptionHelpFormatter,
        epilog="""
Examples:
  python converter.py --all              # Extract everything
  python converter.py --enemies          # Extract only enemies
  python converter.py --structures       # Extract only structures
  python converter.py --levels           # Extract only levels
  python converter.py --gear             # Extract only gear
  python converter.py --parallel         # Use parallel processing
  python converter.py --output ./output  # Specify output directory
        """
    )
    
    # Extraction options
    parser.add_argument('--all', action='store_true',
                       help='Extract all game mechanics (enemies, structures, levels, gear)')
    parser.add_argument('--enemies', action='store_true',
                       help='Extract only enemy/troop definitions')
    parser.add_argument('--structures', action='store_true',
                       help='Extract only structure definitions')
    parser.add_argument('--levels', action='store_true',
                       help='Extract only level configurations')
    parser.add_argument('--gear', action='store_true',
                       help='Extract only gear/equipment definitions')
    
    # Processing options
    parser.add_argument('--parallel', action='store_true',
                       help='Use parallel processing for faster extraction')
    parser.add_argument('--sequential', action='store_true',
                       help='Use sequential processing (default)')
    
    # Path options
    parser.add_argument('--unity-path', default='../UnityProject',
                       help='Path to Unity project directory (default: ../UnityProject)')
    parser.add_argument('--output', default='..',
                       help='Output directory for generated files (default: ..)')
    
    # Utility options
    parser.add_argument('--report', action='store_true',
                       help='Generate detailed discovery report')
    parser.add_argument('--verbose', '-v', action='store_true',
                       help='Verbose output')
    
    args = parser.parse_args()
    
    # Validate arguments
    if not any([args.all, args.enemies, args.structures, args.levels, args.gear]):
        print("❌ Error: Must specify what to extract (--all, --enemies, --structures, --levels, or --gear)")
        parser.print_help()
        return 1
    
    # Initialize core processor
    try:
        processor = CoreProcessor(args.unity_path, args.output)
    except Exception as e:
        print(f"❌ Error initializing converter: {e}")
        return 1
    
    # Determine processing mode
    use_parallel = args.parallel or (not args.sequential)
    
    # Execute extraction based on arguments
    try:
        if args.all:
            print("🚀 Starting comprehensive extraction of ALL game mechanics...")
            results = processor.extract_all_data(parallel=use_parallel)
            
            # Save all data
            saved_files = processor.save_all_data(results, save_individual=True)
            
            # Print comprehensive summary
            print_extraction_summary(results)
            
            if args.report:
                report = processor.generate_discovery_report(results)
                print_discovery_report(report)
        
        elif args.enemies:
            print("🔍 Extracting enemy/troop definitions...")
            results = processor.extract_enemies_only()
            output_path = Path(args.output) / 'enemies_catalog.json'
            processor.enemy_extractor.save_enemies_catalog(output_path, results)
            print_enemies_summary(results)
        
        elif args.structures:
            print("🏗️ Extracting structure definitions...")
            results = processor.extract_structures_only()
            output_path = Path(args.output) / 'structures_catalog.json'
            processor.structure_extractor.save_structures_catalog(output_path, results)
            print_structures_summary(results)
        
        elif args.levels:
            print("📋 Extracting level configurations...")
            results = processor.extract_levels_only()
            output_path = Path(args.output) / 'levels_data.json'
            processor.level_extractor.save_levels_data(output_path, results)
            print_levels_summary(results)
        
        elif args.gear:
            print("⚙️ Extracting gear/equipment definitions...")
            results = processor.extract_gear_only()
            output_path = Path(args.output) / 'gear_catalog.json'
            processor.gear_extractor.save_gear_catalog(output_path, results)
            print_gear_summary(results)
        
        print("\n✅ EXTRACTION COMPLETED SUCCESSFULLY!")
        return 0
        
    except Exception as e:
        print(f"❌ Error during extraction: {e}")
        if args.verbose:
            import traceback
            traceback.print_exc()
        return 1

def print_extraction_summary(results):
    """Print comprehensive summary of all extracted data"""
    print("\n" + "="*60)
    print("📊 COMPREHENSIVE EXTRACTION SUMMARY")
    print("="*60)
    
    if results.get('enemies'):
        enemies = results['enemies']
        print(f"\n🔥 ENEMIES: {len(enemies.get('enemies', {}))} found")
        print(f"   Categories: {list(enemies.get('categories', {}).keys())}")
        
        missing = enemies.get('extraction_info', {}).get('missing_expected', [])
        if missing:
            print(f"   ⚠️ Missing expected: {missing}")
        else:
            print("   ✅ All expected enemies found!")
    
    if results.get('structures'):
        structures = results['structures']
        print(f"\n🏗️ STRUCTURES: {len(structures.get('structures', {}))} found")
        print(f"   Environments: {list(structures.get('environment_types', {}).keys())}")
    
    if results.get('levels'):
        levels = results['levels']
        print(f"\n📋 LEVELS: {len(levels.get('levels', {}))} found")
        print(f"   Worlds: {len(levels.get('worlds', {}))}")
    
    if results.get('gear'):
        gear = results['gear']
        print(f"\n⚙️ GEAR: {len(gear.get('gear', {}))} found")
    
    # Show combined statistics if available
    if results.get('combined_statistics'):
        stats = results['combined_statistics']
        print(f"\n📈 OVERALL STATISTICS:")
        print(f"   Total assets scanned: {stats.get('total_assets_found', 0)}")
        print(f"   Successful extractions: {stats.get('successful_extractions', 0)}")
        print(f"   Failed extractions: {stats.get('failed_extractions', 0)}")

def print_enemies_summary(results):
    """Print summary of enemy extraction"""
    print(f"\n📊 Enemy Extraction Summary:")
    print(f"   Total enemies: {len(results.get('enemies', {}))}")
    print(f"   Categories: {list(results.get('categories', {}).keys())}")
    
    stats = results.get('statistics', {})
    print(f"   Level generation included: {stats.get('level_generation_included', 0)}")
    print(f"   Evolution chains: {stats.get('evolution_chains', 0)}")

def print_structures_summary(results):
    """Print summary of structure extraction"""
    print(f"\n📊 Structure Extraction Summary:")
    print(f"   Total structures: {len(results.get('structures', {}))}")
    print(f"   Environment types: {list(results.get('environment_types', {}).keys())}")

def print_levels_summary(results):
    """Print summary of level extraction"""
    print(f"\n📊 Level Extraction Summary:")
    print(f"   Total levels: {len(results.get('levels', {}))}")
    print(f"   Worlds: {len(results.get('worlds', {}))}")

def print_gear_summary(results):
    """Print summary of gear extraction"""
    print(f"\n📊 Gear Extraction Summary:")
    print(f"   Total gear: {len(results.get('gear', {}))}")

def print_discovery_report(report):
    """Print detailed discovery report"""
    print("\n" + "="*60)
    print("🔍 MECHANIC DISCOVERY REPORT")
    print("="*60)
    
    summary = report.get('discovery_summary', {})
    print(f"Total mechanics discovered: {summary.get('total_mechanics_discovered', 0)}")
    
    print("\nCritical findings:")
    for finding in summary.get('critical_findings', []):
        print(f"   • {finding}")

if __name__ == '__main__':
    exit_code = main()
    sys.exit(exit_code)
