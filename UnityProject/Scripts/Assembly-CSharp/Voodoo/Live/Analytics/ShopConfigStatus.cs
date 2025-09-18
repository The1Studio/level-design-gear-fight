namespace Voodoo.Live.Analytics
{
	public class ShopConfigStatus : ConfigStatus, IAnalyticsRequest
	{
		private const string OFFER_LIST = "shop_list";

		private const string EVENT_NAME = "voodoolive_shop_config_status";

		private readonly string _shopList;

		public ShopConfigStatus(ConfigResponse config, string shopList)
			: base(null)
		{
		}

		public void Track()
		{
		}
	}
}
