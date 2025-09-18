using System;
using System.Collections.Generic;
using UnityEngine;

namespace Voodoo.Distribution
{
	[Serializable]
	public class LocalizationData : ScriptableObject
	{
		public int selectedSheetIndex;

		public List<LocalizationSheet> sheetVersions;

		public LocalizationSheet SelectedSheet => null;
	}
}
