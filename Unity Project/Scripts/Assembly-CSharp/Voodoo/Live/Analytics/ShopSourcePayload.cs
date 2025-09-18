using System.Collections.Generic;
using Voodoo.Live.Shop.Data;

namespace Voodoo.Live.Analytics
{
	public class ShopSourcePayload : ShopPayload, IShopSourcePayload
	{
		private const string SHOP_OPEN_SOURCE_ID = "shop_open_source_id";

		private const string SHOP_OPEN_SOURCE_NAME = "shop_open_source_name";

		public string ShopOpenSourceId { get; }

		public string ShopOpenSourceName { get; }

		public ShopSourcePayload(GameShop gameShop)
			: base(null)
		{
		}

		public ShopSourcePayload(string sourceId, string sourceName)
			: base(null)
		{
		}

		public override Dictionary<string, object> GetParameters()
		{
			return null;
		}
	}
}
