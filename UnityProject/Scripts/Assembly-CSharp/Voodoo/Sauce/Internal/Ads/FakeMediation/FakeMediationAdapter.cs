using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	public class FakeMediationAdapter : IMediationAdapter
	{
		private const string FAKE_VALUE = "fake";

		private const double INTERSTITIAL_AD_REVENUE = 5E-10;

		private const double NATIVE_AD_REVENUE = 6E-10;

		private const double MREC_AD_REVENUE = 8E-11;

		private const double REWARDED_AD_REVENUE = 7E-09;

		private const double BANNER_AD_REVENUE = 3E-12;

		private const double APP_OPEN_AD_REVENUE = 4E-12;

		internal static GameObject fakeAdsPrefab;

		private FakeMediationBehaviour _fakeAds;

		private AdsKeys _keys;

		private bool _sdkInitialized;

		private bool _bannerInitialized;

		private bool _interstitialInitialized;

		private bool _rewardedVideoInitialized;

		private bool _appOpenInitialized;

		private bool _mrecInitialized;

		private bool _nativeAdInitialized;

		public MediationType GetMediationType()
		{
			return default(MediationType);
		}

		public void Initialize(AdsKeys keys, bool hasPaidToHideAds, bool consent, bool isCcpaApplicable, Action sdkInitialized)
		{
		}

		public bool IsSdkInitialized()
		{
			return false;
		}

		public void SetConsent(bool consent, bool isCcpaApplicable)
		{
		}

		public void SetAdUnit(AdUnitType type, string adUnit)
		{
		}

		public bool HasDebugger()
		{
			return false;
		}

		public void ShowDebugger()
		{
		}

		public void OnApplicationPause(bool pauseStatus)
		{
		}

		public VoodooAdInfo GetBannerInfo()
		{
			return default(VoodooAdInfo);
		}

		public VoodooAdInfo GetInterstitialInfo()
		{
			return default(VoodooAdInfo);
		}

		public VoodooAdInfo GetRewardedVideoInfo()
		{
			return default(VoodooAdInfo);
		}

		public VoodooAdInfo GetAppOpenInfo()
		{
			return default(VoodooAdInfo);
		}

		public VoodooAdInfo GetMrecInfo()
		{
			return default(VoodooAdInfo);
		}

		public VoodooAdInfo GetNativeAdsInfo()
		{
			return default(VoodooAdInfo);
		}

		public VoodooAdInfo GetBannerImpressionInfo()
		{
			return default(VoodooAdInfo);
		}

		public VoodooAdInfo GetInterstitialImpressionInfo()
		{
			return default(VoodooAdInfo);
		}

		public VoodooAdInfo GetRewardedVideoImpressionInfo()
		{
			return default(VoodooAdInfo);
		}

		public VoodooAdInfo GetAppOpenImpressionInfo()
		{
			return default(VoodooAdInfo);
		}

		public VoodooAdInfo GetMrecImpressionInfo()
		{
			return default(VoodooAdInfo);
		}

		public VoodooAdInfo GetNativeAdsImpressionInfo()
		{
			return default(VoodooAdInfo);
		}

		public string GetAdQualitySdkName()
		{
			return null;
		}

		public string GetAdQualitySdkStatus()
		{
			return null;
		}

		private bool IsBannerEnabled()
		{
			return false;
		}

		public float GetNativeBannerHeight()
		{
			return 0f;
		}

		public float GetNativeBannerHeightInPx()
		{
			return 0f;
		}

		public float GetNativeBannerHeightInDp()
		{
			return 0f;
		}

		public float GetScreenDensity()
		{
			return 0f;
		}

		public void InitializeBanner()
		{
		}

		public void ShowBanner()
		{
		}

		public void HideBanner()
		{
		}

		public void DestroyBanner()
		{
		}

		public void SetBannerBackgroundVisibility(bool visibility, Color color)
		{
		}

		private static void OnBannerAdLoadedEvent()
		{
		}

		private static void OnBannerAdClickedEvent()
		{
		}

		private static void OnBannerAdRevenuePaidEvent()
		{
		}

		private bool IsInterstitialEnabled()
		{
			return false;
		}

		public void InitializeInterstitial()
		{
		}

		private void LoadInterstitial()
		{
		}

		public bool ShowInterstitial(bool isInterstitialShownInsteadOfRewarded = false)
		{
			return false;
		}

		private static void OnInterstitialAdLoadedEvent()
		{
		}

		private static void OnInterstitialAdClickedEvent()
		{
		}

		private void OnInterstitialAdHiddenEvent()
		{
		}

		private static void OnInterstitialAdRevenuePaidEvent()
		{
		}

		private bool IsAppOpenEnabled()
		{
			return false;
		}

		public void InitializeAppOpen()
		{
		}

		private void LoadAppOpen()
		{
		}

		public void ShowAppOpen()
		{
		}

		private static void OnAppOpenAdLoadedEvent()
		{
		}

		private static void OnAppOpenAdClickedEvent()
		{
		}

		private void OnAppOpenAdHiddenEvent()
		{
		}

		private static void OnAppOpenAdRevenuePaidEvent()
		{
		}

		private bool IsRewardedVideoEnabled()
		{
			return false;
		}

		public void InitializeRewardedVideo()
		{
		}

		private void LoadRewardedVideo()
		{
		}

		public bool ShowRewardedVideo()
		{
			return false;
		}

		private static void OnRewardedAdLoadedEvent()
		{
		}

		private static void OnRewardedAdClickedEvent()
		{
		}

		private void OnRewardedAdHiddenEvent(bool watched)
		{
		}

		private static void OnRewardedAdRevenuePaidEvent()
		{
		}

		public void InitializeMrec()
		{
		}

		public void ShowMrec(float x, float y)
		{
		}

		public void HideMrec()
		{
		}

		public void DestroyMrec()
		{
		}

		private static void OnMRecAdLoadedEvent()
		{
		}

		private static void OnMRecAdClickedEvent()
		{
		}

		private static void OnMRecAdRevenuePaidEvent()
		{
		}

		public void InitializeNativeAds()
		{
		}

		private void LoadNativeAds()
		{
		}

		public void ShowNativeAd(string layoutName, float x, float y, float width, float height)
		{
		}

		public void HideNativeAd()
		{
		}

		private static void OnNativeAdLoadedEvent()
		{
		}

		private static void OnNativeAdDisplayedEvent()
		{
		}

		private static void OnNativeAdClickedEvent()
		{
		}

		private static void OnNativeAdHiddenEvent()
		{
		}

		private static void OnNativeAdRevenuePaidEvent()
		{
		}

		public bool EnableAmazonTesting()
		{
			return false;
		}

		public void SetMuteAds(bool mute)
		{
		}

		private static VoodooAdInfo BuildFakeAdInfo(double adRevenue)
		{
			return default(VoodooAdInfo);
		}
	}
}
