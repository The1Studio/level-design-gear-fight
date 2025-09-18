using Voodoo.Sauce.Internal.SDKs;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Preserve]
	public class AdjustAnalyticsProviderSDK : IAnalyticsProviderSDK, ISDK
	{
		private const string DEPENDENCIES_PATH = "VoodooSauce/Analytics/Adjust/Internal/Editor/AdjustDependencies.xml";

		public SDK GetSDKInformations()
		{
			return null;
		}
	}
}
