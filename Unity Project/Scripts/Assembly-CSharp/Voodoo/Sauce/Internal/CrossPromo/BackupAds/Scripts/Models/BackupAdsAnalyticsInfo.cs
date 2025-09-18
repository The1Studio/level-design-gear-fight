using System;

namespace Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Models
{
	[Serializable]
	public struct BackupAdsAnalyticsInfo
	{
		public string bundleId;

		public string filePath;

		public string adjustAppId;

		public string adGuid;

		public string campaignId;

		public string clickUrl;

		public string redirectionUrl;

		public string impressionUrl;

		public string mercuryCampaignId;

		public int adCount;

		public int gameCount;

		public string format;

		public BackupAdsAnalyticsInfo(BackupAdsInfo info)
		{
			bundleId = null;
			filePath = null;
			adjustAppId = null;
			adGuid = null;
			campaignId = null;
			clickUrl = null;
			redirectionUrl = null;
			impressionUrl = null;
			mercuryCampaignId = null;
			adCount = 0;
			gameCount = 0;
			format = null;
		}
	}
}
