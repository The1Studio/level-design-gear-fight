#!/usr/bin/env python3
"""
Unity YAML Parser - Core parsing utilities for Unity assets
Based on the documented patterns from LEVEL_SYSTEM_DETAILED_DOCS
"""

import yaml
import re
from pathlib import Path
from typing import Dict, Any, Optional, Union
import logging

logger = logging.getLogger(__name__)

class UnityYAMLParser:
    """
    Core Unity YAML parser that handles Unity-specific syntax
    Based on documented patterns from DATA_CONVERSION_COMPLETE_GUIDE.md
    """

    def __init__(self):
        self.guid_map = {}
        self._build_guid_map()

    def _build_guid_map(self):
        """Build complete GUID to asset name mapping from .meta files"""
        logger.info("Building GUID map...")

        base_path = Path("UnityProject/MonoBehaviour")
        if not base_path.exists():
            logger.warning(f"Unity path {base_path} not found")
            return

        for meta_file in base_path.glob("*.asset.meta"):
            try:
                with open(meta_file, 'r') as f:
                    content = f.read()
                    guid_match = re.search(r'guid:\s*([a-f0-9]+)', content)
                    if guid_match:
                        asset_name = meta_file.stem  # Remove .asset.meta
                        self.guid_map[guid_match.group(1)] = asset_name
            except Exception as e:
                logger.error(f"Error reading {meta_file}: {e}")

        logger.info(f"Mapped {len(self.guid_map)} GUIDs")

    def parse_unity_yaml(self, filepath: Path) -> Optional[Dict[str, Any]]:
        """
        Parse Unity YAML file handling Unity-specific syntax patterns

        Unity-specific patterns handled:
        - k__BackingField auto-property serialization
        - Reference format {fileID: ..., guid: ..., type: ...}
        - Null references {fileID: 0}
        """
        try:
            with open(filepath, 'r', encoding='utf-8') as f:
                content = f.read()

            # Find MonoBehaviour section
            mono_start = content.find('MonoBehaviour:')
            if mono_start == -1:
                logger.warning(f"No MonoBehaviour section found in {filepath}")
                return None

            # Extract YAML portion
            yaml_lines = content[mono_start:].split('\n')

            # Clean Unity-specific syntax (documented pattern)
            cleaned_lines = []
            for line in yaml_lines:
                # Remove k__BackingField wrapper - documented in Phase 4
                line = re.sub(r'<(.+?)>k__BackingField', r'\1', line)
                cleaned_lines.append(line)

            yaml_content = '\n'.join(cleaned_lines)

            # Parse YAML
            data = yaml.safe_load(yaml_content)
            return data.get('MonoBehaviour', data) if isinstance(data, dict) else data

        except Exception as e:
            logger.error(f"Error parsing {filepath}: {e}")
            return None

    def extract_guid(self, ref: Union[Dict, str, None]) -> Optional[str]:
        """
        Extract GUID from Unity reference patterns

        Handles formats documented in DATA_CONVERSION_COMPLETE_GUIDE.md:
        - {fileID: 11400000, guid: 2c632fcdc51b25943a943afe8973c24c, type: 2}
        - {fileID: 0} (NULL reference)
        """
        if not ref:
            return None

        if isinstance(ref, dict):
            # Handle {fileID: ..., guid: ..., type: ...} format
            guid = ref.get('guid')
            if guid:
                return guid
            # Handle {fileID: 0} - null reference pattern
            if ref.get('fileID') == 0:
                return None

        # Handle string format
        if isinstance(ref, str):
            match = re.search(r'guid:\s*([a-f0-9]+)', ref)
            return match.group(1) if match else None

        return None

    def resolve_guid(self, guid: Optional[str]) -> Optional[str]:
        """Resolve GUID to asset name using built mapping"""
        if not guid:
            return None
        return self.guid_map.get(guid, f"Unknown_{guid[:8]}")

    def extract_unity_reference(self, ref: Union[Dict, str, None]) -> Dict[str, Any]:
        """
        Extract complete Unity reference information
        Returns both GUID and resolved name
        """
        guid = self.extract_guid(ref)
        return {
            'guid': guid,
            'name': self.resolve_guid(guid),
            'is_null': guid is None
        }