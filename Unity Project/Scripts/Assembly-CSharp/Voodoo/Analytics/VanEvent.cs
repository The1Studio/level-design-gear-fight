using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Voodoo.Analytics
{
	internal class VanEvent
	{
		private struct TrackingIdParameters
		{
			public string eventId;

			public string name;

			public string type;

			public string sessionId;

			public string createdAt;

			public string advertisingId;

			public string bundleId;

			public string platform;

			public string developerDeviceId;

			public string secretKey;
		}

		private const string EVENT_TYPE_IMPRESSION = "impression";

		private const string EVENT_TYPE_APP = "app";

		private const string EVENT_TYPE_CUSTOM = "custom";

		private Dictionary<string, object> _values;

		private string _name;

		private string _jsonData;

		private string _customVariablesData;

		private string _contextVariablesData;

		private static readonly string[] ImpressionEvents;

		internal string GetName()
		{
			return null;
		}

		private VanEvent()
		{
		}

		internal static void Create(string name, VanEventBasicParameters parameters, string dataJson, string customVariablesJson, string contextVariablesJson, string type, Action<VanEvent> complete, [CanBeNull] string eventId, VanSessionInfo sessionInfo)
		{
		}

		private static string GetTrackingId(TrackingIdParameters parameters)
		{
			return null;
		}

		private static string GetType(string name)
		{
			return null;
		}

		internal string ToJson()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
