namespace Voodoo.Sauce.Internal.Ads
{
	public class AdDisplayConditions
	{
		internal enum AdConditionState
		{
			FirstInterstitialReadyToShow = 0,
			FirstInterstitialTooEarly = 1,
			InterstitialTooEarlyAndNotEnoughGamesPlayed = 2,
			EnoughGamesWerePlayed = 3,
			RewardedVideoWasPlayedRecently = 4,
			InterstitialReadyToShow = 5,
			InterstitialWasPlayedRecently = 6,
			AppOpenWasPlayedRecently = 7,
			AppOpenReadyToShow = 8,
			AppOpenTooEarly = 9,
			Disabled = 10
		}

		private const string TAG = "AdDisplayConditions";

		private const string PREFS_FIRST_APP_LAUNCH = "VoodooSauce.Interstitial.FirstAppLaunch";

		private const string TIME_SPENT_IN_APP_SINCE_FIRST_APP_LAUNCH = "VoodooSauce.Interstitial.TimeSpentInAppAfterFirstLaunch";

		private const int DEFAULT_DELAY_IN_SECONDS_BETWEEN_REWARDED_VIDEO_AND_INTERSTITIAL = 5;

		private const float DEFAULT_DELAY_IN_SECONDS_IN_BACKGROUND_BEFORE_APP_OPEN_AD = 60f;

		private const float DEFAULT_DELAY_IN_SECONDS_BETWEEN_APP_OPEN_ADS = 60f;

		private const float DEFAULT_DELAY_IN_SECONDS_BETWEEN_INTERSTITIAL_AND_APP_OPEN_AD = 0f;

		private const float DEFAULT_DELAY_IN_SECONDS_BETWEEN_REWARDED_VIDEO_AND_APP_OPEN_AD = 5f;

		private const float DEFAULT_DELAY_IN_SECONDS_BETWEEN_APP_OPEN_AD_AND_INTERSTITIAL = 0f;

		private readonly int _delayInSecondsBeforeFirstInterstitialAd;

		private readonly int _cumulativeDelayInSecondsBeforeFirstInterstitialAd;

		private readonly int _delayInSecondsBeforeSessionFirstInterstitial;

		private readonly int _delayInSecondsBetweenInterstitialAds;

		private readonly int _maxGamesPlayedBetweenInterstitials;

		private readonly int _delayInSecondsBetweenRewardedVideoAndInterstitial;

		private readonly float _delayInSecondsInBackgroundBeforeAppOpenAd;

		private readonly float _delayInSecondsBetweenAppOpenAds;

		private readonly float _delayInSecondsBetweenInterstitialAndAppOpenAd;

		private readonly float _delayInSecondsBetweenRewardedVideoAndAppOpenAd;

		private readonly float _delayInSecondsBetweenAppOpenAdAndInterstitial;

		private bool _firstEverInterstitialDisplayed;

		private bool _firstSessionInterstitialDisplayed;

		private int _gamesPlayedSinceLastInterstitial;

		private float? _lastInterstitialTime;

		private readonly bool _rewardedVideosDelayFullscreen;

		private float? _lastRewardedVideoTime;

		private bool _appOpenAdEnabled;

		private float? _lastAppOpenTime;

		private float _amountOfTimeInBackground;

		private float? _backgroundStartTime;

		private float _timeSpentInAppSinceFirstLaunch;

		public AdDisplayConditions(AdDisplayConditions currentAdDisplayConditions, int delayInSecondsBeforeFirstInterstitialAd, int delayInSecondsBeforeSessionFirstInterstitial, int delayInSecondsBetweenInterstitialAds, int maxGamesBetweenInterstitialAds, int delayInSecondsBetweenRewardedVideoAndInterstitial, float delayInSecondsBetweenAppOpenAdAndInterstitial, int cumulativeDelayInSecondsBeforeFirstInterstitialAd = -1)
		{
		}

		public AdDisplayConditions(int delayInSecondsBeforeFirstInterstitialAdAd, int delayInSecondsBeforeSessionFirstInterstitial, int delayInSecondsBetweenInterstitialAds, int maxGamesBetweenInterstitialAds, int delayInSecondsBetweenRewardedVideoAndInterstitial, float delayInSecondsInBackgroundBeforeAppOpenAd, float delayInSecondsBetweenAppOpenAds, float delayInSecondsBetweenInterstitialAndAppOpenAd, float delayInSecondsBetweenRewardedVideoAndAppOpenAd, float delayInSecondsBetweenAppOpenAdAndInterstitial, int cumulativeDelayInSecondsBeforeSessionFirstInterstitial = -1, bool appOpenAdEnabled = false)
		{
		}

		public void IncrementGamesPlayed()
		{
		}

		public void OnApplicationFocus(bool isFocused)
		{
		}

		public void OnApplicationPause(bool pauseStatus, bool isAdShowing)
		{
		}

		public void ResetBackgroundTimer()
		{
		}

		public void RewardedVideoDisplayed(bool completed)
		{
		}

		public string InterstitialConditionsToString()
		{
			return null;
		}

		public float GetTotalTimeSpentPlayingInSeconds()
		{
			return 0f;
		}

		public void InterstitialDisplayed(bool shown)
		{
		}

		public bool AreInterstitialConditionsMet()
		{
			return false;
		}

		internal AdConditionState GetCurrentInterstitialConditionState()
		{
			return default(AdConditionState);
		}

		public string GetInterstitialConditionTimeString()
		{
			return null;
		}

		public string GetInterstitialConditionStatusString()
		{
			return null;
		}

		public string AppOpenConditionsToString()
		{
			return null;
		}

		public void AppOpenDisplayed()
		{
		}

		internal void EnableAppOpenAd()
		{
		}

		internal void DisableAppOpenAd()
		{
		}

		public bool AreAppOpenConditionsMet()
		{
			return false;
		}

		internal AdConditionState GetCurrentAppOpenConditionState()
		{
			return default(AdConditionState);
		}

		public string GetAppOpenConditionTimeString()
		{
			return null;
		}

		public string GetAppOpenConditionStatusString()
		{
			return null;
		}

		internal void IncrementBackgroundTime(float seconds)
		{
		}

		internal void ResetLastAppOpenTime()
		{
		}

		internal void SetLastAppOpenTime(float secondsAgo)
		{
		}

		internal void ResetLastInterstitialTime()
		{
		}

		internal void SetLastInterstitialTime(float secondsAgo)
		{
		}

		internal void ResetLastRewardedVideoTime()
		{
		}

		internal void SetLastRewardedVideoTime(float secondsAgo)
		{
		}

		internal void ResetGamesPlayed()
		{
		}

		internal void SetGamesPlayed(int gamesPlayed)
		{
		}

		internal void SetFirstEverInterstitialDisplayed()
		{
		}

		internal void ResetFirstEverInterstitialDisplayed()
		{
		}
	}
}
