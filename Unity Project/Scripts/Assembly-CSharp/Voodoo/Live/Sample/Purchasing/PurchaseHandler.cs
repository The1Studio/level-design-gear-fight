using System;
using System.Collections.Generic;
using Voodoo.Live.Offers;
using Voodoo.Live.Shop.Data;
using Voodoo.Sauce.IAP;

namespace Voodoo.Live.Sample.Purchasing
{
	public class PurchaseHandler : IPurchaseDelegateWithInfo, IPurchaseDelegateBase
	{
		public static Action<bool> PurchaseCompleted;

		private string TAG;

		private IAPStatus _status;

		private IRewardsManager _rewardsManager;

		private List<Product> _shopProducts;

		private string _shopPurchaseId;

		private const string SHOP_PURCHASE_ID_KEY = "shop_purchase_id";

		public void Initialize(IRewardsManager rewardsManager, List<IFeature> activeOffers = null, List<Product> shopProducts = null)
		{
		}

		public void GiveContext(string id)
		{
		}

		private void OnIAPStatusUpdate(IAPStatus status)
		{
		}

		public void OnInitializeSuccess()
		{
		}

		public void OnInitializeFailure(VoodooInitializationFailureReason reason)
		{
		}

		public bool OnPurchaseComplete(ProductReceivedInfo productReceivedInfo, PurchaseValidation purchaseValidation)
		{
			return false;
		}

		public void OnPurchaseFailure(VoodooPurchaseFailureReason reason, ProductReceivedInfo productReceivedInfo, string description)
		{
		}

		public void OnIAPProductsListChanged(List<string> updatedProductIDs)
		{
		}
	}
}
