using System;
using System.Collections.Generic;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	public class WatchedRewardedVideosCounter
	{
		private const string WATCHED_RV_COUNT_KEY = "WatchedRewardedVideosData";

		private const string SESSIONS_KEY = "WatchedRVSessions";

		private Dictionary<DateTime, int> _dailyCounts;

		private List<int> _sessions;

		private void IncrementCount(AdClosedEventAnalyticsInfo adClosedEventAnalyticsInfo)
		{
		}

		public int GetWatchedRewardedVideosForLastMonths(int monthsToLookBack)
		{
			return 0;
		}

		public float GetAverageRewardedVideosForLastThreeSessions()
		{
			return 0f;
		}

		private void CleanUpOldCounts()
		{
		}

		private void LoadCounts()
		{
		}

		private void SaveCounts()
		{
		}

		private void LoadSessions()
		{
		}

		private void SaveSessions()
		{
		}
	}
}
