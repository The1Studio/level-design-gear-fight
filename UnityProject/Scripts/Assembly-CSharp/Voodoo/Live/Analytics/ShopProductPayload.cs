using System.Collections.Generic;
using Voodoo.Live.Shop.Data;

namespace Voodoo.Live.Analytics
{
	public class ShopProductPayload : ShopPayload, IShopProductPayload, IShopPayload
	{
		private const string SHOP_PRODUCT_ID = "shop_product_id";

		private const string SHOP_PRODUCT_NAME = "shop_product_name";

		private const string SECTION_ID = "section_id";

		private const string SECTION_NAME = "section_name";

		private const string SECTION_POSITION = "section_position";

		private const string REWARD_ID = "reward_id";

		private const string REWARD_NAME = "reward_name";

		private const string PRODUCT_ID = "product_id";

		private const string PRODUCT_POSITION = "product_position";

		public string SectionId { get; }

		public string SectionName { get; }

		public int SectionPosition { get; }

		public string ShopProductId { get; }

		public string ShopProductName { get; }

		public int ProductPosition { get; }

		public string RewardName { get; }

		public string RewardId { get; }

		public string ProductId { get; }

		public ShopProductPayload(GameShop gameShop, Product product)
			: base(null)
		{
		}

		public override Dictionary<string, object> GetParameters()
		{
			return null;
		}

		public void SetHeaders()
		{
		}
	}
}
