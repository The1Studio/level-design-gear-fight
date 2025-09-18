using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Voodoo.Sauce.IAP;

namespace GearGame.Purchasing
{
	public class IAPPurchaseHandler : IPurchaseDelegateWithInfo, IPurchaseDelegateBase
	{
		public static bool IsInitialized { get; private set; }

		public static event Action<bool> OnInitializationCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ProductReceivedInfo, bool> OnPurchaseConcluded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void OnInitializeFailure(VoodooInitializationFailureReason reason)
		{
		}

		public void OnInitializeSuccess()
		{
		}

		public bool OnPurchaseComplete(ProductReceivedInfo productReceivedInfo, PurchaseValidation purchaseValidation)
		{
			return false;
		}

		public void OnPurchaseFailure(VoodooPurchaseFailureReason reason, [CanBeNull] ProductReceivedInfo productReceivedInfo, string description)
		{
		}
	}
}
