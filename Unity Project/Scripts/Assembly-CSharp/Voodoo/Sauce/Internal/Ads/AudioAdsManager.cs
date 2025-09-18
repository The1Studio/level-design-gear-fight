using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	internal class AudioAdsManager : IAudioAdsManager
	{
		private const string TAG = "AudioAdsManager";

		private static IAudioAdsManager _instance;

		private bool _isEnabled;

		private AudioAdConfig _currentAudioAdConfig;

		private IAudioAdsNetwork _currentAudioAdNetwork;

		private int _gameStartCounter;

		private float _lastAudioAdTime;

		private string _currentImpressionId;

		private IAudioAdPositionBehaviour _audioAdPositionObject;

		private IAudioAdsAnalyticsManager _audioAdsAnalyticsManager;

		private Func<bool> _checkPremiumOrIapSubscribedFunction;

		private AudioAdsGracePeriod _gracePeriod;

		private AudioAdsGracePeriodRunner _gracePeriodRunner;

		internal static IAudioAdsManager Instance => null;

		private string AdNetworkName => null;

		public event Action OnUserClose
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

		public event Action OnShown
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

		public event Action OnClosed
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

		public void Initialize(IVoodooSettings settings, [CanBeNull] AudioAdConfig voodooTuneConfig, bool consent, bool isCcpaApplicable, [NotNull] Func<bool> checkPremiumOrIapSubscribedFunction, IAudioAdsAnalyticsManager audioAdsAnalyticsManager)
		{
		}

		public bool IsEnabled()
		{
			return false;
		}

		public IAudioAdsNetwork GetCurrentAudioAdNetwork()
		{
			return null;
		}

		public string GetAdNetworkName()
		{
			return null;
		}

		public AudioAdConfig GetCurrentAudioAdConfig()
		{
			return null;
		}

		public void ShowOrHideAudioAd()
		{
		}

		public void LinkAudioAdPositionToObject(IAudioAdPositionBehaviour prefab)
		{
		}

		public (float, float) GetTimer()
		{
			return default((float, float));
		}

		public AudioAdState GetState()
		{
			return default(AudioAdState);
		}

		public double GetLoadedCpm()
		{
			return 0.0;
		}

		private void RegisterCallbacks()
		{
		}

		private void OnPremiumStatusChanged(bool value)
		{
		}

		private bool AssignAudioAdNetwork()
		{
			return false;
		}

		private void InitializeAudioAdNetwork(bool consent, bool isCcpaApplicable)
		{
		}

		private bool ShowAudioAd()
		{
			return false;
		}

		public void OnApplicationPause(bool pauseStatus)
		{
		}

		internal void OnRvOrFsShow()
		{
		}

		internal void OnGameStart(GameStartedParameters parameters)
		{
		}

		internal void OnGameFinished(GameFinishedParameters parameters)
		{
		}

		private void OnUserSkippedTriggered()
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
