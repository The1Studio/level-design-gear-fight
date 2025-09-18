using System;
using System.Runtime.CompilerServices;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	[Preserve]
	public class CompositeAudioAdsNetwork : IAudioAdsNetwork
	{
		public class PositionData
		{
			public IAudioAdPositionBehaviour obj;
		}

		private const char AD_NETWORK_SEPARATOR = '/';

		private IAudioAdsNetwork _currentAdNetwork;

		private IAudioAdsNetwork _mainAdNetwork;

		private IAudioAdsNetwork _fallbackAdNetwork;

		private PositionData _positionData;

		public string Name { get; private set; }

		internal IAudioAdsNetwork CurrentAdNetwork => null;

		internal IAudioAdsNetwork MainAdNetwork => null;

		internal IAudioAdsNetwork FallbackAdNetwork => null;

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

		public bool TrySetFallback(string adNetworks)
		{
			return false;
		}

		public void Initialize(bool consent, bool isCcpaApplicable, IAudioAdsAnalyticsManager analytics)
		{
		}

		public void OnApplicationPause(bool pauseStatus)
		{
		}

		public AudioAdState GetState()
		{
			return default(AudioAdState);
		}

		public bool ShowAudioAd(IAudioAdPositionBehaviour position)
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

		private void RefreshName()
		{
		}

		private bool TryShowAudioAd()
		{
			return false;
		}

		private bool TryShowAudioAd(IAudioAdsNetwork network)
		{
			return false;
		}

		private void OnUserSkipTriggered()
		{
		}

		private void OnAudioAdShown()
		{
		}

		private void OnAudioAdClosed()
		{
		}

		private void OnAudioAdFailed()
		{
		}
	}
}
