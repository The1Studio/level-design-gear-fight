namespace Voodoo.Live.Analytics
{
	public interface IShopProductPayload : IShopPayload
	{
		string SectionId { get; }

		string SectionName { get; }

		int SectionPosition { get; }

		string ShopProductId { get; }

		string ShopProductName { get; }

		int ProductPosition { get; }

		string RewardName { get; }

		string RewardId { get; }

		string ProductId { get; }
	}
}
