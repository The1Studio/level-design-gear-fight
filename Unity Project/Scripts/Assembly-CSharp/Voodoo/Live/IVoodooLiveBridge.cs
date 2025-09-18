namespace Voodoo.Live
{
	public interface IVoodooLiveBridge
	{
		bool CurrencyAvailability(string currency, int amount);

		void CurrencyDebit(string currency, int amount);

		void PurchaseIAP(string productId);

		bool RewardingMethod(Transaction transaction);
	}
}
