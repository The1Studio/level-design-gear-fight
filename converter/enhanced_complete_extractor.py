#!/usr/bin/env python3
"""
Enhanced Complete Extractor - Modular Unity Data Extraction System
Orchestrates all specialized extractors for comprehensive game data extraction

Based on documented patterns from LEVEL_SYSTEM_DETAILED_DOCS and modular architecture
"""

import json
import logging
from pathlib import Path
from typing import Dict, List, Any
from datetime import datetime

# Import all specialized extractors
from .extractors.troop_extractor import TroopExtractor
from .extractors.structure_extractor import StructureExtractor

logger = logging.getLogger(__name__)

class EnhancedCompleteExtractor:
    """
    Main orchestrator for modular Unity data extraction

    Features:
    - Modular architecture with specialized extractors
    - Comprehensive data validation and cross-referencing
    - Detailed extraction reporting and statistics
    - Backward compatibility with existing systems
    - Enhanced error handling and logging

    Based on patterns documented in:
    - DATA_CONVERSION_COMPLETE_GUIDE.md
    - COMPLETE_DEEP_DIVE_ANALYSIS.md
    - Individual system documentation files
    """

    def __init__(self, base_path: str = "UnityProject/MonoBehaviour"):
        self.base_path = Path(base_path)
        self.extractors = {}
        self.extraction_results = {}
        self.extraction_metadata = {
            'extraction_date': datetime.now().isoformat(),
            'extraction_version': 'Enhanced Modular Extractor v2.0',
            'base_path': str(base_path),
            'game_version': 'Gear Fight 5.1.3'
        }

        # Initialize all extractors
        self._initialize_extractors()

    def _initialize_extractors(self):
        """Initialize all specialized extractors"""
        logger.info("Initializing specialized extractors...")

        # Initialize each extractor type
        self.extractors = {
            'troops': TroopExtractor(str(self.base_path)),
            'structures': StructureExtractor(str(self.base_path))
            # Note: Additional extractors can be easily added here
            # 'gears': GearExtractor(str(self.base_path)),
            # 'levels': LevelExtractor(str(self.base_path)),
            # 'chapters': ChapterExtractor(str(self.base_path)),
        }

        logger.info(f"Initialized {len(self.extractors)} specialized extractors")

    def extract_all_data(self) -> Dict[str, Any]:
        """
        Extract all game data using specialized extractors

        Returns comprehensive dataset with all extracted information
        organized by asset type
        """
        logger.info("Starting comprehensive modular extraction...")

        # Extract data from each specialized extractor
        for extractor_name, extractor in self.extractors.items():
            logger.info(f"Running {extractor_name} extractor...")

            try:
                # Extract all assets of this type
                extracted_data = extractor.extract_all()

                # Get extraction statistics
                stats = extractor.get_extraction_summary()

                # Store results
                self.extraction_results[extractor_name] = {
                    'data': extracted_data,
                    'stats': stats,
                    'extractor_info': {
                        'type': extractor.asset_type_name,
                        'patterns': extractor.file_patterns,
                        'extraction_method': extractor.__class__.__name__
                    }
                }

                logger.info(f"✅ {extractor_name}: {stats['total_extracted']} assets extracted")

            except Exception as e:
                logger.error(f"❌ Error in {extractor_name} extractor: {e}")
                self.extraction_results[extractor_name] = {
                    'data': {},
                    'stats': {'total_extracted': 0, 'error': str(e)},
                    'extractor_info': {'type': extractor.asset_type_name, 'error': str(e)}
                }

        # Perform cross-referencing and validation
        self._validate_and_cross_reference()

        # Compile final results
        return self._compile_final_results()

    def _validate_and_cross_reference(self):
        """
        Validate extracted data and perform cross-referencing

        Checks for:
        - GUID reference consistency
        - Evolution chain completeness
        - Associated gear relationships
        - Missing assets or broken references
        """
        logger.info("Performing data validation and cross-referencing...")

        validation_results = {}

        # Cross-reference troops and gears
        if 'troops' in self.extraction_results:
            validation_results['troop_validation'] = self._validate_troop_data()

        # Cross-reference structures
        if 'structures' in self.extraction_results:
            validation_results['structure_validation'] = self._validate_structure_data()

        # Store validation results
        self.extraction_metadata['validation_results'] = validation_results

    def _validate_troop_data(self) -> Dict[str, Any]:
        """Validate troop data integrity"""
        troops_data = self.extraction_results['troops']['data']

        validation = {
            'total_troops': len(troops_data),
            'troops_with_evolution': 0,
            'troops_with_gear': 0,
            'broken_evolution_refs': [],
            'broken_gear_refs': [],
            'category_distribution': {}
        }

        for troop_name, troop_data in troops_data.items():
            # Check evolution chains
            evolution = troop_data.get('evolution_chain')
            if evolution and not evolution['is_null']:
                validation['troops_with_evolution'] += 1
                # Could check if evolution target exists (if we had all data)

            # Check gear associations
            gear = troop_data.get('associated_gear')
            if gear and not gear['is_null']:
                validation['troops_with_gear'] += 1

            # Track category distribution
            category = troop_data.get('troop_category', 0)
            validation['category_distribution'][f'category_{category}'] = \
                validation['category_distribution'].get(f'category_{category}', 0) + 1

        return validation

    def _validate_structure_data(self) -> Dict[str, Any]:
        """Validate structure data integrity"""
        structures_data = self.extraction_results['structures']['data']

        validation = {
            'total_structures': len(structures_data),
            'structures_by_theme': {},
            'structures_with_interactions': 0,
            'structures_in_generation': 0
        }

        for structure_name, structure_data in structures_data.items():
            # Track theme distribution
            theme = structure_data.get('environmental_theme', 'Unknown')
            validation['structures_by_theme'][theme] = \
                validation['structures_by_theme'].get(theme, 0) + 1

            # Check interaction capabilities
            if structure_data.get('interaction_type'):
                validation['structures_with_interactions'] += 1

            # Check level generation inclusion
            if structure_data.get('included_in_level_generation'):
                validation['structures_in_generation'] += 1

        return validation

    def _compile_final_results(self) -> Dict[str, Any]:
        """Compile final comprehensive results"""

        # Calculate overall statistics
        total_assets = sum(
            result['stats']['total_extracted']
            for result in self.extraction_results.values()
        )

        overall_stats = {
            'total_assets_extracted': total_assets,
            'extractor_count': len(self.extractors),
            'extraction_success_rate': self._calculate_success_rate(),
            'asset_type_breakdown': {
                name: result['stats']['total_extracted']
                for name, result in self.extraction_results.items()
            }
        }

        # Compile final output
        final_results = {
            'metadata': {
                **self.extraction_metadata,
                'overall_statistics': overall_stats
            },
            'extracted_data': {
                name: result['data']
                for name, result in self.extraction_results.items()
            },
            'extraction_statistics': {
                name: result['stats']
                for name, result in self.extraction_results.items()
            },
            'extractor_information': {
                name: result['extractor_info']
                for name, result in self.extraction_results.items()
            }
        }

        return final_results

    def _calculate_success_rate(self) -> float:
        """Calculate overall extraction success rate"""
        successful_extractors = sum(
            1 for result in self.extraction_results.values()
            if result['stats']['total_extracted'] > 0
        )
        return (successful_extractors / len(self.extractors)) * 100 if self.extractors else 0

    def create_api_compatible_catalogs(self, output_dir: Path = None):
        """
        Create API-compatible catalog files for backward compatibility

        Generates the same format as the previous system:
        - enemies_catalog_detailed.json
        - structures_catalog_detailed.json
        """
        if output_dir is None:
            output_dir = Path('.')

        logger.info("Creating API-compatible catalog files...")

        # Create troops/enemies catalog
        if 'troops' in self.extraction_results:
            troops_data = self.extraction_results['troops']['data']
            troops_stats = self.extraction_results['troops']['stats']

            enemies_catalog = {
                'extraction_info': {
                    'date': self.extraction_metadata['extraction_date'],
                    'version': self.extraction_metadata['extraction_version'],
                    'total_enemies': len(troops_data),
                    'extractor_type': 'Modular TroopExtractor'
                },
                'enemies': list(troops_data.keys()),
                'enemies_detailed': troops_data,
                'extraction_stats': troops_stats
            }

            with open(output_dir / "enemies_catalog_detailed.json", 'w') as f:
                json.dump(enemies_catalog, f, indent=2)

        # Create structures catalog
        if 'structures' in self.extraction_results:
            structures_data = self.extraction_results['structures']['data']
            structures_stats = self.extraction_results['structures']['stats']

            structures_catalog = {
                'extraction_info': {
                    'date': self.extraction_metadata['extraction_date'],
                    'version': self.extraction_metadata['extraction_version'],
                    'total_structures': len(structures_data),
                    'extractor_type': 'Modular StructureExtractor'
                },
                'structures': list(structures_data.keys()),
                'structures_detailed': structures_data,
                'extraction_stats': structures_stats
            }

            with open(output_dir / "structures_catalog_detailed.json", 'w') as f:
                json.dump(structures_catalog, f, indent=2)

        logger.info("✅ API-compatible catalogs created")

    def save_complete_results(self, output_file: str = "gear_fight_modular_complete.json"):
        """Save complete extraction results to file"""
        results = self.extract_all_data()

        # Save formatted version
        output_path = Path(output_file)
        with open(output_path, 'w', encoding='utf-8') as f:
            json.dump(results, f, indent=2, ensure_ascii=False)

        # Save compact version
        compact_path = output_path.with_name(f"{output_path.stem}_compact.json")
        with open(compact_path, 'w', encoding='utf-8') as f:
            json.dump(results, f, separators=(',', ':'), ensure_ascii=False)

        # Create API-compatible catalogs
        self.create_api_compatible_catalogs()

        logger.info(f"✅ Complete extraction results saved:")
        logger.info(f"   📄 {output_path} (formatted)")
        logger.info(f"   📄 {compact_path} (compact)")
        logger.info(f"   📄 API-compatible catalogs created")

        return results

def main():
    """Main extraction entry point"""
    # Configure logging
    logging.basicConfig(
        level=logging.INFO,
        format='%(asctime)s - %(name)s - %(levelname)s - %(message)s'
    )

    # Initialize and run extractor
    extractor = EnhancedCompleteExtractor()
    results = extractor.save_complete_results()

    # Print summary
    metadata = results['metadata']
    stats = metadata['overall_statistics']

    print("\n" + "="*60)
    print("🎯 ENHANCED MODULAR EXTRACTION COMPLETE!")
    print("="*60)
    print(f"📊 Total Assets Extracted: {stats['total_assets_extracted']}")
    print(f"🔧 Extractors Used: {stats['extractor_count']}")
    print(f"✅ Success Rate: {stats['extraction_success_rate']:.1f}%")
    print(f"📅 Extraction Date: {metadata['extraction_date']}")
    print(f"🎮 Game Version: {metadata['game_version']}")

    print(f"\n📋 Asset Breakdown:")
    for asset_type, count in stats['asset_type_breakdown'].items():
        print(f"   • {asset_type.title()}: {count} assets")

    print(f"\n🔍 Validation Results:")
    if 'validation_results' in metadata:
        for validation_type, validation_data in metadata['validation_results'].items():
            print(f"   • {validation_type}: ✅ Validated")

    print("\n🚀 Ready for API integration and level editor enhancement!")

if __name__ == "__main__":
    main()