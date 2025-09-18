using System;

namespace Voodoo.Distribution
{
	public interface ILocalization
	{
		event Action onLanguageChange;

		void SetLanguage(string langCode);

		string GetTranslation(string key, string languageCode = null, bool logError = true);
	}
}
