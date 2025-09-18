namespace Voodoo.Sauce.Internal.Analytics
{
	internal class AdnAnalyticsProvider : IAnalyticsProvider
	{
		private const string TAG = "AdnAnalyticsProvider";

		private AdnAppInfo _appInfo;

		private AdnAdsInfo _adsInfo;

		public void Instantiate(string mediation)
		{
		}

		public void Initialize(AnalyticsProviderInfo info)
		{
		}

		private void RegisterEvents()
		{
		}

		private void OnGameFinished(GameFinishedParameters parameters)
		{
		}

		private void OnImpressionTrackedEvent(ImpressionAnalyticsInfo info)
		{
		}

		private void OnInterstitialClickedEvent(AdClickEventAnalyticsInfo info)
		{
		}

		private void OnInterstitialShownEvent(AdShownEventAnalyticsInfo info)
		{
		}

		private void OnInterstitialDismissedEvent(AdClosedEventAnalyticsInfo info)
		{
		}

		private void OnRewardedVideoClickedEvent(AdClickEventAnalyticsInfo info)
		{
		}

		private void OnRewardedVideoShownEvent(AdShownEventAnalyticsInfo info)
		{
		}

		private void OnRewardedVideoClosedEvent(AdClosedEventAnalyticsInfo info)
		{
		}

		private void OnInterstitialLoadRequestEvent(AdAnalyticsInfo info)
		{
		}

		private void OnInterstitialLoadedEvent(AdEventAnalyticsInfo info)
		{
		}

		private void OnRewardedLoadRequestEvent(AdAnalyticsInfo info)
		{
		}

		private void OnRewardedVideoLoadedEvent(AdEventAnalyticsInfo info)
		{
		}

		private void OnRewardedVideoAdReviewEvent(AdReviewAnalyticsInfo info)
		{
		}

		private void OnInterstitialAdReviewEvent(AdReviewAnalyticsInfo info)
		{
		}

		private void OnAttributionChangedEvent(AttributionAnalyticsInfo info)
		{
		}

		private void OnLoadRequestEvent(string placement, AdAnalyticsInfo info)
		{
		}

		private void OnAdLoadedEvent(string placement, AdEventAnalyticsInfo info)
		{
		}

		private void TrackPerformanceMetrics(PerformanceMetricsAnalyticsInfo metrics)
		{
		}

		private void SendSdkExtrasParameters()
		{
		}
	}
}
