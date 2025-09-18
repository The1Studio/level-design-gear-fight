using System;
using System.Runtime.CompilerServices;

namespace Voodoo.Live
{
	public class RewardedVideoPurchase : IPurchasable
	{
		public RewardedVideoPrice price;

		public int RVLeft;

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

		public RewardedVideoPurchase(RewardedVideoPrice price)
		{
		}

		public bool CanAfford()
		{
			return false;
		}

		public void Purchase()
		{
		}

		private void OnRVComplete(bool watchedEntirely)
		{
		}
	}
}
