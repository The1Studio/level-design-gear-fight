using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Firebase
{
	[Preserve]
	public class FirebaseCrashlyticsPrivacy : IPrivacyLink
	{
		public string SDKName => null;

		public string PrivacyPolicyUrl => null;

		public PrivacySDKType SDKType => default(PrivacySDKType);
	}
}
