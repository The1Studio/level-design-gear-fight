using System;
using System.Runtime.CompilerServices;

namespace Voodoo.Live
{
	public class VirtualCurrencyPurchase : IPurchasable
	{
		public VirtualCurrencyPrice price;

		public event Func<string, int, bool> currencyAvailability
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

		public event Action<string, int> currencyDebit
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

		public VirtualCurrencyPurchase(VirtualCurrencyPrice price, Func<string, int, bool> currencyCheck, Action<string, int> currencyDebit)
		{
		}

		public bool CanAfford()
		{
			return false;
		}

		public void Purchase()
		{
		}
	}
}
