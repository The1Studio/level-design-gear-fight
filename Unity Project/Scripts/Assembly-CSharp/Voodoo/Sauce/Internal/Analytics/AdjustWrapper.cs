using System.Collections.Generic;
using com.adjust.sdk;

namespace Voodoo.Sauce.Internal.Analytics
{
	public static class AdjustWrapper
	{
		private const string TAG = "AdjustWrapper";

		private const string ADJUST_USER_ID_KEY = "vs_adjust_user_id";

		private static readonly AttributionData AttributionData;

		private static bool _isInitialized;

		private static readonly Queue<AdjustAnalyticsEvent> EventsQueue;

		internal static void Instantiate()
		{
		}

		internal static void Initialize(string token, bool isTestMode, AnalyticsProviderInfo info)
		{
		}

		public static void TrackEvent(string eventName, Dictionary<string, object> customVariables = null)
		{
		}

		public static void TrackAdRevenue(string eventName, string data)
		{
		}

		public static void TrackAdRevenue(AdjustAdRevenue adRevenue)
		{
		}

		private static void AddAdjustSessionCallbackParameters()
		{
		}

		private static void AddAdjustSessionCallbackParameters(Dictionary<string, string> parameters)
		{
		}

		private static void InitializeAdjust(string adjustAppToken, bool isTestMode, AnalyticsProviderInfo info)
		{
		}

		private static void SetAdjustThirdPartySharing(AnalyticsProviderInfo info)
		{
		}

		internal static AttributionData GetAttributionData()
		{
			return null;
		}

		private static void OnInitComplete()
		{
		}

		private static void OnAttributionChange(AdjustAttribution adjustAttribution)
		{
		}

		private static void TryToRetrieveUserId()
		{
		}

		private static void SaveUserId(string adid)
		{
		}

		private static void LoadCacheUserId()
		{
		}
	}
}
