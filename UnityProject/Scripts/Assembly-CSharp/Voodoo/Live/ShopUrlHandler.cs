namespace Voodoo.Live
{
	public class ShopUrlHandler : IUrlHandler
	{
		private const string BaseUrl = "https://voodootune-shops-cdn.voodoo{0}.io/{1}/{2}.json";

		private const string SimulationUrl = "https://liveops.voodoo-{0}.io/api/shop/simulations?appId={1}&versionId={2}&shopId={3}";

		private readonly string _url;

		public string GetURL()
		{
			return null;
		}
	}
}
