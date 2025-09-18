using System;

namespace Voodoo.Sauce.Ads.Internal
{
	[Serializable]
	public class AppHarbrConfig
	{
		public bool enabled;

		public int interstitialDurationLimit;

		public bool muteAd;

		public int rewardedVideoDurationLimit;

		public string iosAppKey;

		public string androidAppKey;
	}
}
