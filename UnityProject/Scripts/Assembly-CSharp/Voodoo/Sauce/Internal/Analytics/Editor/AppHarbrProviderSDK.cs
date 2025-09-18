using Voodoo.Sauce.Internal.SDKs;

namespace Voodoo.Sauce.Internal.Analytics.Editor
{
	[Preserve]
	public class AppHarbrProviderSDK : IAnalyticsProviderSDK, ISDK
	{
		private const string DEPENDENCIES_PATH = "/VoodooSauce/Ads/AppHarbr/3rdParty/AppHarbrSDK/Editor/Dependencies.xml";

		public SDK GetSDKInformations()
		{
			return null;
		}
	}
}
