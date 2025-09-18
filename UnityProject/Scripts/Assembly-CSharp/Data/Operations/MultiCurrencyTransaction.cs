using System;
using Items;
using UnityEngine;

namespace Data.Operations
{
	[Serializable]
	public class MultiCurrencyTransaction : ITransaction
	{
		[SerializeField]
		private CurrencyPrice[] _prices;

		private MultiCurrencyRefresher _currencyRefresher;

		public PurchasableChecker PurchasableChecker => null;

		public MultiCurrencyTransaction()
		{
		}

		public MultiCurrencyTransaction(params CurrencyPrice[] prices)
		{
		}

		public string GetPriceText()
		{
			return null;
		}

		public void ExecuteTransaction(Action<bool> onComplete, TransactionLocation location)
		{
		}

		public void TransactionShown(TransactionLocation location)
		{
		}
	}
}
