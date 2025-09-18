using System.Collections.Generic;
using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Internal.Analytics
{
	public static class GameAnalyticsWrapper
	{
		internal const string TAG = "GameAnalyticsWrapper";

		private static bool _isInitialized;

		private static bool _isDisabled;

		private static readonly Queue<GameAnalyticsEvent> QueuedEvents;

		internal static bool Initialize(PrivacyCore.GdprConsent consent)
		{
			return false;
		}

		internal static void TrackProgressEvent(GameAnalyticsBridge.GAProgressionStatus status, string progress, int? score, Dictionary<string, object> customFields)
		{
		}

		internal static void TrackDesignEvent(string eventName, Dictionary<string, object> customFields)
		{
		}

		internal static void TrackPurchase(IIAPCommonInfo purchaseInfo)
		{
		}

		private static void InstantiateGameAnalytics()
		{
		}

		private static void SetBuildVersion(string buildVersion)
		{
		}

		private static void Disable()
		{
		}
	}
}
