using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Timers;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class AnalyticsSessionManager
	{
		private const string TAG = "Analytics - SessionHelper";

		private const string PlayerPrefSessionCountKey = "VOODOO_ANALYTICS_SESSION_COUNT";

		private const string PlayerPrefPlaytimeKey = "VOODOO_ANALYTICS_PLAYTIME";

		private DateTime _lastEventCreationDate;

		private Timer _sessionLengthTimer;

		private int _sessionIdRenewalIntervalInSeconds;

		private List<Playtime> _playtimes;

		private Playtime _todayPlaytime;

		private static AnalyticsSessionManager _instance;

		internal SessionInfo SessionInfo { get; }

		internal event Action<SessionInfo> OnNewSession
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

		internal static AnalyticsSessionManager Instance()
		{
			return null;
		}

		internal void Init()
		{
		}

		private void OnTick(object sender, ElapsedEventArgs e)
		{
		}

		private void InitPlaytime()
		{
		}

		private void SavePlaytime()
		{
		}

		private Playtime GetTodayPlaytime()
		{
			return null;
		}

		public int GetPlaytimeOver(int dayCount)
		{
			return 0;
		}

		internal void OnNewEvent()
		{
		}

		private void Update()
		{
		}

		private void ResetSession()
		{
		}

		private void IncrementSessionCount()
		{
		}

		private void RefreshCreationDate()
		{
		}

		internal void StopTimer()
		{
		}
	}
}
