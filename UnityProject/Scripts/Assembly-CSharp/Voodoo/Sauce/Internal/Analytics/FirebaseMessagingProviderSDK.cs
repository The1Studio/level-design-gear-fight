using Voodoo.Sauce.Internal.SDKs;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Preserve]
	public class FirebaseMessagingProviderSDK : IAnalyticsProviderSDK, ISDK
	{
		private const string DEPENDENCY_PATH = "/VoodooSauce/Analytics/FirebaseAnalytics/3rdParty/FirebaseMessaging/Editor/MessagingDependencies.xml";

		private const string ANDROID_PACKAGE = "com.google.firebase:firebase-messaging";

		private const string UnityVersion = "12.1.0";

		public SDK GetSDKInformations()
		{
			return null;
		}
	}
}
