using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal struct AnalyticsProviderInfo
	{
		public PrivacyCore.GdprConsent Consent;

		public bool IsChinaBuild;

		public string FacebookAppId;
	}
}
