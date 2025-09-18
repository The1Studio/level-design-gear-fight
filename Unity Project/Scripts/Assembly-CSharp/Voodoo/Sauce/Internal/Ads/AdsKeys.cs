using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads
{
	[Serializable]
	public class AdsKeys
	{
		[Tooltip("Used when session count is above threshold")]
		public AdUnits maxAdsAdUnits;

		[Tooltip("Used when session count is below threshold")]
		public AdUnits maxAdsSecondaryAdUnits;

		[Tooltip("Used to determine which Ad units will be used")]
		public int sessionCountThreshold;

		[HideInInspector]
		public string maxSdkKey;

		public string ironSourceMediationAppKey;

		[HideInInspector]
		public bool enableFakeAds;

		[HideInInspector]
		public bool enableFakeInterstitialAds;

		[HideInInspector]
		public bool enableFakeRewardedVideoAds;

		[HideInInspector]
		public bool enableFakeAppOpenAds;

		[HideInInspector]
		public bool enableAppOpenAdSoftLaunch;

		public AdUnits AdUnits { get; private set; }

		public string BannerAdUnit => null;

		public string InterstitialAdUnit => null;

		public string RewardedVideoAdUnit => null;

		public string MrecAdUnit => null;

		public string NativeAdsAdUnit => null;

		public string AppOpenAdUnit => null;

		internal void InitAdUnits(int sessionCount, AdUnitsRemoteConfigs remoteConfig)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public bool HasBannerKey()
		{
			return false;
		}

		public bool HasInterstitialKey()
		{
			return false;
		}

		public bool HasRewardedVideoKey()
		{
			return false;
		}

		public bool HasMrecKey()
		{
			return false;
		}

		public bool HasNativeAdsKey()
		{
			return false;
		}

		public bool HasAppOpenKey()
		{
			return false;
		}
	}
}
