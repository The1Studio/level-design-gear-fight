using System;

namespace Voodoo.Sauce.Core.Model
{
	[Serializable]
	public class SourcepointConfiguration
	{
		public int accountId;

		public int propertyId;

		public int privacyManagerId;

		public string propertyName;

		public long messageTimeoutInSeconds;

		public string authId;

		public string ageKey;

		public string storeAndAccessInformationOnDeviceKey;

		public string selectBasicAdsKey;

		public string createPersonalisedAdsProfileKey;

		public string selectPersonalisedAdsKey;

		public string createPersonalisedContentProfileKey;

		public string selectPersonalisedContentKey;

		public string measureAdsPerformanceKey;

		public string measureContentPerformanceKey;

		public string applyMarketResearchToGenerateAudienceInsightsKey;

		public string developAndImproveProductsKey;
	}
}
