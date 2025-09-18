using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	public static class VoodooFunnelsManager
	{
		private const string TAG = "VOODOO_FUNNELS";

		private const string NONEXISTENT_FUNNEL = "The Funnel you are attempting to track was not set in your AnalyticsSettings";

		private const string NONEXISTENT_FUNNEL_STEP = "The Funnel Step you are attempting to track was not set in your AnalyticsSettings";

		private static readonly Dictionary<string, VoodooFunnel> FunnelsDict;

		private static bool _isInitialized;

		private static void Initialize()
		{
		}

		internal static void Reset()
		{
		}

		public static void TrackFunnel(string funnelName, string funnelStep, Dictionary<string, object> contextVariables = null)
		{
		}
	}
}
