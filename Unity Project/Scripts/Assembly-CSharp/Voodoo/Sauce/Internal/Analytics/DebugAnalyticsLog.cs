using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	public struct DebugAnalyticsLog
	{
		internal string EventId { get; }

		internal string WrapperName { get; }

		internal string EventName { get; }

		internal Dictionary<string, object> Parameters { get; }

		internal string Error { get; }

		internal DebugAnalyticsStateEnum StateEnum { get; }

		internal DateTime Timestamp { get; }

		internal string SessionId { get; }

		internal string AdditionalInformation { get; }

		internal DebugAnalyticsLog(string wrapperName, string eventName, Dictionary<string, object> param, DebugAnalyticsStateEnum stateEnum, string eventId, string error, string sessionId, string additionalInformation)
		{
			EventId = null;
			WrapperName = null;
			EventName = null;
			Parameters = null;
			Error = null;
			StateEnum = default(DebugAnalyticsStateEnum);
			Timestamp = default(DateTime);
			SessionId = null;
			AdditionalInformation = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
