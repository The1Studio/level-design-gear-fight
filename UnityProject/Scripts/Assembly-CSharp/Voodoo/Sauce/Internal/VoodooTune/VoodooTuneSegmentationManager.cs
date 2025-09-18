using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	public class VoodooTuneSegmentationManager
	{
		private const string ATTRIBUTION_CAMPAIGN_ID_KEY = "attribution_campaign_id";

		private const string ATTRIBUTION_CREATIVE_ID_KEY = "attribution_creative_id";

		private const string ATTRIBUTION_AD_NETWORK_ID_KEY = "attribution_ad_network";

		private static WatchedRewardedVideosCounter _watchCounter;

		private static WatchedRewardedVideosCounter WatchCounter => null;

		private void OnAttributionChange(AttributionAnalyticsInfo info)
		{
		}

		public static string GetAttributionAdNetworkAttribute()
		{
			return null;
		}

		public static string GetAttributionCreativeIdAttribute()
		{
			return null;
		}

		public static string GetAttributionCampaignIdAttribute()
		{
			return null;
		}

		public static int GetWatchedRewardedVideosForLastOneMonth()
		{
			return 0;
		}

		public static int GetWatchedRewardedVideosForLastTwoMonths()
		{
			return 0;
		}

		public static int GetWatchedRewardedVideosForLastThreeMonths()
		{
			return 0;
		}

		public static float GetAverageRewardedVideosForLastThreeSessions()
		{
			return 0f;
		}
	}
}
