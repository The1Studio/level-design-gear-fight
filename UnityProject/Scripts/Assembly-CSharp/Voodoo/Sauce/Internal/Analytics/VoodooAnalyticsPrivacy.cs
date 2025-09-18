using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Preserve]
	public class VoodooAnalyticsPrivacy : IPrivacyLink
	{
		public string SDKName => null;

		public string PrivacyPolicyUrl => null;

		public PrivacySDKType SDKType => default(PrivacySDKType);
	}
}
