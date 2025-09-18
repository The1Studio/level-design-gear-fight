namespace Voodoo.Sauce.Core
{
	public static class EnvironmentSettings
	{
		public enum Server
		{
			Tech = 0,
			Staging = 1,
			Dev = 2
		}

		private const string ANALYTICS_SERVER_KEY = "AnalyticsServer";

		private const string PROXY_SERVER_KEY = "ProxyServer";

		internal static bool IsDevelopmentBuild;

		internal static Server GetAnalyticsServer()
		{
			return default(Server);
		}

		internal static string GetAnalyticsURL(string path)
		{
			return null;
		}

		internal static void SaveAnalyticsServer(Server server)
		{
		}

		internal static string GetProxyServer()
		{
			return null;
		}

		internal static void SaveProxyServer(string proxyServer)
		{
		}

		internal static string GetLowerCaseEnvironmentFromServer(Server server)
		{
			return null;
		}

		internal static bool IsHaveValueSaved()
		{
			return false;
		}
	}
}
