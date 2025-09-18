using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads
{
	public interface IMediationAdapter
	{
		MediationType GetMediationType();

		void Initialize(AdsKeys keys, bool hasPaidToHideAds, bool consent, bool isCcpaApplicable, Action sdkInitialized);

		bool IsSdkInitialized();

		void SetConsent(bool consent, bool isCcpaApplicable);

		void SetAdUnit(AdUnitType type, string adUnit);

		VoodooAdInfo GetBannerInfo();

		VoodooAdInfo GetInterstitialInfo();

		VoodooAdInfo GetRewardedVideoInfo();

		VoodooAdInfo GetAppOpenInfo();

		VoodooAdInfo GetMrecInfo();

		VoodooAdInfo GetNativeAdsInfo();

		VoodooAdInfo GetBannerImpressionInfo();

		VoodooAdInfo GetInterstitialImpressionInfo();

		VoodooAdInfo GetRewardedVideoImpressionInfo();

		VoodooAdInfo GetAppOpenImpressionInfo();

		VoodooAdInfo GetMrecImpressionInfo();

		VoodooAdInfo GetNativeAdsImpressionInfo();

		string GetAdQualitySdkName();

		string GetAdQualitySdkStatus();

		void InitializeBanner();

		void ShowBanner();

		void HideBanner();

		void DestroyBanner();

		float GetNativeBannerHeight();

		float GetScreenDensity();

		void SetBannerBackgroundVisibility(bool visibility, Color color);

		void InitializeInterstitial();

		bool ShowInterstitial(bool isInterstitialShownInsteadOfRewarded = false);

		void InitializeRewardedVideo();

		bool ShowRewardedVideo();

		void InitializeAppOpen();

		void ShowAppOpen();

		void InitializeMrec();

		void ShowMrec(float x, float y);

		void HideMrec();

		void DestroyMrec();

		void InitializeNativeAds();

		void ShowNativeAd(string layoutName, float x, float y, float width, float height);

		void HideNativeAd();

		bool HasDebugger();

		void ShowDebugger();

		void OnApplicationPause(bool pauseStatus);

		bool EnableAmazonTesting();

		void SetMuteAds(bool mute);
	}
}
