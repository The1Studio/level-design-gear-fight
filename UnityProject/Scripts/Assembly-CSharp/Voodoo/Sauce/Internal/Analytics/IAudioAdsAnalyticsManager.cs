using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	public interface IAudioAdsAnalyticsManager
	{
		event Action<AudioAdTriggerAnalyticsInfo> OnAudioAdTriggerEvent;

		event Action<AudioAdAnalyticsInfo> OnAudioAdShownEvent;

		event Action<AudioAdImpressionAnalyticsInfo> OnAudioAdImpressionEvent;

		event Action<AudioAdAnalyticsInfo> OnAudioAdClickEvent;

		event Action<AudioAdAnalyticsInfo> OnAudioAdWatchedEvent;

		event Action<AudioAdAnalyticsInfo> OnAudioAdCloseEvent;

		event Action<AudioAdFailedAnalyticsInfo> OnAudioAdFailedEvent;

		void TrackAudioAdTrigger(string networkName, bool adLoaded);

		void TrackAudioAdShown(string networkName);

		void TrackAudioAdImpression(string networkName, double revenue);

		void TrackAudioAdClicked(string networkName);

		void TrackAudioAdWatched(string networkName);

		void TrackAudioAdClosed(string networkName);

		void TrackAudioAdFailed(string networkName, string errorCode);

		void PrepareNewImpressionData();
	}
}
