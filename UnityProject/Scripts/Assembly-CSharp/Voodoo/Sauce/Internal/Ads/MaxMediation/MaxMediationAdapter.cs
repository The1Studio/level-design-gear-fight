using System;
using System.Collections.Generic;
using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads.MaxMediation
{
	[Preserve]
	public class MaxMediationAdapter : IMediationAdapter
	{
		private const string TAG = "MaxMediationAdapter";

		private static readonly Vector2 MrecAdSizeDp;

		private AdUnits _adUnits;

		private bool _appOpenEnabled;

		private bool _hasPaidToHideAds;

		public static Action<string> OnBannerLoadAttempt;

		public static Action<string> OnInterstitialLoadAttempt;

		public static Action<string> OnRewardedVideoLoadAttempt;

		public static ConditionsList InterstitialConditions;

		public static ConditionsList RewardedVideoConditions;

		private Dictionary<string, bool> _rewardsReceived;

		private MaxAdInfo _bannerAdInfo;

		private MaxAdInfo _rewardedAdInfo;

		private MaxAdInfo _interstitialAdInfo;

		private MaxAdInfo _appOpenAdInfo;

		private MaxAdInfo _mrecAdInfo;

		private MaxAdInfo _nativeAdInfo;

		private ExponentialBackoff.ExpBackoff _interstitialLoadingBackoff;

		private ExponentialBackoff.ExpBackoff _rewardedLoadingBackoff;

		private ExponentialBackoff.ExpBackoff _appOpenAdLoadingBackoff;

		private ExponentialBackoff.ExpBackoff _mrecLoadingBackoff;

		private ExponentialBackoff.ExpBackoff _nativeAdsLoadingBackoff;

		private bool _bannerInitialized;

		private bool _bannerCreated;

		private bool _interstitialInitialized;

		private bool _rewardedVideoInitialized;

		private bool _appOpenAdInitialized;

		private bool _mrecInitialized;

		private bool _mrecCreated;

		private bool _nativeAdInitialized;

		private float _screenDensity;

		private static bool _isMaxNativeSdkInitialized;

		private bool _isInterstitialShownInsteadOfRewarded;

		private static string _countryCode;

		public void Initialize(AdsKeys keys, bool hasPaidToHideAds, bool consent, bool isCcpaApplicable, Action sdkInitialized)
		{
		}

		private void OnSdkInitialized()
		{
		}

		public MediationType GetMediationType()
		{
			return default(MediationType);
		}

		public bool IsSdkInitialized()
		{
			return false;
		}

		public void SetConsent(bool consent, bool isCcpaApplicable)
		{
		}

		private bool IsBannerEnabled()
		{
			return false;
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

		private bool IsInterstitialEnabled()
		{
			return false;
		}

		public bool ShowInterstitial(bool isInterstitialShownInsteadOfRewarded = false)
		{
			return false;
		}

		private bool IsRewardedVideoEnabled()
		{
			return false;
		}

		public bool ShowRewardedVideo()
		{
			return false;
		}

		private bool IsAppOpenEnabled()
		{
			return false;
		}

		public void ShowAppOpen()
		{
		}

		private bool IsNativeAdEnabled()
		{
			return false;
		}

		public void ShowNativeAd(string layoutName, float x, float y, float width, float height)
		{
		}

		public void HideNativeAd()
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

		private static VoodooAdInfo BuildAdInfo(MaxAdInfo adInfo)
		{
			return default(VoodooAdInfo);
		}

		private static string GetCountryCode()
		{
			return null;
		}

		public void InitializeBanner()
		{
		}

		private void OnAmazonBannerInitialized(string adType, object adResponse, string adNetworkData)
		{
		}

		public float GetNativeBannerHeight()
		{
			return 0f;
		}

		public float GetScreenDensity()
		{
			return 0f;
		}

		private void OnBannerAdLoaded(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerAdLoadFailed(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnBannerAdClicked(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void InitializeInterstitial()
		{
		}

		private void OnInterstitialAdReview(string adUnitId, string adReviewCreativeId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAmazonInterstitialInitialized(string adType, object adResponse, string adNetworkData)
		{
		}

		private void LoadInterstitial()
		{
		}

		private void OnInterstitialLoaded(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialClicked(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialFailed(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnInterstitialFailedToDisplay(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialDismissed(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void InitializeRewardedVideo()
		{
		}

		private void OnAmazonRewardedVideoInitialized(string adType, object adResponse, string adNetworkData)
		{
		}

		private void OnRewardedAdReview(string adUnitId, string adReviewCreativeId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void LoadRewardedAd()
		{
		}

		private void OnRewardedAdLoaded(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdFailed(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnRewardedAdReceivedReward(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdClicked(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdHidden(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdFailedToDisplay(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void InitializeAppOpen()
		{
		}

		private void LoadAppOpenAd()
		{
		}

		private void OnAppOpenLoaded(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAppOpenClicked(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAppOpenFailed(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnAppOpenFailedToDisplay(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAppOpenDismissed(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAppOpenAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void InitializeMrec()
		{
		}

		private bool IsMrecEnabled()
		{
			return false;
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

		private void LoadMrec()
		{
		}

		private void OnMRecAdLoaded(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnMRecAdLoadFailed(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnMRecAdClicked(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnMRecAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void InitializeNativeAds()
		{
		}

		private void LoadNativeAd()
		{
		}

		private void OnNativeAdLoaded(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnNativeAdClicked(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnNativeAdFailed(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnNativeAdDisplayed(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnNativeAdFailedToDisplay(string adUnit, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnNativeAdDismissed(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnNativeAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private VoodooErrorAdInfo MapToVoodooErrorAdInfo(MaxSdkBase.ErrorInfo errorInfo)
		{
			return default(VoodooErrorAdInfo);
		}

		public void SetMuteAds(bool mute)
		{
		}

		public bool EnableAmazonTesting()
		{
			return false;
		}
	}
}
