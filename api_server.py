#!/usr/bin/env python3
"""
Gear Fight API Server
RESTful API for level data management
"""

from flask import Flask, jsonify, send_file, request, send_from_directory
from flask_cors import CORS
import json
import os
import sys
import subprocess
from pathlib import Path
import io
import zipfile
from threading import Lock
from datetime import datetime
import logging

# Configure logging
logging.basicConfig(level=logging.INFO)
logger = logging.getLogger(__name__)

app = Flask(__name__)

# Load configuration
CONFIG_PATH = Path(__file__).parent / "config.json"
with open(CONFIG_PATH, 'r') as f:
    CONFIG = json.load(f)

# Configure CORS
CORS(app, origins=[
    "http://localhost:3200",  # Development dashboard
    "http://localhost:3100",  # Staging dashboard
    "http://localhost:3000",  # Production dashboard
    "https://design.the1studio.org",  # Production
    "https://staging-design.the1studio.org"  # Staging
])

# Paths
BASE_DIR = Path(__file__).parent
LEVEL_DATA_DIR = BASE_DIR / CONFIG['paths']['levelData']
UNITY_DATA_DIR = BASE_DIR / CONFIG['paths']['unityData']

# Thread safety
validation_lock = Lock()
conversion_lock = Lock()

# Cache for frequently accessed data
level_cache = {}
analysis_cache = None
cache_timestamp = None

@app.route('/health')
def health():
    """Health check endpoint for monitoring"""
    level_count = len(list(LEVEL_DATA_DIR.glob("level_*.json"))) if LEVEL_DATA_DIR.exists() else 0
    return jsonify({
        "status": "healthy",
        "game": CONFIG['game'],
        "version": CONFIG.get('version', '5.1.3'),
        "timestamp": datetime.now().isoformat(),
        "levels": level_count
    })

@app.route('/api/config')
def get_config():
    """Get environment-aware configuration"""
    try:
        # Detect environment
        is_proxied = (
            request.headers.get('X-Proxied-Through') == 'dashboard' or
            request.headers.get('X-Forwarded-For') is not None or
            '/game-tools/' in request.headers.get('Referer', '')
        )

        return jsonify({
            "game": CONFIG['game'],
            "id": CONFIG.get('id'),
            "version": CONFIG.get('version'),
            "isProxied": is_proxied,
            "apiBase": CONFIG['dashboard']['proxyPath'] if is_proxied else "",
            "paths": CONFIG['paths'],
            "endpoints": CONFIG['api']['endpoints'],
            "features": CONFIG.get('features', {}),
            "grid": CONFIG.get('grid', {}),
            "gameSpecifics": CONFIG.get('game_specifics', {})
        })
    except Exception as e:
        logger.error(f"Config error: {e}")
        return jsonify({"error": str(e)}), 500

@app.route('/api/levels')
@app.route('/api/levels/list')
def list_levels():
    """List all available levels with metadata"""
    try:
        levels = []

        if LEVEL_DATA_DIR.exists():
            for file_path in sorted(LEVEL_DATA_DIR.glob("level_*.json")):
                try:
                    with open(file_path, 'r') as f:
                        data = json.load(f)
                        levels.append({
                            "id": data.get('levelNumber', 0),
                            "worldNumber": data.get('worldNumber', 0),
                            "levelInWorld": data.get('levelInWorld', 0),
                            "name": data.get('name', 'Unknown'),
                            "guid": data.get('guid', ''),
                            "hasCustomFights": data.get('metadata', {}).get('hasCustomFights', False),
                            "isProcedurallyGenerated": data.get('metadata', {}).get('isProcedurallyGenerated', True),
                            "fightCount": data.get('metadata', {}).get('fightCount', 0),
                            "totalEnemies": data.get('metadata', {}).get('totalEnemies', 0),
                            "hasStructures": data.get('metadata', {}).get('hasStructures', False)
                        })
                except (ValueError, json.JSONDecodeError) as e:
                    logger.error(f"Error loading {file_path}: {e}")

        # Sort by world and level
        levels.sort(key=lambda x: (x.get('worldNumber', 0), x.get('levelInWorld', 0)))

        return jsonify({
            "levels": levels,
            "total": len(levels),
            "game": CONFIG['game']
        })
    except Exception as e:
        logger.error(f"List levels error: {e}")
        return jsonify({"error": str(e)}), 500

@app.route('/api/levels/<world>/<int:level>')
@app.route('/api/levels/<int:sort_key>')
def get_level(world=None, level=None, sort_key=None):
    """Get complete data for specific level"""
    try:
        # Determine file name based on parameters
        if world and level:
            file_name = f"level_{world}_{level}.json"
        else:
            # Find by sort_key
            for file_path in LEVEL_DATA_DIR.glob("level_*.json"):
                with open(file_path, 'r') as f:
                    data = json.load(f)
                    if data.get('levelNumber') == sort_key:
                        return jsonify(data)
            return jsonify({"error": f"Level with sort key {sort_key} not found"}), 404

        file_path = LEVEL_DATA_DIR / file_name

        if not file_path.exists():
            return jsonify({"error": f"Level {world}-{level} not found"}), 404

        with open(file_path, 'r') as f:
            level_data = json.load(f)

        return jsonify(level_data)
    except Exception as e:
        logger.error(f"Get level error: {e}")
        return jsonify({"error": str(e)}), 500

@app.route('/api/chapters')
def get_chapters():
    """Get chapter and world data"""
    try:
        chapters_file = BASE_DIR / "chapters.json"
        if not chapters_file.exists():
            return jsonify({"error": "Chapters data not found"}), 404

        with open(chapters_file, 'r') as f:
            chapters_data = json.load(f)

        return jsonify(chapters_data)
    except Exception as e:
        logger.error(f"Get chapters error: {e}")
        return jsonify({"error": str(e)}), 500

@app.route('/api/enemies')
def get_enemies():
    """Get enemies catalog"""
    try:
        enemies_file = BASE_DIR / "enemies_catalog.json"
        if not enemies_file.exists():
            return jsonify({"error": "Enemies catalog not found"}), 404

        with open(enemies_file, 'r') as f:
            enemies_data = json.load(f)

        return jsonify(enemies_data)
    except Exception as e:
        logger.error(f"Get enemies error: {e}")
        return jsonify({"error": str(e)}), 500

@app.route('/api/structures')
def get_structures():
    """Get structures catalog"""
    try:
        structures_file = BASE_DIR / "structures_catalog.json"
        if not structures_file.exists():
            return jsonify({"error": "Structures catalog not found"}), 404

        with open(structures_file, 'r') as f:
            structures_data = json.load(f)

        return jsonify(structures_data)
    except Exception as e:
        logger.error(f"Get structures error: {e}")
        return jsonify({"error": str(e)}), 500

@app.route('/api/levels/<world>/<int:level>', methods=['PUT'])
def update_level(world, level):
    """Update level data"""
    try:
        if not request.json:
            return jsonify({"error": "No data provided"}), 400

        file_path = LEVEL_DATA_DIR / f"level_{world}_{level}.json"

        # Validate data structure
        required_fields = ['levelNumber', 'levelSettings']
        for field in required_fields:
            if field not in request.json:
                return jsonify({"error": f"Missing required field: {field}"}), 400

        # Save with backup
        if file_path.exists():
            backup_path = file_path.with_suffix('.json.bak')
            file_path.rename(backup_path)

        with open(file_path, 'w') as f:
            json.dump(request.json, f, indent=2)

        return jsonify({"success": True, "world": world, "level": level})
    except Exception as e:
        logger.error(f"Update level error: {e}")
        return jsonify({"error": str(e)}), 500

@app.route('/api/level-order', methods=['PUT'])
def update_level_order():
    """Update the display order of levels"""
    try:
        if not request.json or 'levels' not in request.json:
            return jsonify({"error": "No level order data provided"}), 400

        new_order = request.json['levels']

        # Validate that all levels exist
        for level_data in new_order:
            if 'world' not in level_data or 'level' not in level_data or 'displayOrder' not in level_data:
                return jsonify({"error": "Invalid level order data format"}), 400

            file_path = LEVEL_DATA_DIR / f"level_{level_data['world']}_{level_data['level']}.json"
            if not file_path.exists():
                return jsonify({"error": f"Level {level_data['world']}-{level_data['level']} not found"}), 404

        # Update each level file with new display order
        updated_count = 0
        for level_data in new_order:
            file_path = LEVEL_DATA_DIR / f"level_{level_data['world']}_{level_data['level']}.json"

            with open(file_path, 'r') as f:
                level_json = json.load(f)

            # Update the displayLevelNumber field
            level_json['displayLevelNumber'] = level_data['displayOrder']

            with open(file_path, 'w') as f:
                json.dump(level_json, f, indent=2)

            updated_count += 1

        return jsonify({
            "status": "success",
            "message": f"Updated display order for {updated_count} levels",
            "updated_count": updated_count
        })

    except Exception as e:
        logger.error(f"Level order update error: {e}")
        return jsonify({"error": str(e)}), 500

@app.route('/api/validation/run', methods=['POST'])
def run_validation():
    """Run validation on levels"""
    try:
        with validation_lock:
            level_id = request.json.get('level') if request.json else None

            # Build command
            validation_script = BASE_DIR / "validate_levels.py"
            if not validation_script.exists():
                return jsonify({
                    "status": "error",
                    "error": "Validation script not found. Creating placeholder..."
                }), 404

            cmd = [sys.executable, str(validation_script)]
            if level_id:
                cmd.extend(['--level', str(level_id)])

            # Run validation
            result = subprocess.run(
                cmd,
                cwd=BASE_DIR,
                capture_output=True,
                text=True,
                timeout=300
            )

            if result.returncode != 0:
                return jsonify({
                    "status": "error",
                    "error": result.stderr,
                    "stdout": result.stdout
                }), 500

            # Load and return results
            report_path = BASE_DIR / "validation_report.json"
            if report_path.exists():
                with open(report_path, 'r') as f:
                    validation_data = json.load(f)
                return jsonify({
                    "status": "completed",
                    "results": validation_data
                })

            return jsonify({
                "status": "completed",
                "message": "Validation completed but no report generated"
            })
    except subprocess.TimeoutExpired:
        return jsonify({"status": "error", "error": "Validation timeout"}), 500
    except Exception as e:
        logger.error(f"Validation error: {e}")
        return jsonify({"status": "error", "error": str(e)}), 500

@app.route('/api/validation/report')
def get_validation_report():
    """Get the latest validation report"""
    try:
        report_path = BASE_DIR / "validation_report.json"
        if report_path.exists():
            with open(report_path, 'r') as f:
                validation_data = json.load(f)
            return jsonify({
                "status": "success",
                "timestamp": datetime.fromtimestamp(report_path.stat().st_mtime).isoformat(),
                "results": validation_data
            })
        else:
            return jsonify({
                "status": "not_found",
                "message": "No validation report found. Run validation first."
            }), 404
    except Exception as e:
        logger.error(f"Error reading validation report: {e}")
        return jsonify({"status": "error", "error": str(e)}), 500

@app.route('/api/analysis')
def get_analysis():
    """Get game analysis data"""
    try:
        global analysis_cache, cache_timestamp

        # Check cache (1 hour)
        if analysis_cache and cache_timestamp:
            if (datetime.now() - cache_timestamp).seconds < 3600:
                return jsonify(analysis_cache)

        # Try to load existing analysis
        analysis_path = BASE_DIR / "game_analysis.json"
        if analysis_path.exists():
            with open(analysis_path, 'r') as f:
                analysis_cache = json.load(f)
                cache_timestamp = datetime.now()
                return jsonify(analysis_cache)

        # Generate basic analysis
        analysis_cache = generate_basic_analysis()
        cache_timestamp = datetime.now()

        return jsonify(analysis_cache)
    except Exception as e:
        logger.error(f"Analysis error: {e}")
        return jsonify({"error": str(e)}), 500

def generate_basic_analysis():
    """Generate basic analysis from available data"""
    analysis = {
        "game": CONFIG['game'],
        "version": CONFIG.get('version', '5.1.3'),
        "statistics": {
            "totalLevels": 0,
            "customFightLevels": 0,
            "proceduralLevels": 0,
            "totalFights": 0,
            "uniqueEnemies": 0,
            "uniqueStructures": 0
        },
        "levelProgression": [],
        "enemyDistribution": {},
        "structureUsage": {}
    }

    # Count levels and gather statistics
    for file_path in LEVEL_DATA_DIR.glob("level_*.json"):
        with open(file_path, 'r') as f:
            level_data = json.load(f)

        analysis['statistics']['totalLevels'] += 1

        if level_data.get('metadata', {}).get('hasCustomFights'):
            analysis['statistics']['customFightLevels'] += 1
        else:
            analysis['statistics']['proceduralLevels'] += 1

        analysis['statistics']['totalFights'] += level_data.get('metadata', {}).get('fightCount', 0)

        # Track enemy usage
        for enemy in level_data.get('enemies', []):
            if enemy:
                analysis['enemyDistribution'][enemy] = analysis['enemyDistribution'].get(enemy, 0) + 1

        # Track structure usage
        for structure in level_data.get('structures', []):
            if structure:
                analysis['structureUsage'][structure] = analysis['structureUsage'].get(structure, 0) + 1

    analysis['statistics']['uniqueEnemies'] = len(analysis['enemyDistribution'])
    analysis['statistics']['uniqueStructures'] = len(analysis['structureUsage'])

    return analysis

@app.route('/api/export/all')
def export_all_levels():
    """Export all levels as ZIP"""
    try:
        # Create ZIP in memory
        zip_buffer = io.BytesIO()

        with zipfile.ZipFile(zip_buffer, 'w', zipfile.ZIP_DEFLATED) as zip_file:
            for file_path in LEVEL_DATA_DIR.glob("level_*.json"):
                zip_file.write(file_path, file_path.name)

            # Include supplemental data
            for file_name in ['chapters.json', 'enemies_catalog.json', 'structures_catalog.json', 'guid_mappings.json']:
                file_path = BASE_DIR / file_name
                if file_path.exists():
                    zip_file.write(file_path, file_name)

        zip_buffer.seek(0)

        return send_file(
            zip_buffer,
            mimetype='application/zip',
            as_attachment=True,
            download_name=f'{CONFIG["game"]}_levels_{datetime.now():%Y%m%d_%H%M%S}.zip'
        )
    except Exception as e:
        logger.error(f"Export error: {e}")
        return jsonify({"error": str(e)}), 500

# Static file serving for development
@app.route('/')
def index():
    """Serve main page"""
    index_file = BASE_DIR / 'level_editor.html'
    if index_file.exists():
        return send_from_directory('.', 'level_editor.html')
    return jsonify({"message": "Gear Fight API Server", "version": CONFIG.get('version', '5.1.3')})

@app.route('/<path:path>')
def serve_static(path):
    """Serve static files"""
    file_path = BASE_DIR / path
    if file_path.exists() and file_path.is_file():
        return send_from_directory('.', path)
    return jsonify({"error": "File not found"}), 404

if __name__ == '__main__':
    port = CONFIG.get('apiPort', 3205)
    print(f"Starting {CONFIG['game']} API Server on port {port}")
    print(f"Version: {CONFIG.get('version', '5.1.3')}")
    print(f"Levels directory: {LEVEL_DATA_DIR}")
    print(f"Unity data directory: {UNITY_DATA_DIR}")

    # Check if level data exists
    if LEVEL_DATA_DIR.exists():
        level_count = len(list(LEVEL_DATA_DIR.glob("level_*.json")))
        print(f"Found {level_count} level files")
    else:
        print("Warning: Level data directory does not exist")

    app.run(host='0.0.0.0', port=port, debug=False)