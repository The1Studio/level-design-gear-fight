namespace Voodoo.Sauce.Core
{
	public class VoodooSauceInitCallbackResult
	{
		public bool AdsConsentGranted { get; set; }

		public bool AnalyticsConsentGranted { get; set; }

		public bool IsEmbargoCountry { get; set; }

		public bool IsAnalyticsEnforcementEnabled { get; set; }

		public string CountryCode { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
