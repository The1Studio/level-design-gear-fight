using Voodoo.Sauce.Internal.SDKs;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Preserve]
	public class FirebaseAnalyticsProviderSDK : IAnalyticsProviderSDK, ISDK
	{
		private const string UnityVersion = "12.1.0";

		public SDK GetSDKInformations()
		{
			return null;
		}
	}
}
