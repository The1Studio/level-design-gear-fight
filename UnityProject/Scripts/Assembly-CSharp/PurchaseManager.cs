using System.Collections.Generic;
using Voodoo.Sauce.IAP;

public class PurchaseManager : IPurchaseDelegateWithInfo, IPurchaseDelegateBase
{
	private const string TAG = "PURCHASE_MANAGER";

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
