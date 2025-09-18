namespace Voodoo.Sauce.Privacy
{
	public interface IPrivacyLink
	{
		string SDKName { get; }

		string PrivacyPolicyUrl { get; }

		PrivacySDKType SDKType { get; }
	}
}
