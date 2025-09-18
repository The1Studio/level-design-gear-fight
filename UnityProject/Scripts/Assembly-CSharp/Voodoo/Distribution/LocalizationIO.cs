using System;
using System.Runtime.CompilerServices;

namespace Voodoo.Distribution
{
	public static class LocalizationIO
	{
		private const string _gameData = "GameData";

		private const string _localization = "Localization";

		private const string _resourcesDir = "Resources";

		private const string _file = "LocData";

		private const string _extension = ".asset";

		private static LocalizationData _data;

		public static bool HasData => false;

		private static LocalizationData Data => null;

		public static LocalizationSheet Sheet => null;

		public static event Action sheetChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		static LocalizationIO()
		{
		}

		private static void Initialize()
		{
		}

		public static void Dispose()
		{
		}

		public static int SheetIndexOf(string name)
		{
			return 0;
		}

		public static void SelectSheet(int index)
		{
		}

		public static void SetupSheet(ref string[] langCodes, ref string[] translationKeys, out LocalizationSet set)
		{
			set = null;
		}

		public static string[] GetSheetNames()
		{
			return null;
		}
	}
}
