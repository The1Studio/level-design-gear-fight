using Voodoo.Live.Shop.Data;

namespace Voodoo.Live.Analytics
{
	public static class AnalyticsTracker
	{
		public static void TrackOfferConfigStatus(ConfigResponse config, string offerList)
		{
		}

		public static void TrackOfferBadgeShown(string offerId, string offerName)
		{
		}

		public static void TrackOfferBadgeClicked(string offerId, string offerName)
		{
		}

		public static void RemoveIAPContextParameters()
		{
		}

		public static void TrackShopConfigStatus(ConfigResponse config, string shopList)
		{
		}

		public static void TrackShopProductClicked(GameShop gameShop, Product product)
		{
		}

		public static void TrackShopProductShown(GameShop gameShop, Product product)
		{
		}

		public static void TrackShopOpened(GameShop gameShop)
		{
		}

		public static void TrackShopClosed(GameShop gameShop)
		{
		}

		public static void TrackShopOpenFailed(ShopSource source)
		{
		}
	}
}
