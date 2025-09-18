using System;
using Items;
using UnityEngine;

namespace Data.Operations
{
	[Serializable]
	public class FreeTransaction : ITransaction, ITimedFeature
	{
		[SerializeField]
		private bool _useTimer;

		[SerializeField]
		private float _intervalHours;

		[SerializeField]
		private string _uniqueId;

		private FreeTransactionChecker _freeTransactionChecker;

		public PurchasableChecker PurchasableChecker => null;

		public string GetPriceText()
		{
			return null;
		}

		public void ExecuteTransaction(Action<bool> onComplete, TransactionLocation location)
		{
		}

		public TimeSpan? GetTimeLeft()
		{
			return null;
		}

		public void TransactionShown(TransactionLocation location)
		{
		}
	}
}
