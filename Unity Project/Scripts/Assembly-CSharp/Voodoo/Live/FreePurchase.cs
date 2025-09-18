using System;
using System.Runtime.CompilerServices;

namespace Voodoo.Live
{
	public class FreePurchase : IPurchasable
	{
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

		public bool CanAfford()
		{
			return false;
		}

		public void Purchase()
		{
		}
	}
}
