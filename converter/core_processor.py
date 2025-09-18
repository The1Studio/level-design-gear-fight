#!/usr/bin/env python3
"""
Core processor - Central orchestrator for all extraction tasks
"""

import json
import time
import sys
from pathlib import Path

# Add current directory to path for imports
sys.path.insert(0, str(Path(__file__).parent))

from concurrent.futures import ThreadPoolExecutor, as_completed

from constants.unity_guids import UnityGUIDManager
from extractors.enemy_extractor import EnemyExtractor
from extractors.structure_extractor import StructureExtractor
from extractors.level_extractor import LevelExtractor
from extractors.gear_extractor import GearExtractor

class CoreProcessor:
    """Central orchestrator for all game data extraction"""
    
    def __init__(self, unity_project_path, output_directory=None):
        self.unity_path = Path(unity_project_path)
        self.output_dir = Path(output_directory) if output_directory else Path('..')
        
        # Initialize GUID manager
        guid_path = self.output_dir / 'guid_mappings.json'
        self.guid_manager = UnityGUIDManager(guid_path if guid_path.exists() else None)
        
        # Initialize extractors
        self.enemy_extractor = EnemyExtractor(self.unity_path, self.guid_manager)
        self.structure_extractor = StructureExtractor(self.unity_path, self.guid_manager)
        self.level_extractor = LevelExtractor(self.unity_path, self.guid_manager)
        self.gear_extractor = GearExtractor(self.unity_path, self.guid_manager)
        
        print(f"🚀 Core Processor initialized")
        print(f"   Unity path: {self.unity_path}")
        print(f"   Output directory: {self.output_dir}")
        print(f"   GUID mappings loaded: {len(self.guid_manager.guid_mappings)}")
    
    def extract_all_data(self, parallel=True):
        """Extract all game data using parallel processing"""
        print("\n🔍 STARTING COMPREHENSIVE GAME DATA EXTRACTION")
        print("=" * 60)
        
        start_time = time.time()
        results = {}
        
        if parallel:
            results = self._extract_parallel()
        else:
            results = self._extract_sequential()
        
        # Generate combined statistics
        combined_stats = self._generate_combined_statistics(results)
        results['combined_statistics'] = combined_stats
        
        elapsed_time = time.time() - start_time
        print(f"\n✅ EXTRACTION COMPLETE in {elapsed_time:.2f} seconds")
        
        return results
    
    def _extract_parallel(self):
        """Extract data using parallel processing"""
        results = {}
        
        extraction_tasks = [
            ('enemies', self.enemy_extractor.extract_all_enemies),
            ('structures', self.structure_extractor.extract_all_structures),
            ('levels', self.level_extractor.extract_all_levels),
            ('gear', self.gear_extractor.extract_all_gear)
        ]
        
        with ThreadPoolExecutor(max_workers=4) as executor:
            # Submit all tasks
            future_to_name = {
                executor.submit(task_func): task_name 
                for task_name, task_func in extraction_tasks
            }
            
            # Collect results as they complete
            for future in as_completed(future_to_name):
                task_name = future_to_name[future]
                try:
                    result = future.result()
                    results[task_name] = result
                    print(f"✅ {task_name.capitalize()} extraction completed")
                except Exception as e:
                    print(f"❌ Error in {task_name} extraction: {e}")
                    results[task_name] = None
        
        return results
    
    def _extract_sequential(self):
        """Extract data sequentially"""
        results = {}
        
        print("\n📊 Extracting enemies...")
        results['enemies'] = self.enemy_extractor.extract_all_enemies()
        
        print("\n🏗️ Extracting structures...")
        results['structures'] = self.structure_extractor.extract_all_structures()
        
        print("\n📋 Extracting levels...")
        results['levels'] = self.level_extractor.extract_all_levels()
        
        print("\n⚙️ Extracting gear...")
        results['gear'] = self.gear_extractor.extract_all_gear()
        
        return results
    
    def extract_enemies_only(self):
        """Extract only enemy data"""
        print("\n🔍 EXTRACTING ENEMIES ONLY")
        return self.enemy_extractor.extract_all_enemies()
    
    def extract_structures_only(self):
        """Extract only structure data"""
        print("\n🏗️ EXTRACTING STRUCTURES ONLY")
        return self.structure_extractor.extract_all_structures()
    
    def extract_levels_only(self):
        """Extract only level data"""
        print("\n📋 EXTRACTING LEVELS ONLY")
        return self.level_extractor.extract_all_levels()
    
    def extract_gear_only(self):
        """Extract only gear data"""
        print("\n⚙️ EXTRACTING GEAR ONLY")
        return self.gear_extractor.extract_all_gear()
    
    def _generate_combined_statistics(self, results):
        """Generate overall statistics from all extraction results"""
        stats = {
            'extraction_timestamp': time.time(),
            'unity_project_path': str(self.unity_path),
            'total_assets_found': 0,
            'successful_extractions': 0,
            'failed_extractions': 0
        }
        
        for category, data in results.items():
            if data and isinstance(data, dict) and 'extraction_info' in data:
                info = data['extraction_info']
                stats['total_assets_found'] += info.get('total_files_scanned', 0)
                if info.get('total_enemies_found', 0) > 0 or \
                   info.get('total_structures_found', 0) > 0 or \
                   info.get('total_levels_found', 0) > 0 or \
                   info.get('total_gear_found', 0) > 0:
                    stats['successful_extractions'] += 1
                else:
                    stats['failed_extractions'] += 1
        
        return stats
    
    def save_all_data(self, extraction_results, save_individual=True):
        """Save all extracted data to appropriate files"""
        print("\n💾 SAVING EXTRACTED DATA")
        print("-" * 30)
        
        saved_files = []
        
        if save_individual:
            # Save individual catalogs
            if extraction_results.get('enemies'):
                enemies_path = self.output_dir / 'enemies_catalog.json'
                self.enemy_extractor.save_enemies_catalog(enemies_path, extraction_results['enemies'])
                saved_files.append(str(enemies_path))
            
            if extraction_results.get('structures'):
                structures_path = self.output_dir / 'structures_catalog.json'
                self.structure_extractor.save_structures_catalog(structures_path, extraction_results['structures'])
                saved_files.append(str(structures_path))
            
            if extraction_results.get('levels'):
                levels_path = self.output_dir / 'levels_data.json'
                self.level_extractor.save_levels_data(levels_path, extraction_results['levels'])
                saved_files.append(str(levels_path))
            
            if extraction_results.get('gear'):
                gear_path = self.output_dir / 'gear_catalog.json'
                self.gear_extractor.save_gear_catalog(gear_path, extraction_results['gear'])
                saved_files.append(str(gear_path))
        
        # Save complete combined data
        complete_path = self.output_dir / 'complete_game_data.json'
        try:
            with open(complete_path, 'w') as f:
                json.dump(extraction_results, f, indent=2)
            
            print(f"✅ Saved complete game data to {complete_path}")
            saved_files.append(str(complete_path))
            
        except Exception as e:
            print(f"❌ Error saving complete data: {e}")
        
        print(f"\n📄 Saved {len(saved_files)} files:")
        for file_path in saved_files:
            print(f"   - {file_path}")
        
        return saved_files
    
    def generate_discovery_report(self, extraction_results):
        """Generate a comprehensive discovery report"""
        report = {
            'discovery_summary': {
                'timestamp': time.time(),
                'total_mechanics_discovered': 0,
                'critical_findings': []
            }
        }
        
        # Analyze enemies
        if extraction_results.get('enemies'):
            enemies_data = extraction_results['enemies']
            enemy_count = len(enemies_data.get('enemies', {}))
            missing_enemies = enemies_data.get('extraction_info', {}).get('missing_expected', [])
            
            report['discovery_summary']['total_mechanics_discovered'] += enemy_count
            
            if missing_enemies:
                report['discovery_summary']['critical_findings'].append(
                    f"Missing {len(missing_enemies)} expected enemies: {missing_enemies}"
                )
            else:
                report['discovery_summary']['critical_findings'].append(
                    f"✅ All expected enemies found! ({enemy_count} total)"
                )
        
        # Analyze structures
        if extraction_results.get('structures'):
            structures_data = extraction_results['structures']
            structure_count = len(structures_data.get('structures', {}))
            env_count = len(structures_data.get('environment_types', {}))
            
            report['discovery_summary']['total_mechanics_discovered'] += structure_count
            
            report['discovery_summary']['critical_findings'].append(
                f"Found {structure_count} structures across {env_count} environments"
            )
        
        return report
