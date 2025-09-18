using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	[Preserve]
	public class OdeeoAudioAdsNetwork : IAudioAdsNetwork
	{
		private const string TAG = "OdeeoAudioAdsNetwork";

		private const int LOGO_SIZE = 70;

		private const string AD_BLOCKED = "AdBlocked";

		private AdUnit _logoAdUnit;

		private OdeeoConfig _odeeoConfig;

		private IAudioAdsAnalyticsManager _analytics;

		private bool _showing;

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

		private static string GetRelevantStoreId(VoodooSettings settings)
		{
			return null;
		}

		private void OnInitialized()
		{
		}

		private void OnImpression(AdUnit.ImpressionData data)
		{
		}

		private void OnAdBlocked()
		{
		}

		private void OnAdClosed()
		{
		}

		private void OnAdUserClosed()
		{
		}

		private void OnInitializationFailed(int errorParam, string error)
		{
		}

		public void OnApplicationPause(bool pauseStatus)
		{
		}

		public AudioAdState GetState()
		{
			return default(AudioAdState);
		}

		public bool ShowAudioAd(IAudioAdPositionBehaviour prefab)
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

		private void SetPosition(AudioAdPosition position, Vector2Int offset)
		{
		}

		private void RaiseAdTrigger(bool adLoaded)
		{
		}

		private void RaiseAdFailure(string errorCode)
		{
		}
	}
}
