using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal interface IAnalyticStorage
	{
		void PreLoad();

		void IncrementGameCount();

		void DecreaseGameCount();

		int GetGameCount();

		int IncrementSuccessfulGameCount();

		int GetSuccessfulGameCount();

		double GetWinRate();

		bool HasWinRate();

		string GetCurrentLevel();

		void UpdateCurrentLevel(string level);

		bool HasCurrentLevel();

		float GetGameHighestScore();

		bool HasGameHighestScore();

		bool UpdateGameHighestScore(float score);

		string GetGameRoundId();

		string CreateRoundId();

		int GetAppLaunchCount();

		bool IsFirstAppLaunch();

		void IncrementAppLaunchCount();

		DateTime? GetFirstAppLaunchDate();

		void SaveFirstAppLaunchDate();

		DateTime? GetLastActiveDate();

		void SaveLastActiveDate();

		int GetDaysSinceInstall();

		int GetDaysSinceLastSession();

		int GetActivityDays();

		int GetShowInterstitialCount();

		int IncrementShowInterstitialCount();

		int IncrementAudioAdCount();

		int GetAudioAdCount();

		int IncrementShowAppOpenCount();

		int GetShowAppOpenCount();

		int IncrementMrecCount();

		int GetMrecCount();

		int IncrementShowNativeAdsCount();

		int GetShowNativeAdsCount();

		int GetShowRewardedVideoCount();

		int IncrementShowRewardedVideoCount();

		int IncrementInterstitialWatchedCount();

		int GetInterstitialWatchedCount();

		int IncrementRewardedVideoWatchedCount();

		int GetRewardedVideoWatchedCount();

		int IncrementAppOpenWatchedCount();

		int GetAppOpenWatchedCount();

		void IncreaseRvUsed();

		void ResetRvUsed();

		int GetRvUsed();

		int IncrementShowCrossPromoCount();

		int GetShowCrossPromoCount();

		void IncrementShowBackupFsCount();

		void IncrementShowBackupRvCount();

		int GetShowBackupFsCount();

		int GetShowBackupRvCount();
	}
}
