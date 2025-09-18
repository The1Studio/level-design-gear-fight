using System;

namespace Voodoo.Sauce.Privacy
{
	[Serializable]
	public class NeedConsent
	{
		public enum OfferWallStatus
		{
			Disabled = 0,
			Enabled = 1,
			LimitedPlayTime = 2
		}

		public bool need_consent;

		public bool already_consent;

		public bool embargoed_country;

		public string country_code;

		public bool ads_consent;

		public bool analytics_consent;

		public string texts;

		public bool is_gdpr;

		public string privacy_version;

		public bool is_ccpa;

		public bool ads_enforcement;

		public bool adjust_enforcement;

		public bool van_enforcement;

		public int consent_version;

		public OfferWallStatus OfferWall => default(OfferWallStatus);
	}
}
