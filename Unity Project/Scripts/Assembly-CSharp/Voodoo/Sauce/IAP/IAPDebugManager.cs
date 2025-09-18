using JetBrains.Annotations;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Debugger;

namespace Voodoo.Sauce.IAP
{
	internal class IAPDebugManager : IPurchaseDelegateWithInfo, IPurchaseDelegateBase
	{
		private const string CALLBACK_PURCHASE_SUCCESS_WITH_TRANSACTION_ID_FORMAT = "You have successfully bought this product. With transaction ID: {0}";

		private const string CALLBACK_RESTORE_SUCCESS_WITH_TRANSACTION_ID_FORMAT = "You have successfully restored this product. With transaction ID: {0}";

		private const string LIGHT_MESSAGE_NO_PRODUCTS = "There is no product in this project.\nYou can add them in the VoodooSettings.";

		private const string LIGHT_MESSAGE_INITIALIZING = "Waiting for the In-App Purchase initialization...";

		private const string LIGHT_MESSAGE_NOT_INITIALIZED = "The In-App Purchase initialization has not started yet.";

		private const string LIGHT_MESSAGE_DISABLED = "In-App Purchase isn't activated on your project.";

		private const string LIGHT_MESSAGE_NOT_INSTALLED = "In-App Purchase isn't installed on your project.";

		private const string ERROR_MESSAGE_HEADER = "In-App purchase initialization has failed.\n";

		private const string ERROR_MESSAGE_APP_NOT_KNOWN = "In-App purchase initialization has failed.\nIs your App correctly uploaded on the relevant publisher console?";

		private const string ERROR_MESSAGE_PURCHASING_UNAVAILABLE = "In-App purchase initialization has failed.\nBilling is disabled.";

		private const string ERROR_MESSAGE_NO_PRODUCTS = "In-App purchase initialization has failed.\nNo products available for purchase.";

		private readonly IAPDebugScreen _screen;

		private IAPInitializationState _iapInitializationState;

		private readonly VoodooSettings _voodooSettings;

		internal IAPDebugManager(IAPDebugScreen screen, VoodooSettings voodooSettings)
		{
		}

		internal void OnScreenDisplayed()
		{
		}

		private void Initialize()
		{
		}

		private void RefreshDisplayedProducts()
		{
		}

		internal void OnVoodooPremiumToggle(bool isOn)
		{
		}

		private void RefreshVoodooPremiumToggle()
		{
		}

		private void OnIAPStatusUpdate(IAPStatus status)
		{
		}

		private void DisplayInitializationFailureMessage(VoodooInitializationFailureReason? reason)
		{
		}

		public void OnInitializeSuccess()
		{
		}

		public void OnInitializeFailure(VoodooInitializationFailureReason reason)
		{
		}

		public bool OnPurchaseComplete(ProductReceivedInfo productInfo, PurchaseValidation purchaseValidation)
		{
			return false;
		}

		public void OnPurchaseFailure(VoodooPurchaseFailureReason reason, [CanBeNull] ProductReceivedInfo productInfo, string description)
		{
		}
	}
}
