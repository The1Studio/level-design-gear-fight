using System;
using Items;
using UnityEngine;

namespace Data.Operations
{
	[Serializable]
	public class AdTransaction : ITransaction
	{
		[SerializeField]
		private string _placement;

		private AdAvailability _adAvailability;

		public PurchasableChecker PurchasableChecker => null;

		public AdTransaction()
		{
		}

		public AdTransaction(string placement)
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
