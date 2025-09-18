using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class AdnAppInfo
	{
		private const string SESSION_START_DATE_KEY = "session_start_date_key";

		private const string ATTRIBUTION_DATA_KEY = "attribution_data_key";

		private readonly DateTime _startTime;

		private readonly IAnalyticStorage _analyticStorage;

		private readonly AdnPerfMetrics _perfMetrics;

		private readonly AdnAttributionData _attributionData;

		private string _attributionUserId;

		private int _initialGameCount;

		internal string UnityVersion { get; }

		internal string VsVersion { get; }

		internal string FirstAppLaunchDate { get; }

		internal string VanUserId { get; }

		internal string SessionStartDate { get; }

		internal string PreviousSessionStartDate { get; }

		internal int AppOpenCountSinceInstall { get; }

		internal string AppStoreId { get; }

		internal int PlayTime { get; private set; }

		internal int GameWonCount { get; private set; }

		internal SessionInfo Session { get; }

		internal void UpdateInfo(GameFinishedParameters parameters)
		{
		}

		internal void UpdateAttributionInfo(AttributionAnalyticsInfo info)
		{
		}

		internal void UpdateInfo(PerformanceMetricsAnalyticsInfo metrics)
		{
		}

		internal int TimeSinceStartup()
		{
			return 0;
		}

		internal AdnGameCount GameCount()
		{
			return null;
		}

		internal Dictionary<string, object> PerfMetrics()
		{
			return null;
		}

		internal Dictionary<string, object> AttributionData()
		{
			return null;
		}

		internal string AttributionUserId()
		{
			return null;
		}
	}
}
