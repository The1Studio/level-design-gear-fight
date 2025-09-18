using System;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	public interface IAudioAdsNetwork
	{
		string Name { get; }

		event Action UserSkipTriggered;

		event Action AudioAdFailed;

		event Action AudioAdShown;

		event Action AudioAdClosed;

		void Initialize(bool consent, bool isCcpaApplicable, IAudioAdsAnalyticsManager analytics);

		void OnApplicationPause(bool pauseStatus);

		AudioAdState GetState();

		bool ShowAudioAd(IAudioAdPositionBehaviour position);

		void CloseAudioAd();

		bool IsShowingAd();

		void OnFullscreenAdShow();

		double GetLoadedCpm();
	}
}
