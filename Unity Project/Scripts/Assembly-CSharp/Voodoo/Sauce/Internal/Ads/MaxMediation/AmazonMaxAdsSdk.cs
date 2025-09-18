using Voodoo.Sauce.Internal.SDKs;

namespace Voodoo.Sauce.Internal.Ads.MaxMediation
{
	[Preserve]
	public class AmazonMaxAdsSdk : IMaxAdsCustomNetworkSDK
	{
		private const string AMAZON_MEDIATION_BASE_PATH = "/VoodooSauce/Ads/Mediations/MaxAds/Internal/Mediation/Amazon/Editor";

		private static readonly string AdapterDependencyPath;

		private static readonly string SdkDependenciesPath;

		public AdNetworkSDK GetSDKInformation()
		{
			return null;
		}
	}
}
