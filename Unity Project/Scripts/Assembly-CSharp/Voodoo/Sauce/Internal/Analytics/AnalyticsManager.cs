using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using Voodoo.Sauce.Ads;
using Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Models;
using Voodoo.Sauce.LoadingTime;
using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal static class AnalyticsManager
	{
		internal static class Banner
		{
			internal static void Shown(AdEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void Clicked(AdEventAnalyticsInfo adAnalyticsInfo)
			{
			}
		}

		internal static class Interstitial
		{
			internal static RewardPopUpType RewardFsType;

			internal static void LoadRequest(AdAnalyticsInfo adAnalyticsInfo)
			{
			}

			public static void Loaded(AdLoadedAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void Triggered(AdTriggeredEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void Shown(AdShownEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void Clicked(AdClickEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void Dismissed(AdClosedEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void FailedToShow(AdShowFailedEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void AdReview(AdReviewAnalyticsInfo adAnalyticsInfo)
			{
			}
		}

		internal static class RewardedVideo
		{
			internal static void LoadRequest(AdAnalyticsInfo adAnalyticsInfo)
			{
			}

			public static void Loaded(AdEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void ButtonShown(RewardButtonShownEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void Clicked(AdClickEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void Shown(AdShownEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void Closed(AdClosedEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			internal static void FailedToShow(AdShowFailedEventAnalyticsInfo adAnalyticsInfo)
			{
			}

			public static void AdReview(AdReviewAnalyticsInfo info)
			{
			}
		}

		private const string TAG = "VoodooAnalytics";

		private const string NO_GAME_LEVEL = "game";

		private static bool HasGameInteractableCalled;

		private static readonly AnalyticsSettings Settings;

		private static AudioAdsAnalyticsManager _audioAdsAnalyticsManager;

		private static bool? _isGameAnalyticsAvailable;

		private static List<VoodooSauce.AnalyticsProvider> DefaultAnalyticsProvider;

		private static List<IAnalyticsProvider> AnalyticsProviders;

		private static readonly AnalyticsEventTimer _gameTimer;

		private static readonly AnalyticsEventTimer _adsTimer;

		internal static readonly LoadingTimerManager LoadingTimes;

		private static bool _isInitialized;

		internal static bool HasGameStarted { get; private set; }

		internal static IAudioAdsAnalyticsManager AudioAds => null;

		internal static event Action<AdEventAnalyticsInfo> OnBannerShownEvent
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

		internal static event Action<AdEventAnalyticsInfo> OnBannerClickedEvent
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

		internal static event Action<AdAnalyticsInfo> OnInterstitialLoadRequestEvent
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

		internal static event Action<AdLoadedAnalyticsInfo> OnInterstitialLoadedEvent
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

		internal static event Action<AdTriggeredEventAnalyticsInfo> OnInterstitialTriggeredEvent
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

		internal static event Action<AdShownEventAnalyticsInfo> OnInterstitialShownEvent
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

		internal static event Action<AdClickEventAnalyticsInfo> OnInterstitialClickedEvent
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

		internal static event Action<AdClosedEventAnalyticsInfo> OnInterstitialDismissedEvent
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

		internal static event Action<AdShowFailedEventAnalyticsInfo> OnInterstitialShowFailedEvent
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

		internal static event Action<AdReviewAnalyticsInfo> OnInterstitialAdReviewEvent
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

		internal static event Action<RewardButtonShownEventAnalyticsInfo> OnRewardedVideoButtonShownEvent
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

		internal static event Action<AdAnalyticsInfo> OnRewardedVideoLoadRequestEvent
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

		internal static event Action<AdEventAnalyticsInfo> OnRewardedVideoLoadedEvent
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

		internal static event Action<AdShownEventAnalyticsInfo> OnRewardedVideoShownEvent
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

		internal static event Action<AdClickEventAnalyticsInfo> OnRewardedVideoClickedEvent
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

		internal static event Action<AdClosedEventAnalyticsInfo> OnRewardedVideoClosedEvent
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

		internal static event Action<AdShowFailedEventAnalyticsInfo> OnRewardedVideoShowFailedEvent
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

		internal static event Action<AdReviewAnalyticsInfo> OnRewardedVideoAdReviewEvent
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

		internal static event Action<string, string, string, Dictionary<string, object>, Dictionary<string, object>> OnTrackEvent
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

		internal static event Action<int, bool> OnGamePlayed
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

		internal static event Action<bool> OnConsentChangeEvent
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

		internal static event Action OnVSDebuggerOpenedEvent
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

		internal static event Action<GameStartedParameters> OnGameStartedEvent
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

		internal static event Action<GameFinishedParameters> OnGameFinishedEvent
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

		internal static event Action<string, Dictionary<string, object>, string, List<VoodooSauce.AnalyticsProvider>, Dictionary<string, object>> OnTrackCustomEvent
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

		internal static event Action<ItemTransactionParameters> OnTrackItemTransactionEvent
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

		internal static event Action OnNoAdsClickEvent
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

		internal static event Action OnApplicationFirstLaunchEvent
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

		internal static event Action OnApplicationLaunchEvent
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

		internal static event Action<AdShownEventAnalyticsInfo> OnShowAppOpenEvent
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

		internal static event Action<AdTriggeredEventAnalyticsInfo> OnAppOpenTriggeredEvent
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

		internal static event Action<AdClickEventAnalyticsInfo> OnAppOpenClickedEvent
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

		internal static event Action<AdClosedEventAnalyticsInfo> OnAppOpenDismissedEvent
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

		internal static event Action<AdShowFailedEventAnalyticsInfo> OnAppOpenShowFailedEvent
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

		internal static event Action<AdAnalyticsInfo> OnAppOpenLoadRequestEvent
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

		internal static event Action<AdShownEventAnalyticsInfo> OnMrecShownEvent
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

		internal static event Action<AdClickEventAnalyticsInfo> OnMrecClickedEvent
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

		internal static event Action<AdShownEventAnalyticsInfo> OnNativeAdShownEvent
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

		internal static event Action<AdTriggeredEventAnalyticsInfo> OnNativeAdTriggeredEvent
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

		internal static event Action<AdClickEventAnalyticsInfo> OnNativeAdClickedEvent
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

		internal static event Action<AdClosedEventAnalyticsInfo> OnNativeAdDismissedEvent
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

		internal static event Action<AdShowFailedEventAnalyticsInfo> OnNativeAdShowFailedEvent
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

		internal static event Action<ImpressionAnalyticsInfo> OnImpressionTrackedEvent
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

		internal static event Action<CrossPromoAnalyticsInfo> OnCrossPromoShownEvent
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

		internal static event Action<CrossPromoAnalyticsInfo> OnCrossPromoClickEvent
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

		internal static event Action<CrossPromoInitInfo> OnCrossPromoInitEvent
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

		internal static event Action<string> OnCrossPromoErrorEvent
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

		internal static event Action<VoodooTuneInitAnalyticsInfo> OnTrackVoodooTuneInitEvent
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

		internal static event Action<VoodooTuneAbTestAnalyticsInfo> OnTrackVoodooTuneAbTestAssignmentEvent
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

		internal static event Action<VoodooTuneAbTestAnalyticsInfo> OnTrackVoodooTuneAbTestExitEvent
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

		internal static event Action<PerformanceMetricsAnalyticsInfo> OnTrackPerformanceMetricsEvent
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

		internal static event Action<string, string, int, Dictionary<string, object>> OnTrackVoodooFunnelEvent
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

		internal static event Action<ConversionEventInfo> OnTrackConversionEvent
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

		internal static event Action<AttributionAnalyticsInfo> OnAttributionChangedEvent
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

		internal static event Action<LoadingTimeAnalyticsInfo> OnGameInteractableEvent
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

		internal static event Action<LoadingTimeAnalyticsInfo> OnVoodooSauceSDKInitializedEvent
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

		internal static event Action<LoadingTimeAnalyticsInfo> OnUnityEngineStartedEvent
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

		internal static event Action<IIAPInitializationInfo> OnIapInitialization
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

		internal static event Action OnIapInitializationStarted
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

		internal static event Action<IIAPStartInfo> OnPurchaseStarted
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

		internal static event Action<IIAPProcessingInfo> OnPurchaseProcessing
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

		internal static event Action<IIAPFailedInfo> OnPurchaseFailed
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

		internal static event Action<IIAPValidatedInfo> OnPurchaseValidated
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

		internal static event Action<IIAPRewardedInfo> OnPurchaseRewarded
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

		internal static event Action<IIAPServerErrorInfo> OnPurchaseServerError
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

		internal static event Action<IIAPTrackingInfo> OnTrackPurchaseEvent
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

		internal static event Action<BackupAdsAnalyticsInfo> OnBackupAdsClickEvent
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

		internal static event Action<CrossPromoInitInfo> OnBackupAdsInitEvent
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

		internal static event Action<BackupAdsAnalyticsInfo> OnBackupAdsShownEvent
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

		internal static event Action OnCloseBannerClick
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

		internal static event Action OnCloseBannerPurchase
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

		internal static event Action OnCloseBannerCancel
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

		internal static event Action OnCloseAudioAdsClick
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

		internal static event Action OnCloseAudioAdsPurchase
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

		internal static event Action OnCloseAudioAdsCancel
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

		internal static event Action<AdIncidentAnalyticsInfo> OnAdIncident
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

		internal static event Action<AdDataPassingAnalyticsInfo> OnAdDataPassing
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

		private static IEnumerable<IAnalyticsAttributionProvider> AnalyticsAttributionProviders()
		{
			return null;
		}

		internal static void Instantiate(string mediation)
		{
		}

		private static void InitializePerformanceMetricMonitor()
		{
		}

		internal static void Initialize(PrivacyCore.GdprConsent consent)
		{
		}

		internal static AttributionData GetAttributionData()
		{
			return null;
		}

		internal static void SetConsent(bool consent)
		{
		}

		internal static void SetLogLevel(bool enable, LogType globalLevel)
		{
		}

		internal static bool IsGameAnalyticsAvailable()
		{
			return false;
		}

		internal static void TrackEvent(string eventName, string data = null, string eventType = null, Dictionary<string, object> customVariables = null, Dictionary<string, object> contextVariables = null)
		{
		}

		internal static void TrackIapInitializationStarted()
		{
		}

		internal static void TrackIapInitialization(IIAPInitializationInfo info)
		{
		}

		internal static void TrackPurchaseStarted(IIAPStartInfo payload)
		{
		}

		internal static void TrackPurchaseProcessing(IIAPProcessingInfo payload)
		{
		}

		internal static void TrackPurchaseFailed(IIAPFailedInfo payload)
		{
		}

		internal static void TrackPurchaseValidated(IIAPValidatedInfo payload)
		{
		}

		internal static void TrackPurchase(IIAPTrackingInfo payload)
		{
		}

		internal static void TrackPurchaseRewarded(IIAPRewardedInfo payload)
		{
		}

		internal static void TrackPurchaseServerError(IIAPServerErrorInfo payload)
		{
		}

		internal static void TrackApplicationLaunch()
		{
		}

		internal static void TrackOpenVSDebugger()
		{
		}

		internal static void TrackGameStarted(GameStartedParameters parameters)
		{
		}

		public static void TrackGamePauseButtonClicked(bool pauseStatus)
		{
		}

		internal static void TrackGameFinished(GameFinishedParameters parameters)
		{
		}

		internal static void TrackCustomEvent(string eventName, Dictionary<string, object> eventProperties, string type = null, List<VoodooSauce.AnalyticsProvider> analyticsProviders = null, Dictionary<string, object> contextVariables = null)
		{
		}

		private static void PauseGameTimer(bool pauseStatus)
		{
		}

		internal static void TrackNoAdsClick()
		{
		}

		internal static void TrackItemTransaction(ItemTransactionParameters parameters)
		{
		}

		internal static void TrackShowAppOpen(AdShownEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackAppOpenTriggered(AdTriggeredEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackAppOpenLoadRequest(AdAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackAppOpenClick(AdClickEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackAppOpenDismiss(AdClosedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackAppOpenShowFailed(AdShowFailedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackMrecShown(AdShownEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackMrecClick(AdClickEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackNativeAdShown(AdShownEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackNativeAdTriggered(AdTriggeredEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackNativeAdClick(AdClickEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackNativeAdDismiss(AdClosedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackNativeAdShowFailed(AdShowFailedEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		internal static void TrackImpression(ImpressionAnalyticsInfo impressionInfo)
		{
		}

		internal static void TrackAdIncident(AdIncidentAnalyticsInfo incidentInfo)
		{
		}

		internal static void TrackAdDataPassing(AdDataPassingAnalyticsInfo info)
		{
		}

		internal static void TrackCrossPromoShown(CrossPromoAnalyticsInfo crossPromoInfo)
		{
		}

		internal static void TrackCrossPromoClick(CrossPromoAnalyticsInfo crossPromoInfo)
		{
		}

		internal static void TrackCrossPromoError(string error)
		{
		}

		internal static void TrackCrossPromoInit(CrossPromoInitInfo info)
		{
		}

		internal static void TrackVoodooTuneInitEvent(VoodooTuneInitAnalyticsInfo info)
		{
		}

		public static void TrackVoodooTuneAbTestAssignment(VoodooTuneAbTestAnalyticsInfo abTestAnalyticsInfo)
		{
		}

		public static void TrackVoodooTuneAbTestExit(VoodooTuneAbTestAnalyticsInfo abTestAnalyticsInfo)
		{
		}

		internal static void TrackPerformanceMetrics(PerformanceMetricsAnalyticsInfo info)
		{
		}

		[CanBeNull]
		internal static BaseAnalyticsProviderWithLogger GetProviderLoggerWithEnum(VoodooSauce.AnalyticsProvider providerEnum)
		{
			return null;
		}

		internal static void TrackVoodooFunnel(string funnelName, string stepName, int stepPosition, Dictionary<string, object> contextVariables = null)
		{
		}

		internal static void TrackAttribution(AttributionAnalyticsInfo attributionInfo)
		{
		}

		internal static void OnGameInteractable()
		{
		}

		internal static void StartTrackingVoodooSauceSDKInitializationLoadingTime()
		{
		}

		internal static void TrackVoodooSauceSDKInitializationLoadingTime()
		{
		}

		internal static void TrackUnityEngineStarted()
		{
		}

		internal static void StartPrivacyDisplayingTimer()
		{
		}

		internal static void StopPrivacyDisplayingTimer()
		{
		}

		internal static void StartAttDisplayingTimer()
		{
		}

		internal static void StopAttDisplayingTimer()
		{
		}

		internal static void PauseTrackingLoadingTimes()
		{
		}

		internal static void UnpauseTrackingLoadingTimes()
		{
		}

		internal static void TrackBackupAdsClick(BackupAdsAnalyticsInfo backupAdsInfo)
		{
		}

		internal static void TrackBackupAdsInit(CrossPromoInitInfo backupfsInitInfo)
		{
		}

		internal static void TrackBackupAdsShown(BackupAdsAnalyticsInfo backupAdsInfo)
		{
		}

		public static void OnApplicationPause(bool pauseStatus)
		{
		}

		public static void OnApplicationFocus(bool hasFocus)
		{
		}

		internal static void TrackCloseBannerClick()
		{
		}

		internal static void TrackCloseBannerPurchase()
		{
		}

		internal static void TrackCloseBannerCancel()
		{
		}

		internal static void TrackCloseAudioAdsClick()
		{
		}

		internal static void TrackCloseAudioAdsPurchase()
		{
		}

		internal static void TrackCloseAudioAdsCancel()
		{
		}
	}
}
