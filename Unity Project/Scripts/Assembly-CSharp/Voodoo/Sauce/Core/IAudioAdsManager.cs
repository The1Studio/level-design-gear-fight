using System;
using Voodoo.Sauce.Internal.Ads;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Core
{
	public interface IAudioAdsManager
	{
		event Action OnShown;

		event Action OnClosed;

		event Action OnUserClose;

		void Initialize(IVoodooSettings settings, AudioAdConfig config, bool adsConsent, bool isCcpaApplicable, Func<bool> isPremiumOrIAPSubscribed, IAudioAdsAnalyticsManager analytics);

		void OnApplicationPause(bool pauseStatus);

		void LinkAudioAdPositionToObject(IAudioAdPositionBehaviour audioAd);

		void ShowOrHideAudioAd();

		bool IsEnabled();

		AudioAdState GetState();

		string GetAdNetworkName();

		AudioAdConfig GetCurrentAudioAdConfig();

		IAudioAdsNetwork GetCurrentAudioAdNetwork();

		(float, float) GetTimer();

		double GetLoadedCpm();
	}
}
