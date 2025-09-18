using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	public struct VoodooAdInfo
	{
		private const string USD_CURRENCY = "USD";

		public string Id;

		public string AdUnit;

		public string AdNetworkName;

		public string AdNetworkPlacementId;

		public double? Revenue;

		public string Country;

		public string WaterfallTestName;

		public string WaterfallName;

		public string Creative;

		public string Precision;

		public string Ab;

		public string SegmentName;

		public string InstanceId;

		public string InstanceName;

		public double? LifetimeRevenue;

		public int? ConversionValue;

		public string EncryptedCPM;

		public string JsonRepresentation;

		public ImpressionAnalyticsInfo ToInfoType(ImpressionInfoType type)
		{
			return null;
		}

		private FakeImpressionAnalyticsInfo ToFakeInfo()
		{
			return null;
		}

		private MaxImpressionAnalyticsInfo ToMaxInfo()
		{
			return null;
		}

		private IronSourceImpressionAnalyticsInfo ToIronSourceInfo()
		{
			return null;
		}
	}
}
