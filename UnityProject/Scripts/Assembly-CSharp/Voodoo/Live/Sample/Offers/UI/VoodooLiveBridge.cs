using Voodoo.Live.Offers;

namespace Voodoo.Live.Sample.Offers.UI
{
	public class VoodooLiveBridge : IVoodooLiveBridge
	{
		public bool CurrencyAvailability(string currency, int amount)
		{
			return false;
		}

		public void CurrencyDebit(string currency, int amount)
		{
		}

		public void PurchaseIAP(string productId)
		{
		}

		public bool RewardingMethod(Transaction transaction)
		{
			return false;
		}

		private bool GrantReward(ItemToQuantity item)
		{
			return false;
		}
	}
}
