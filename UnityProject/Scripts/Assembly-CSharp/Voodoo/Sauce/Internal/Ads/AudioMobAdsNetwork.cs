using System;
using System.Runtime.CompilerServices;
using AudioMob;
using UnityEngine;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	[Preserve]
	public class AudioMobAdsNetwork : IAudioAdsNetwork
	{
		private const string TAG = "AudioMobAdsNetwork";

		private AudioMobPlugin _audioMobPlugin;

		private AudioMobCanvas _audioMobCanvas;

		private IAudioAd _adData;

		private IAdAvailability _adAvailability;

		private bool _stoppedCalled;

		private AudioMobConfig _config;

		private bool _sdkInitialized;

		private bool _initializeCalled;

		private IAudioAdsAnalyticsManager _analytics;

		public string Name => null;

		public event Action UserSkipTriggered
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

		public event Action AudioAdFailed
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

		public event Action AudioAdShown
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

		public event Action AudioAdClosed
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

		public void Initialize(bool consent, bool isCcpaApplicable, IAudioAdsAnalyticsManager analytics)
		{
		}

		private void OnAudioMobInitialized(bool success)
		{
		}

		private void RefreshAvailability()
		{
		}

		private void OnAdAvailabilityReceived(IAdAvailability data)
		{
		}

		public void OnApplicationPause(bool pauseStatus)
		{
		}

		public AudioAdState GetState()
		{
			return default(AudioAdState);
		}

		public bool ShowAudioAd(IAudioAdPositionBehaviour positionObject)
		{
			return false;
		}

		public void CloseAudioAd()
		{
		}

		public bool IsShowingAd()
		{
			return false;
		}

		public void OnFullscreenAdShow()
		{
		}

		public double GetLoadedCpm()
		{
			return 0.0;
		}

		private bool IsNetworkReadyToShowAd()
		{
			return false;
		}

		private void OnAdRequestCompleted(AdRequestResult result, IAudioAd data)
		{
		}

		private void OnAdPlaybackStarted(IAudioAd data)
		{
		}

		private void OnAdPlaybackCompleted(AdPlaybackResult result)
		{
		}

		private void SetPosition(Vector2 percentPosition)
		{
		}

		private void OnAdClicked()
		{
		}

		private void RaiseAdTrigger(bool adLoaded)
		{
		}

		private void RaiseAdFailure<T>(T result) where T : Enum
		{
		}
	}
}
