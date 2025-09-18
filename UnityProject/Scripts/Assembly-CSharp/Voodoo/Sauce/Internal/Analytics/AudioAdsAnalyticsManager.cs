using System;
using System.Runtime.CompilerServices;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class AudioAdsAnalyticsManager : IAudioAdsAnalyticsManager
	{
		private AudioAdAnalyticsInfo _currentImpressionInfo;

		private string _currentNetworkName;

		public event Action<AudioAdTriggerAnalyticsInfo> OnAudioAdTriggerEvent
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

		public event Action<AudioAdAnalyticsInfo> OnAudioAdShownEvent
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

		public event Action<AudioAdImpressionAnalyticsInfo> OnAudioAdImpressionEvent
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

		public event Action<AudioAdAnalyticsInfo> OnAudioAdClickEvent
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

		public event Action<AudioAdAnalyticsInfo> OnAudioAdWatchedEvent
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

		public event Action<AudioAdAnalyticsInfo> OnAudioAdCloseEvent
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

		public event Action<AudioAdFailedAnalyticsInfo> OnAudioAdFailedEvent
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

		private void SetAudioAdInfoCommonParameters(AudioAdAnalyticsInfo info)
		{
		}

		public void TrackAudioAdTrigger(string networkName, bool adLoaded)
		{
		}

		public void TrackAudioAdShown(string networkName)
		{
		}

		public void TrackAudioAdImpression(string networkName, double revenue)
		{
		}

		public void TrackAudioAdClicked(string networkName)
		{
		}

		public void TrackAudioAdWatched(string networkName)
		{
		}

		public void TrackAudioAdClosed(string networkName)
		{
		}

		public void TrackAudioAdFailed(string networkName, string errorCode)
		{
		}

		public void PrepareNewImpressionData()
		{
		}

		private void TryPrepareNewImpressionData()
		{
		}

		private void CallOnMainThread(Action callback)
		{
		}
	}
}
