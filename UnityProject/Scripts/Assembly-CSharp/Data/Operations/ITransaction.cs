using System;
using Items;

namespace Data.Operations
{
	public interface ITransaction
	{
		PurchasableChecker PurchasableChecker { get; }

		string GetPriceText();

		void ExecuteTransaction(Action<bool> onComplete, TransactionLocation location);

		void TransactionShown(TransactionLocation location);
	}
}
