using Voodoo.Nakama.Server;

namespace Voodoo.Nakama.DeepLink
{
	public static class DeepLinkHelper
	{
		public static bool TryParseUrl(string url, out string verificationKey, out NakamaEnvironmentType? environment, out string variant)
		{
			verificationKey = null;
			environment = null;
			variant = null;
			return false;
		}
	}
}
