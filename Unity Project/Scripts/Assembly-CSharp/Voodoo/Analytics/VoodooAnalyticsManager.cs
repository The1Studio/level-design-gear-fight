using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Voodoo.Analytics
{
	public static class VoodooAnalyticsManager
	{
		private struct QueuedEvent
		{
			public string EventName;

			public string EventDataJson;

			public string EventType;

			public string EventCustomVariablesJson;

			public string EventContextVariablesJson;

			[CanBeNull]
			public string EventId;

			public VanSessionInfo SessionInfo;
		}

		private const string TAG = "VoodooAnalyticsManager";

		private static bool _isInitialized;

		private static readonly List<QueuedEvent> QueuedEvents;

		public static readonly GlobalContext GlobalContext;

		public static readonly EventSpecificContext EventSpecificContext;

		internal static VanEventBasicParameters Parameters;

		private static Action _newEvent;

		private static Func<VanSessionInfo> _sessionInfoProvider;

		public static void Init(IConfig config, string proxyServer, string gatewayUrl, VanEventBasicParameters parameters, [CanBeNull] Action newEvent = null)
		{
		}

		public static void SetSessionInfoProvider(Func<VanSessionInfo> sessionInfoProvider)
		{
		}

		public static void Reset()
		{
		}

		public static void StartTracker()
		{
		}

		public static void StopTracker()
		{
		}

		private static void SendQueuedEvents()
		{
		}

		public static void TrackEvent(VanEventName eventName, Dictionary<string, object> data, string eventType = null, Dictionary<string, object> customVariables = null, string eventId = null, Dictionary<string, object> contextVariables = null)
		{
		}

		public static void TrackCustomEvent(string eventName, Dictionary<string, object> customVariables, string eventType = null, string eventId = null, Dictionary<string, object> contextVariables = null)
		{
		}

		private static void TrackEvent(string eventName, Dictionary<string, object> data, string eventType = null, Dictionary<string, object> customVariables = null, Dictionary<string, object> contextVariables = null, string eventId = null)
		{
		}

		public static void TrackEvent(VanEventName eventName, string data = null, string eventType = null, Dictionary<string, object> customVariables = null, string eventId = null, Dictionary<string, object> contextVariables = null)
		{
		}

		public static void SetCustomLogger(IVanCustomLog vanCustomLogger)
		{
		}

		private static void InternalTrackEvent(string eventName, string dataJson, string eventType, string customVariablesJson, string contextVariablesJson, [CanBeNull] string eventId, VanSessionInfo sessionInfo = null)
		{
		}

		private static string CreateContextVariablesJson(Dictionary<string, object> contextVariables, string eventName)
		{
			return null;
		}

		private static void FillGlobalContextVariables(ref Dictionary<string, object> contextVariables)
		{
		}

		private static void FillEventSpecificContextVariables(ref Dictionary<string, object> contextVariables, string eventName)
		{
		}
	}
}
