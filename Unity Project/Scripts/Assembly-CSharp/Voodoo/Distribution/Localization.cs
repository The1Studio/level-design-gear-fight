using System;
using System.Runtime.CompilerServices;

namespace Voodoo.Distribution
{
	public static class Localization
	{
		private const string _noLocalizationDatasetMessage = "No valid Localization dataset could be load.";

		private const string _keyDoesNotExistMessage = "Key: <color=cyan>{0}</color> doesn't exist.";

		public static string forcedLanguage;

		private static string _languageCode;

		private static string[] _languageCodes;

		private static string[] _translationKeys;

		private static LocalizationDebugger _debugger;

		private static LocalizationSet _set;

		public static LocalizationSet Set => null;

		public static string[] LanguageCodes => null;

		public static string[] TranslationKeys => null;

		public static bool IsValid => false;

		public static bool IsRightToLeftLanguage => false;

		public static string LanguageCode => null;

		public static event Action languageChanged
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

		static Localization()
		{
		}

		private static void Initialize()
		{
		}

		public static void SetLanguage(string langCode)
		{
		}

		public static void Dispose()
		{
		}

		private static void Mount()
		{
		}

		public static string GetTranslation(string key, string languageCode = null, bool logError = true)
		{
			return null;
		}

		public static bool KeyExist(string key)
		{
			return false;
		}

		private static string GetLongestString(string key)
		{
			return null;
		}

		private static int GetRoughLength(string word)
		{
			return 0;
		}

		public static void TranslateAll()
		{
		}
	}
}
