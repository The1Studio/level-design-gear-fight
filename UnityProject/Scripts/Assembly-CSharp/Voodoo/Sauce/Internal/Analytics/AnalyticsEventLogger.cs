using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class AnalyticsEventLogger
	{
		private const string TAG = "AnalyticsEventLogger";

		private const string VOODOO_ANALYTICS_WRAPPER_NAME = "VoodooAnalytics";

		private const string PLAYER_PREF_RECORDING_AT_STARTUP_KEY = "van_debugger_recording_startup";

		private static AnalyticsEventLogger _instance;

		private readonly List<DebugAnalyticsLog> _logsList;

		private readonly HashSet<string> _logsIdList;

		private bool _isAnalyticsDebuggingEnabled;

		internal bool IsRecordingEvents { get; private set; }

		internal bool IsRecordingAtStartup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal event Action<bool> OnRecordingStateChange
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

		internal static event Action<DebugAnalyticsLog, bool> OnAnalyticsEventStateChanged
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

		internal List<DebugAnalyticsLog> GetLocalAnalyticsLog(string wrapperNameFilter = null)
		{
			return null;
		}

		internal static AnalyticsEventLogger GetInstance()
		{
			return null;
		}

		private AnalyticsEventLogger()
		{
		}

		internal void Init()
		{
		}

		private void LogEventLocallyIfRelevant(string wrapperName, string eventName, DebugAnalyticsStateEnum state, string eventId, Dictionary<string, object> param = null, string error = "")
		{
		}

		internal void LogEventSentTo3RdParty(string wrapperName, string eventName, string eventId, [CanBeNull] Dictionary<string, object> param = null)
		{
		}

		internal void LogEventException(string wrapperName, string eventName, string eventId, [CanBeNull] Dictionary<string, object> param, Exception e)
		{
		}

		internal void LogEventsSentSuccessfully(List<string> eventJsons)
		{
		}

		internal void LogEventsSentError(List<string> eventJsons, string error)
		{
		}

		private void LogAnalyticsSentOrErrorEvent(string wrapperName, List<string> eventJsons, DebugAnalyticsStateEnum stateEnum, string error = "")
		{
		}

		private static string TryToGetStringOrEmpty<T>(T key, Dictionary<T, object> data)
		{
			return null;
		}

		private static string GetAdditionalInformationFromJson(Dictionary<string, object> dict, string additionalInformation = "")
		{
			return null;
		}

		internal void SetAnalyticsDebugging(bool enabled)
		{
		}

		internal void SetAnalyticsEventRecording(bool enabled)
		{
		}

		internal void FlushAnalyticsLogs()
		{
		}
	}
}
