using System;
using GearGame.Control;
using Items;
using UnityEngine;

namespace Data.Operations
{
	[Serializable]
	public class CurrencyTransaction : ITransaction
	{
		[SerializeField]
		private CurrencySO _currency;

		[SerializeField]
		private double _amount;

		private CurrencyRefresher _currencyRefresher;

		public PurchasableChecker PurchasableChecker => null;

		public CurrencyTransaction()
		{
		}

		public CurrencyTransaction(CurrencySO currency, double amount)
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
