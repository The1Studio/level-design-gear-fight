using System.Collections.Generic;
using Voodoo.Live.Shop.Data;

namespace Voodoo.Live.Analytics
{
	public class ShopPayload : IShopPayload
	{
		private const string SHOP_ID = "shop_id";

		private const string SHOP_NAME = "shop_name";

		public string ShopId { get; }

		public string ShopName { get; }

		public ShopPayload(GameShop gameShop)
		{
		}

		public virtual Dictionary<string, object> GetParameters()
		{
			return null;
		}
	}
}
