using Voodoo.Sauce.Firebase.Interfaces;
using Voodoo.Sauce.Internal.SDKs;

namespace Voodoo.Sauce.CrashReport.Embrace
{
	[Preserve]
	public class EmbraceProviderSDK : ICrashlyticsProviderSDK, ISDK
	{
		public SDK GetSDKInformations()
		{
			return null;
		}
	}
}
