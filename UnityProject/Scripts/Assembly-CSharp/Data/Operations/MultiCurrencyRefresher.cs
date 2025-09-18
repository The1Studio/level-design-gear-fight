namespace Data.Operations
{
	public class MultiCurrencyRefresher : PurchasableChecker
	{
		private CurrencyPrice[] _prices;

		public MultiCurrencyRefresher(CurrencyPrice[] prices)
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
