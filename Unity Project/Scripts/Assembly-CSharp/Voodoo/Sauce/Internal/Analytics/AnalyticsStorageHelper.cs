using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class AnalyticsStorageHelper : IAnalyticStorage
	{
		private const string GAME_COUNT_KEY = "VoodooSauce_GameCount";

		private const string SUCCESSFUL_GAME_COUNT_KEY = "VoodooSauce_SuccessfulGameCount";

		private const string CURRENT_LEVEL_KEY = "VoodooSauce_Level";

		private const string APP_LAUNCH_COUNT_KEY = "VoodooSauce_AppLaunchCount";

		private const string HIGHEST_SCORE_KEY = "VoodooSauce_HighScore";

		private const string FIRST_APP_LAUNCH_DATE_KEY = "VoodooSauce_FirstAppLaunchDate";

		private const string LAST_ACTIVE_DATE_KEY = "VoodooSauce_LastActiveDate";

		private const string SHOW_INTERSTITIAL_COUNT_KEY = "FsCount";

		private const string SHOW_REWARDED_COUNT_KEY = "RvCount";

		private const string SHOW_APP_OPEN_COUNT_KEY = "AoCount";

		private const string SHOW_NATIVE_ADS_COUNT_KEY = "NativeAds_Ad_Count";

		private const string MREC_COUNT_KEY = "MRec_Ad_Count";

		private const string AUDIO_AD_COUNT_KEY = "Audio_Ad_Count";

		private const string ACTIVITY_DAYS = "Activity_Days";

		private const string INTERSTITIAL_WATCHED_COUNT_KEY = "VoodooSauce_FSShownCount";

		private const string REWARDED_WATCHED_COUNT_KEY = "VoodooSauce_RVShownCount";

		private const string APP_OPEN_WATCHED_COUNT_KEY = "VoodooSauce_AOShownCount";

		private const string SHOW_CROSS_PROMO_COUNT_KEY = "CrossPromoCount";

		private const string SHOW_BACKUP_FS_COUNT_KEY = "BackupFSCount";

		private const string SHOW_BACKUP_RV_COUNT_KEY = "BackupRVCount";

		private const string GAME_ROUND_ID_KEY = "GameRoundId";

		private const string RV_USED_KEY = "RvUsed";

		private static IAnalyticStorage instance;

		private readonly Dictionary<string, object> _cache;

		internal static IAnalyticStorage Instance => null;

		public void PreLoad()
		{
		}

		public int IncrementShowCrossPromoCount()
		{
			return 0;
		}

		public int GetShowCrossPromoCount()
		{
			return 0;
		}

		public void IncrementShowBackupFsCount()
		{
		}

		public void IncrementShowBackupRvCount()
		{
		}

		public int GetShowBackupFsCount()
		{
			return 0;
		}

		public int GetShowBackupRvCount()
		{
			return 0;
		}

		public void IncrementGameCount()
		{
		}

		public void DecreaseGameCount()
		{
		}

		public int GetGameCount()
		{
			return 0;
		}

		public int IncrementSuccessfulGameCount()
		{
			return 0;
		}

		public int GetSuccessfulGameCount()
		{
			return 0;
		}

		public double GetWinRate()
		{
			return 0.0;
		}

		public bool HasWinRate()
		{
			return false;
		}

		public string GetCurrentLevel()
		{
			return null;
		}

		public void UpdateCurrentLevel(string level)
		{
		}

		public bool HasCurrentLevel()
		{
			return false;
		}

		public float GetGameHighestScore()
		{
			return 0f;
		}

		public bool HasGameHighestScore()
		{
			return false;
		}

		public bool UpdateGameHighestScore(float score)
		{
			return false;
		}

		public string GetGameRoundId()
		{
			return null;
		}

		public string CreateRoundId()
		{
			return null;
		}

		public int GetAppLaunchCount()
		{
			return 0;
		}

		public bool IsFirstAppLaunch()
		{
			return false;
		}

		public void IncrementAppLaunchCount()
		{
		}

		public DateTime? GetFirstAppLaunchDate()
		{
			return null;
		}

		public void SaveFirstAppLaunchDate()
		{
		}

		public DateTime? GetLastActiveDate()
		{
			return null;
		}

		public void SaveLastActiveDate()
		{
		}

		public int GetDaysSinceInstall()
		{
			return 0;
		}

		public int GetDaysSinceLastSession()
		{
			return 0;
		}

		public int GetActivityDays()
		{
			return 0;
		}

		public int IncrementAudioAdCount()
		{
			return 0;
		}

		public int GetAudioAdCount()
		{
			return 0;
		}

		public int IncrementShowInterstitialCount()
		{
			return 0;
		}

		public int GetShowInterstitialCount()
		{
			return 0;
		}

		public int IncrementShowRewardedVideoCount()
		{
			return 0;
		}

		public int GetShowRewardedVideoCount()
		{
			return 0;
		}

		public int IncrementShowAppOpenCount()
		{
			return 0;
		}

		public int GetShowAppOpenCount()
		{
			return 0;
		}

		public int IncrementMrecCount()
		{
			return 0;
		}

		public int GetMrecCount()
		{
			return 0;
		}

		public int IncrementShowNativeAdsCount()
		{
			return 0;
		}

		public int GetShowNativeAdsCount()
		{
			return 0;
		}

		public int IncrementInterstitialWatchedCount()
		{
			return 0;
		}

		public int GetInterstitialWatchedCount()
		{
			return 0;
		}

		public int IncrementRewardedVideoWatchedCount()
		{
			return 0;
		}

		public int GetRewardedVideoWatchedCount()
		{
			return 0;
		}

		public int IncrementAppOpenWatchedCount()
		{
			return 0;
		}

		public int GetAppOpenWatchedCount()
		{
			return 0;
		}

		public void IncreaseRvUsed()
		{
		}

		public void ResetRvUsed()
		{
		}

		public int GetRvUsed()
		{
			return 0;
		}

		private int IncrementIntValue(string key, int defaultValue = 0)
		{
			return 0;
		}

		private int DecreaseIntValue(string key, int defaultValue = 0)
		{
			return 0;
		}

		private void UpdateIntValue(string key, int value)
		{
		}

		private int GetIntValue(string key)
		{
			return 0;
		}

		private int GetIntValue(string key, int @default)
		{
			return 0;
		}

		private int LoadCacheStorageIntValue(string key)
		{
			return 0;
		}

		private int LoadCacheStorageIntValue(string key, int @default)
		{
			return 0;
		}

		private void UpdateFloatValue(string key, float value)
		{
		}

		private float GetFloatValue(string key)
		{
			return 0f;
		}

		private float LoadCacheStorageFloatValue(string key)
		{
			return 0f;
		}

		private void UpdateStringValue(string key, string value)
		{
		}

		private string GetStringValue(string key)
		{
			return null;
		}

		private string LoadCacheStorageStringValue(string key)
		{
			return null;
		}
	}
}
