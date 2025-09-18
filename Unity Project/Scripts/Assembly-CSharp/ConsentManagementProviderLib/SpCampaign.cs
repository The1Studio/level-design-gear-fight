using System.Collections.Generic;

namespace ConsentManagementProviderLib
{
	public class SpCampaign
	{
		private CAMPAIGN_TYPE campaignType;

		private List<TargetingParam> targetingParams;

		public CAMPAIGN_TYPE CampaignType => default(CAMPAIGN_TYPE);

		public List<TargetingParam> TargetingParams => null;

		public SpCampaign(CAMPAIGN_TYPE campaignType, List<TargetingParam> targetingParams)
		{
		}
	}
}
