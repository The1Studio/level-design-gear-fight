using Voodoo.Analytics;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class VoodooAnalyticsParameters
	{
		public bool UseVoodooTune { get; }

		public bool UseVoodooAnalytics { get; }

		public string ProxyServer { get; }

		public VoodooAnalyticsParameters(bool useVoodooTune, bool useVoodooAnalytics, string proxyServer)
		{
		}

		internal VanSessionInfo GetSessionInfo()
		{
			return null;
		}
	}
}
