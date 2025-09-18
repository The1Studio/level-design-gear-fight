using System;

namespace Voodoo.Sauce.Internal.Ads
{
	[Serializable]
	public class AdUnitsRemoteConfigs
	{
		public string bannerAdUnit;

		public string interstitialAdUnit;

		public string rewardedVideoAdUnit;

		public string mrecAdUnit;

		public bool mrecEnabled;

		public string nativeAdsAdUnit;

		public bool nativeAdsEnabled;

		public string appOpenAdUnit;

		public bool appOpenAdSoftLaunchEnabled;
	}
}
