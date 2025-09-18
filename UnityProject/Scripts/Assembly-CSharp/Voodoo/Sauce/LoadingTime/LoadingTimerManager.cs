namespace Voodoo.Sauce.LoadingTime
{
	internal class LoadingTimerManager
	{
		private readonly LoadingTimer _globalTimer;

		private readonly long _totalPauseTimeBeforeUnityInit;

		private LoadingTimer _voodooSauceSDKTimer;

		private readonly LoadingTimer _unityTimer;

		private LoadingTimer _privacyTimer;

		private LoadingTimer _attTimer;

		internal long GetSessionId()
		{
			return 0L;
		}

		internal void Pause()
		{
		}

		internal void Unpause()
		{
		}

		internal long GetGlobalLoadingTimeStartTimestamp()
		{
			return 0L;
		}

		internal long GetGlobalLoadingTimeEndTimestamp()
		{
			return 0L;
		}

		internal long GetGlobalLoadingTimeDuration()
		{
			return 0L;
		}

		internal long GetRealGlobalLoadingTimeDuration()
		{
			return 0L;
		}

		internal void StopGlobalLoadingTimer()
		{
		}

		internal bool IsGlobalLoadingTimerStopped()
		{
			return false;
		}

		internal void StartVoodooSauceSDKLoadingTimer()
		{
		}

		internal long GetVoodooSauceSDKLoadingTimeStartTimestamp()
		{
			return 0L;
		}

		internal long GetVoodooSauceSDKLoadingTimeEndTimestamp()
		{
			return 0L;
		}

		internal void StopVoodooSauceSDKLoadingTimer()
		{
		}

		internal long GetVoodooSauceSDKLoadingTimeDuration()
		{
			return 0L;
		}

		internal long GetVoodooSauceSDKRealLoadingTimeDuration()
		{
			return 0L;
		}

		internal long GetUnityLoadingTimeStartTimestamp()
		{
			return 0L;
		}

		internal long GetUnityLoadingTimeEndTimestamp()
		{
			return 0L;
		}

		internal long GetUnityLoadingTimeDuration()
		{
			return 0L;
		}

		internal void StopUnityLoadingTimer()
		{
		}

		internal void StartPrivacyDisplayingTimer()
		{
		}

		internal void StopPrivacyDisplayingTimer()
		{
		}

		internal long GetPrivacyDisplayingTimeStartTimestamp()
		{
			return 0L;
		}

		internal long GetPrivacyDisplayingTimeEndTimestamp()
		{
			return 0L;
		}

		internal long GetPrivacyDisplayingTimeDuration()
		{
			return 0L;
		}

		internal void StartAttDisplayingTimer()
		{
		}

		internal void StopAttDisplayingTimer()
		{
		}

		internal long GetAttDisplayingTimeStartTimestamp()
		{
			return 0L;
		}

		internal long GetAttDisplayingTimeEndTimestamp()
		{
			return 0L;
		}

		internal long GetAttDisplayingTimeDuration()
		{
			return 0L;
		}
	}
}
