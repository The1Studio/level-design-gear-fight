using System;
using System.Threading.Tasks;

namespace Voodoo.Sauce.Privacy
{
	public interface IConsentManagementProvider
	{
		string GetName();

		Task<CmpConsent> GetConsent(Action<bool> onPrivacyShown);

		Task<CmpConsent> OpenPrivacySettings();

		void ClearCache();
	}
}
