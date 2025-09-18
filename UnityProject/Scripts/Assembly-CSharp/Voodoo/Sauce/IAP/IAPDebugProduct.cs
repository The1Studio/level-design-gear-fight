namespace Voodoo.Sauce.IAP
{
	internal class IAPDebugProduct
	{
		internal enum Status
		{
			Available = 0,
			Missing = 1,
			BadID = 2,
			Owned = 3
		}

		internal readonly string ID;

		internal readonly string Type;

		internal readonly string Price;

		internal readonly Status State;

		internal readonly bool HasPurchaseButton;

		internal IAPDebugProduct(ProductReceivedInfo product)
		{
		}

		private static Status GetProductStatus(ProductReceivedInfo product)
		{
			return default(Status);
		}
	}
}
