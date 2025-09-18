using System;
using System.Runtime.CompilerServices;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Live
{
	public class IAPPurchase : IPurchasable
	{
		public RealCurrencyPrice price { get; set; }

		public event Action purchaseStarted
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

		public event Action purchaseFailed
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

		public event Action purchasePaid
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

		public event Action purchaseRewarded
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

		public event Action<string> purchaseIAP
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

		public IAPPurchase(RealCurrencyPrice price, Action<string> purchaseMethod)
		{
		}

		public bool CanAfford()
		{
			return false;
		}

		public void Purchase()
		{
		}

		private void OnPurchaseFailed(IIAPFailedInfo info)
		{
		}

		private void OnPurchaseComplete(IIAPRewardedInfo info)
		{
		}
	}
}
