using System.Collections.Generic;
using Voodoo.Analytics;
using Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Models;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Preserve]
	internal class VoodooAnalyticsProvider : BaseAnalyticsProviderWithLogger
	{
		private readonly VoodooAnalyticsParameters _parameters;

		public VoodooAnalyticsProvider()
		{
		}

		internal VoodooAnalyticsProvider(VoodooAnalyticsParameters parameters)
		{
		}

		internal override VoodooSauce.AnalyticsProvider GetProviderEnum()
		{
			return default(VoodooSauce.AnalyticsProvider);
		}

		public override void Instantiate(string mediation)
		{
		}

		public override void Initialize(AnalyticsProviderInfo info)
		{
		}

		private static void RegisterEvents()
		{
		}

		private static void OnTrackEvent(string eventName, string data = null, string eventType = null, Dictionary<string, object> customVariables = null, Dictionary<string, object> contextVariables = null)
		{
		}

		private static void OnNoAdsClickEvent()
		{
		}

		private static void OnCloseBannerClick()
		{
		}

		private static void OnCloseBannerPurchase()
		{
		}

		private static void OnCloseBannerCancel()
		{
		}

		private static void OnBannerShownEvent(AdEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnBannerClickedEvent(AdEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnInterstitialClickedEvent(AdClickEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnInterstitialShownEvent(AdShownEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnInterstitialTriggeredEvent(AdTriggeredEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnInterstitialDismissedEvent(AdClosedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnInterstitialShowFailedEvent(AdShowFailedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnInterstitialAdReview(AdReviewAnalyticsInfo info)
		{
		}

		private static void OnRewardedVideoClickedEvent(AdClickEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnRewardedVideoShownEvent(AdShownEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnRewardedVideoShowFailedEvent(AdShowFailedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnRewardedVideoClosedEvent(AdClosedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnRewardedVideoButtonShownEvent(RewardButtonShownEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnRewardedVideoAdReview(AdReviewAnalyticsInfo info)
		{
		}

		private static void OnAppOpenClickedEvent(AdClickEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnShowAppOpenEvent(AdShownEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnAppOpenTriggeredEvent(AdTriggeredEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnAppOpenDismissedEvent(AdClosedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnAppOpenShowFailedEvent(AdShowFailedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnTriggerAudioAdEvent(AudioAdTriggerAnalyticsInfo info)
		{
		}

		private static void OnShowAudioAdEvent(AudioAdAnalyticsInfo info)
		{
		}

		private static void OnImpressionAudioAdEvent(AudioAdImpressionAnalyticsInfo info)
		{
		}

		private static void OnClickAudioAdEvent(AudioAdAnalyticsInfo info)
		{
		}

		private static void OnWatchedAudioAdEvent(AudioAdAnalyticsInfo info)
		{
		}

		private static void OnCloseAudioAdEvent(AudioAdAnalyticsInfo info)
		{
		}

		private static void OnFailedAudioAdEvent(AudioAdFailedAnalyticsInfo info)
		{
		}

		private static Dictionary<string, object> CreateAudioAdDataDictionary(AudioAdAnalyticsInfo info, bool hasGameCount = true)
		{
			return null;
		}

		private static void OnCloseAudioAdsClick()
		{
		}

		private static void OnCloseAudioAdsPurchase()
		{
		}

		private static void OnCloseAudioAdsCancel()
		{
		}

		private static void OnMrecShownEvent(AdShownEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnMrecClickedEvent(AdClickEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnNativeAdTriggeredEvent(AdTriggeredEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnNativeAdShownEvent(AdShownEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnNativeAdClickedEvent(AdClickEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnNativeAdDismissedEvent(AdClosedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnNativeAdShowFailedEvent(AdShowFailedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnCrossPromoInitEvent(CrossPromoInitInfo parameters)
		{
		}

		private static void OnCrossPromoShownEvent(CrossPromoAnalyticsInfo crossPromoInfo)
		{
		}

		private static void OnCrossPromoClickEvent(CrossPromoAnalyticsInfo crossPromoInfo)
		{
		}

		private static void OnAdIncident(AdIncidentAnalyticsInfo incidentInfo)
		{
		}

		private static void OnAdDataPassing(AdDataPassingAnalyticsInfo info)
		{
		}

		private static void OnImpressionTrackedEvent(ImpressionAnalyticsInfo impressionInfo)
		{
		}

		private static void OnApplicationFirstLaunch()
		{
		}

		private static void OnApplicationLaunchEvent()
		{
		}

		private static void OnVSDebuggerOpenedEvent()
		{
		}

		private static void OnGameStarted(GameStartedParameters parameters)
		{
		}

		private static void OnGameFinished(GameFinishedParameters parameters)
		{
		}

		private static void OnTrackItemTransactionEvent(ItemTransactionParameters parameters)
		{
		}

		private static void TrackCustomEvent(string eventName, Dictionary<string, object> customVariables, string eventType, List<VoodooSauce.AnalyticsProvider> analyticsProviders, Dictionary<string, object> contextVariables = null)
		{
		}

		private static void TrackVoodooTuneInitEvent(VoodooTuneInitAnalyticsInfo info)
		{
		}

		private static void TrackVoodooTuneAbTestAssignment(VoodooTuneAbTestAnalyticsInfo info)
		{
		}

		private static void TrackVoodooTuneAbTestExit(VoodooTuneAbTestAnalyticsInfo info)
		{
		}

		private static void TrackPerformanceMetrics(PerformanceMetricsAnalyticsInfo performanceMetrics)
		{
		}

		private static void TrackVoodooFunnel(string funnelName, string stepName, int stepPosition, Dictionary<string, object> contextVariables = null)
		{
		}

		private static void OnIapInitializationStarted()
		{
		}

		private static void OnIapInitialization(IIAPInitializationInfo info)
		{
		}

		private static void OnPurchaseStarted(IIAPStartInfo payload)
		{
		}

		private static void OnPurchaseProcessing(IIAPProcessingInfo payload)
		{
		}

		private static void OnPurchaseFailed(IIAPFailedInfo payload)
		{
		}

		private static void OnPurchaseValidated(IIAPValidatedInfo payload)
		{
		}

		private static void OnPurchaseRewarded(IIAPRewardedInfo payload)
		{
		}

		private static void OnPurchaseServerError(IIAPServerErrorInfo payload)
		{
		}

		private static void OnPurchaseEventInternal(VanEventName eventName, IIAPCommonInfo payload, Dictionary<string, object> baseData = null, Dictionary<string, object> customVariables = null)
		{
		}

		private static void AddDurationAndIterationCountInfo(Dictionary<string, object> data, IIAPCommonInfo payload)
		{
		}

		private static void OnAttributionChange(AttributionAnalyticsInfo attributionInfo)
		{
		}

		private static void OnBackupAdsClickEvent(BackupAdsAnalyticsInfo info)
		{
		}

		private static void OnBackupAdsInitEvent(CrossPromoInitInfo info)
		{
		}

		private static void OnBackupAdsShown(BackupAdsAnalyticsInfo info)
		{
		}

		private static void OnGameInteractable(LoadingTimeAnalyticsInfo loadingTimeInfo)
		{
		}

		private static void OnVoodooSauceSDKInitialized(LoadingTimeAnalyticsInfo loadingTimeInfo)
		{
		}

		private static void OnUnityEngineStarted(LoadingTimeAnalyticsInfo loadingTimeInfo)
		{
		}

		private static void TrackLoadingTimeEvent(string stepName, LoadingTimeAnalyticsInfo loadingTimeInfo)
		{
		}
	}
}
