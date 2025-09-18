using GearGame.Control;

namespace Data.Operations
{
	public class CurrencyRefresher : PurchasableChecker
	{
		private CurrencySO _currency;

		private double _amount;

		public CurrencyRefresher(CurrencySO currency, double amount)
		{
		}

		private void OnAmountChanged(double amount)
		{
		}

		public override void Dispose()
		{
		}
	}
}
