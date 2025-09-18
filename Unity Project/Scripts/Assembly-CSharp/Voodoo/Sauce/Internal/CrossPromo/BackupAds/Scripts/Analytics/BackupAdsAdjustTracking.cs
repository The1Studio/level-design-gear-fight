using Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Models;
using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Analytics
{
	public static class BackupAdsAdjustTracking
	{
		private const string CLICK_URL = "https://adjust.com/";

		private const string IMPRESSION_URL = "https://view.adjust.com/impression/";

		private const string STORE_URL = "https://app.adjust.com/";

		private static PrivacyCore Privacy => null;

		public static void TriggerClick(BackupAdsAnalyticsInfo info)
		{
		}

		public static void TriggerImpression(BackupAdsAnalyticsInfo info)
		{
		}

		public static void TriggerRedirection(BackupAdsAnalyticsInfo info)
		{
		}

		private static string CreateUrl(string url, BackupAdsAnalyticsInfo info)
		{
			return null;
		}

		private static void SendQuery(string url)
		{
		}

		public static string GetClickUrl(BackupAdsAnalyticsInfo info)
		{
			return null;
		}

		public static string GetRedirectionUrl(BackupAdsAnalyticsInfo info)
		{
			return null;
		}

		public static string GetImpressionUrl(BackupAdsAnalyticsInfo info)
		{
			return null;
		}
	}
}
