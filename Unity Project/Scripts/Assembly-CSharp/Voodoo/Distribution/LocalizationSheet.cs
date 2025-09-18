using System;

namespace Voodoo.Distribution
{
	[Serializable]
	public class LocalizationSheet
	{
		public string name;

		public string[] languageCodes;

		public LocalizationRow[] translationRows;

		public LocalizationSet GetLocalizationSet()
		{
			return null;
		}
	}
}
