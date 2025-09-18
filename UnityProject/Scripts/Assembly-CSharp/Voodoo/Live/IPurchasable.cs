using System;

namespace Voodoo.Live
{
	public interface IPurchasable
	{
		event Action purchaseStarted;

		event Action purchaseFailed;

		event Action purchasePaid;

		event Action purchaseRewarded;

		bool CanAfford();

		void Purchase();
	}
}
