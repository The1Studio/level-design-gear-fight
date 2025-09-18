using Voodoo.Sauce.Internal.SDKs;
using Voodoo.Sauce.Internal.SDKs.Models;

namespace Voodoo.Sauce.Internal.Ads.MaxMediation
{
	[Preserve]
	public class MaxMediationAdapterSDK : IMediationAdapterSDK, ISDK
	{
		private const string NAME = "MaxAds";

		private const string MEDIATION_FOLDER_PATH = "/VoodooSauce/Ads/Mediations/MaxAds/3rdParty/MaxSdk/";

		private const string MEDIATION_CUSTOM_AD_NETWORKS_FOLDER_PATH = "/VoodooSauce/Ads/Mediations/MaxAds/Internal/Mediation/";

		private readonly string _adNetworksFolderPath;

		private const string AD_NETWORK_DEPENDENCIES_PATH = "/Editor/Dependencies.xml";

		public int Order => 0;

		public SDK GetSDKInformations()
		{
			return null;
		}

		private static void AddAdNetworks(MediationSDK mediation, string directoryPath, bool isCertified)
		{
		}

		internal static void UpdateAdNetwork(AdNetworkSDK adNetworkSDK, string dependencyFilePath, bool certified)
		{
		}

		private static void UpdateAdNetworkAndroid(AdNetworkSDK adNetworkSDK, Dependencies dependencies, bool isCertified)
		{
		}

		private static string GetAndroidAdapterVersionName(Dependencies dependencies)
		{
			return null;
		}

		private static void UpdateAdNetworkiOS(AdNetworkSDK adNetworkSDK, Dependencies dependencies, bool isCertified)
		{
		}

		private static string GetIosAdapterVersionName(Dependencies dependencies)
		{
			return null;
		}
	}
}
