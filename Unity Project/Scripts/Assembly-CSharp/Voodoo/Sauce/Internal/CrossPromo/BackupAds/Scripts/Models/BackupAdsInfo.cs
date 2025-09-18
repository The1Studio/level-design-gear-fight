using System;
using UnityEngine.Video;
using Voodoo.Sauce.Internal.CrossPromo.Mercury.Models;

namespace Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Models
{
	[Serializable]
	public class BackupAdsInfo
	{
		public enum BackupAdType
		{
			BackupFS = 0,
			BackupRV = 1
		}

		public string gameName;

		public VideoClip videoClip;

		public string videoUrl;

		public string bundleId;

		public string adjustAppId;

		public string adjustCampaignId;

		public string clickUrl;

		public string redirectionUrl;

		public string impressionUrl;

		public int videoIndex;

		public string mercuryCampaignId;

		public BackupAdType adType;

		private BackupAdsAnalyticsInfo _currentAnalyticsInfo;

		private bool _restrictedPrivacy;

		public BackupAdsInfo(MercuryPromotedAsset asset, BackupAdType adType, bool restrictedPrivacy)
		{
		}

		private void InitializeAnalyticsInfo()
		{
		}

		public void TriggerAnalyticsImpression()
		{
		}

		public void TriggerAnalyticsClick()
		{
		}

		public void TriggerAdjustImpression()
		{
		}

		public void TriggerAdjustClick()
		{
		}

		public void TriggerAdjustRedirection()
		{
		}

		private void RefreshAnalyticsCounterInfo()
		{
		}
	}
}
