using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using Voodoo.Sauce.Ads.AdDataPassing;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.CrashReport;
using Voodoo.Sauce.IAP;
using Voodoo.Sauce.Internal.Ads;
using Voodoo.Sauce.Internal.Analytics;
using Voodoo.Sauce.Internal.CrossPromo;
using Voodoo.Sauce.Internal.CrossPromo.Models;
using Voodoo.Sauce.Privacy;

public static class VoodooSauce
{
	public delegate void AppResumedEventHandler();

	public enum AnalyticsProvider
	{
		VoodooAnalytics = 0,
		GameAnalytics = 1,
		FirebaseAnalytics = 2,
		Adjust = 3
	}

	private const string TAG = "VoodooSauce";

	private static VoodooSettings _settings;

	private static PrivacyCore Privacy => null;

	public static bool UserRequestedToBeForgotten => false;

	private static CrashReportCore CrashReport => null;

	private static VoodooSettings Settings => null;

	private static IAPMediator Iap => null;

	public static event AppResumedEventHandler SubscriptionsRefreshed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static string Version()
	{
		return null;
	}

	public static void SubscribeOnInitFinishedEvent(Action<VoodooSauceInitCallbackResult> onInitFinished)
	{
	}

	internal static void UnSubscribeOnInitFinishedEvent(Action<VoodooSauceInitCallbackResult> onInitFinished)
	{
	}

	internal static void InvokeAppResumed()
	{
	}

	public static string GetPlayerCohortName()
	{
		return null;
	}

	public static string[] GetPlayerCohorts()
	{
		return null;
	}

	public static string[] GetPlayerCohortNames()
	{
		return null;
	}

	public static void OnGameStarted(GameStartedParameters parameters)
	{
	}

	public static void OnGameFinished(GameFinishedParameters parameters)
	{
	}

	public static void OnGameStarted()
	{
	}

	public static void OnGameStarted(string levelNumber, Dictionary<string, object> eventProperties = null, Dictionary<string, object> eventContextProperties = null)
	{
	}

	public static void OnGameFinished(float score)
	{
	}

	public static void OnGameFinished(bool levelComplete, float score, Dictionary<string, object> eventProperties = null, Dictionary<string, object> eventContextProperties = null)
	{
	}

	public static void OnGameFinished(bool levelComplete, float score, string levelNumber, Dictionary<string, object> eventProperties = null, Dictionary<string, object> eventContextProperties = null)
	{
	}

	public static void OnGamePauseButtonClicked(bool pauseStatus)
	{
	}

	public static void OnItemTransaction(ItemTransactionParameters parameters)
	{
	}

	public static void TrackCustomEvent(string eventName, Dictionary<string, object> eventProperties = null, string type = null, List<AnalyticsProvider> analyticsProviders = null, Dictionary<string, object> eventContextProperties = null)
	{
	}

	public static void TrackNonCustomTypeVoodooAnalyticsEvent(string eventName, string data = null, string type = null, Dictionary<string, object> customVariables = null, Dictionary<string, object> contextVariables = null)
	{
	}

	public static void AddVANSessionContextParameter(string key, string value, List<string> selectedEventNames = null)
	{
	}

	public static void AddVANSessionContextParameter(string key, int value, List<string> selectedEventNames = null)
	{
	}

	public static void AddVANSessionContextParameter(string key, float value, List<string> selectedEventNames = null)
	{
	}

	public static void AddVANSessionContextParameter(string key, bool value, List<string> selectedEventNames = null)
	{
	}

	public static void SetCrashReportingUserId(string userId)
	{
	}

	public static void SetCrashReportingUserProfile(string profile)
	{
	}

	public static void SetCrashReportingCustomData(string key, string value)
	{
	}

	public static void LogCrashReportingMessage(string message)
	{
	}

	public static void LogException(Exception exception)
	{
	}

	public static bool IsChinaApp()
	{
		return false;
	}

	public static bool IsIAPEnabled()
	{
		return false;
	}

	public static IAPStatus GetIAPStatus()
	{
		return null;
	}

	public static void SubscribeToOnIAPStatusUpdate(Action<IAPStatus> onIAPStatusUpdate)
	{
	}

	public static void UnsubscribeToOnIAPStatusUpdate(Action<IAPStatus> onIAPStatusUpdate)
	{
	}

	public static void RegisterPurchaseDelegate(IPurchaseDelegateWithInfo purchaseDelegate)
	{
	}

	public static void UnregisterPurchaseDelegate(IPurchaseDelegateWithInfo purchaseDelegate)
	{
	}

	[Obsolete("Do not use this method with the parameter 'caller'. This method will be deprecated soon.")]
	public static void Purchase(string productId, IPurchaseDelegateWithInfo caller, IPurchaseValidator customPurchaseValidator = null)
	{
	}

	public static void Purchase(string productId, IPurchaseValidator customPurchaseValidator = null, Dictionary<string, object> eventContextProperties = null)
	{
	}

	public static void RestorePurchases(Action<RestorePurchasesResult> successCallback = null)
	{
	}

	[CanBeNull]
	public static SubscriptionInfoContainer GetSubscriptionInfo(string productId)
	{
		return null;
	}

	public static bool IsSubscribed(string productId)
	{
		return false;
	}

	public static bool HasOngoingSubscriptions()
	{
		return false;
	}

	public static ProductReceivedInfo GetProduct(string productId)
	{
		return null;
	}

	public static List<ProductReceivedInfo> GetProducts()
	{
		return null;
	}

	public static void TrackIAPRevenues(string productId, PurchaseProductType productType, string transactionId, string currency, double price, string token, string productName, bool isRestoredPurchase)
	{
	}

	public static void TrackIAPRevenues(ProductReceivedInfo product, bool isRestoredPurchase)
	{
	}

	public static void TrackNoAdsClick()
	{
	}

	public static string GetLocalizedProductPrice(string productId)
	{
		return null;
	}

	public static LocalizedPriceInfo GetLocalizedProductPriceInfo(string productId)
	{
		return null;
	}

	public static void EnablePremium()
	{
	}

	public static void DisablePremium()
	{
	}

	public static void SetPremiumPeriod(bool isPremiumPeriodActive)
	{
	}

	public static bool IsPremium()
	{
		return false;
	}

	public static bool IsIAPPremium()
	{
		return false;
	}

	public static bool HasPremiumPeriod()
	{
		return false;
	}

	public static bool IsPremiumOrHasOngoingSubscriptions()
	{
		return false;
	}

	public static void SubscribeToOnPremiumStatusChanged(Action<bool> onStatusChanged)
	{
	}

	public static void ShowBanner(Action<float> onBannerDisplayed = null)
	{
	}

	public static void HideBanner()
	{
	}

	public static void ShowInterstitial(Action<bool> onComplete = null, bool ignoreConditions = false, string interstitialType = null)
	{
	}

	public static bool IsRewardedVideoAvailable(bool showLogs = true)
	{
		return false;
	}

	public static void SubscribeOnRewardedVideoLoaded(Action<bool> onRewardedVideoLoadComplete)
	{
	}

	public static void UnSubscribeOnRewardedVideoLoaded(Action<bool> onRewardedVideoLoadComplete)
	{
	}

	public static void SubscribeOnRewardedVideoNotAvailable(Action onRewardedVideoNotAvailable)
	{
	}

	public static void UnsubscribeOnRewardedVideoNotAvailable(Action onRewardedVideoNotAvailable)
	{
	}

	public static bool IsInterstitialAvailable(bool showLogs = true)
	{
		return false;
	}

	public static bool InterstitialCanBeShown()
	{
		return false;
	}

	public static bool IsBannerAvailable()
	{
		return false;
	}

	public static void ShowRewardedVideo(Action<bool> onComplete, string rewardedType = null)
	{
	}

	public static void OnRewardedVideoButtonShown(string rewardedType)
	{
	}

	[Obsolete]
	public static void SetInterstitialAdsDisplayConditions(int delayInSecondsBeforeFirstInterstitialAd, int delayInSecondsBetweenInterstitialAds, int maxGamesBetweenInterstitialAds, int delayInSecondsBetweenRewardedVideoAndInterstitial = -1, int delayInSecondsBeforeSessionFirstInterstitial = -1, float delayInSecondsBetweenAppOpenAdAndInterstitial = -1f, int cumulativeDelayInSecondsBeforeFirstInterstitialAd = -1)
	{
	}

	[Obsolete("This method is no longer used")]
	public static void SetInterstitialAtLaunchConditions(bool interstitialAtLaunch, int interstitialAtLaunchDelay, int interstitialAtLaunchTimeout)
	{
	}

	public static void SetAdUnit(AdUnitType adUnitType, string adUnit)
	{
	}

	public static void ShowCrossPromo(Action<AssetModel> onSuccess = null, Action<CPShowFailType> onFailure = null)
	{
	}

	public static void HideCrossPromo()
	{
	}

	public static void TryToShowAppRater()
	{
	}

	public static void ShowGDPRSettings(Action onSettingsClosed = null)
	{
	}

	[Obsolete("There is no more restriction for non GDPR users. Please stop using this method.", false)]
	public static void RequestGdprApplicability(Action<bool> callback)
	{
	}

	[Obsolete("THE GDPR banner doesn't comply with Apple policy.", false)]
	public static void ShowGDPRBanner()
	{
	}

	public static List<T> GetSubclassesItems<T>() where T : class, new()
	{
		return null;
	}

	public static List<T> GetItems<T>() where T : class, new()
	{
		return null;
	}

	public static List<T> GetItemsOrDefaults<T>() where T : class, new()
	{
		return null;
	}

	public static T GetItem<T>() where T : class, new()
	{
		return null;
	}

	public static T GetItemOrDefault<T>() where T : class, new()
	{
		return null;
	}

	public static bool AdsConsentGiven()
	{
		return false;
	}

	public static bool AnalyticsConsentGiven()
	{
		return false;
	}

	public static bool IsAnalyticsEnforcementEnabled()
	{
		return false;
	}

	public static void SubscribeToOnPrivacyOpened(Action onPrivacyOpen)
	{
	}

	public static void UnsubscribeToOnPrivacyOpened(Action onPrivacyOpen)
	{
	}

	public static void SubscribeToOnPrivacyClosed(Action onPrivacyClose)
	{
	}

	public static void UnsubscribeToOnPrivacyClosed(Action onPrivacyClose)
	{
	}

	public static void SubscribeToDeleteDataRequested(Action onDeleteDataRequest)
	{
	}

	public static void UnsubscribeToDeleteDataRequested(Action onDeleteDataRequest)
	{
	}

	public static bool AreInterstitialDisplayConditionsMet()
	{
		return false;
	}

	public static void TrackFunnel(string funnelName, string funnelStep, Dictionary<string, object> contextProperties = null)
	{
	}

	public static void OnGameInteractable()
	{
	}

	[Obsolete("Please instantiate AudioAdPositionBehaviour prefab instead of using this method.")]
	public static void SetAudioAdPosition(AudioAdPosition position, Vector2Int offset)
	{
	}

	public static void SetAppOpenRewardedInterstitial(Func<int> getCurrencyAmount, Action<int> giveReward)
	{
	}

	public static float GetNativeBannerHeightInDp()
	{
		return 0f;
	}

	public static float GetNativeBannerHeightInPx()
	{
		return 0f;
	}

	public static void SetMuteAds(bool mute)
	{
	}

	public static void SetAdDataGender(GenderType gender)
	{
	}
}
