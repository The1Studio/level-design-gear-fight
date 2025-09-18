using System;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Internal.Ads.FakeMediation;

namespace Voodoo.Sauce.Internal.Ads
{
	internal static class AdsManager
	{
		private const string TAG = "AdsManager";

		private static Banner _banner;

		private static Interstitial _interstitial;

		private static RewardedVideo _rewardedVideo;

		private static Mrec _mrec;

		private static NativeAds _nativeAds;

		private static RewardedInterstitialVideo _rewardedInterstitialVideo;

		private static AppOpen _appOpen;

		private static bool _enableReplaceRewardedOnCpm;

		private static bool _enableReplaceRewardedIfNotLoaded;

		private static AdDisplayConditions _adDisplayConditions;

		public static IFakeAdsManager fakeAdsManager;

		private static IMediationAdapter _mediationAdapter;

		private static AdsKeys _currentAdKeys;

		private static bool? _newMuteValue;

		public static Banner Banner => null;

		public static Interstitial Interstitial => null;

		public static RewardedVideo RewardedVideo => null;

		public static Mrec Mrec => null;

		public static bool IsMrecAdEnabled => false;

		public static NativeAds NativeAds => null;

		public static RewardedInterstitialVideo RewardedInterstitialVideo => null;

		public static AppOpen AppOpen => null;

		public static bool EnableReplaceRewardedOnCpm => false;

		public static bool EnableReplaceRewardedIfNotLoaded => false;

		public static IMediationAdapter MediationAdapter => null;

		private static bool IsCcpaApplicable => false;

		internal static string GetSelectedMediationName()
		{
			return null;
		}

		internal static bool AreFakeAdsEnabled()
		{
			return false;
		}

		private static bool IsFullScreenAdShowing()
		{
			return false;
		}

		public static void OnApplicationFocus(bool isFocused)
		{
		}

		public static void OnApplicationPause(bool pauseStatus)
		{
		}

		private static bool HasPaidToHideAds()
		{
			return false;
		}

		public static void Initialize(VoodooSettings settings)
		{
		}

		public static void InitializeMediation(VoodooSettings settings, bool consent)
		{
		}

		private static void OnSdkInitialized()
		{
		}

		private static void OnPremiumStatusChanged(bool isPremium)
		{
		}

		public static void SetConsent(bool consent)
		{
		}

		public static void SetAdUnit(AdUnitType type, string adUnit)
		{
		}

		public static void SetMuteAds(bool mute)
		{
		}

		private static void DisableAppOpen()
		{
		}

		private static void EnableAppOpen()
		{
		}

		[Obsolete]
		public static void SetInterstitialAdsDisplayConditions(int delayInSecondsBeforeFirstInterstitialAd, int delayInSecondsBeforeSessionFirstInterstitial, int delayInSecondsBetweenInterstitialAds, int maxGamesBetweenInterstitialAds, int delayInSecondsBetweenRewardedVideoAndInterstitial, float delayInSecondsBetweenAppOpenAdAndInterstitial, int cumulativeDelayInSecondsBeforeFirstInterstitialAd)
		{
		}

		internal static string GetInterstitialConditionSettings()
		{
			return null;
		}

		internal static string GetAppOpenConditionSettings()
		{
			return null;
		}

		internal static string GetInterstitialConditionStatusString()
		{
			return null;
		}

		internal static string GetInterstitialConditionTimeString()
		{
			return null;
		}

		internal static bool AreInterstitialDisplayConditionsMet()
		{
			return false;
		}

		internal static void TriggerInterstitialAdConditionsDisplay()
		{
		}

		public static void IncrementGamesPlayed()
		{
		}

		private static void UpdateAdDisplayConditions()
		{
		}

		public static bool EnableAmazonTesting()
		{
			return false;
		}
	}
}
