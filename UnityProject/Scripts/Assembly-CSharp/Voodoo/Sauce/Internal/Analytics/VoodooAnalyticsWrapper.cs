using System.Collections.Generic;
using Voodoo.Analytics;

namespace Voodoo.Sauce.Internal.Analytics
{
	public static class VoodooAnalyticsWrapper
	{
		public static void TrackEvent(VanEventName eventName, Dictionary<string, object> data, string eventType = null, Dictionary<string, object> customVariables = null, Dictionary<string, object> contextVariables = null)
		{
		}

		public static void TrackCustomEvent(string eventName, Dictionary<string, object> customVariables, string eventType = null, Dictionary<string, object> contextVariables = null)
		{
		}

		public static void TrackEvent(VanEventName eventName, string data = null, string eventType = null, Dictionary<string, object> customVariables = null, Dictionary<string, object> contextVariables = null)
		{
		}

		public static void TrackEvent(string eventName, string data = null, string eventType = null, Dictionary<string, object> customVariables = null, Dictionary<string, object> contextVariables = null)
		{
		}

		public static void Instantiate(AnalyticsConfig analyticsConfig, VoodooAnalyticsParameters parameters, string mediation)
		{
		}
	}
}
