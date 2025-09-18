namespace Voodoo.Live
{
	public class OfferUrlHandler : IUrlHandler
	{
		private const string BaseUrl = "https://liveops.voodoo-{0}.io/api/offers";

		private readonly string _url;

		private readonly string _platform;

		public string GetURL()
		{
			return null;
		}

		private string GetDefaultConfigurationURL()
		{
			return null;
		}

		private string GetSimulationURL()
		{
			return null;
		}

		private string GetSandboxURL(string appId, string sandBoxId)
		{
			return null;
		}
	}
}
