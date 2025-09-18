using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.CrashReport.Embrace
{
	[Preserve]
	public class EmbracePrivacy : IPrivacyLink
	{
		public string SDKName => null;

		public string PrivacyPolicyUrl => null;

		public PrivacySDKType SDKType => default(PrivacySDKType);
	}
}
