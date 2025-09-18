using System.Collections.Generic;
using Items;

namespace UI.Shop
{
	public interface ITransactionResult
	{
		List<DropInfos> GetDrops();

		void OnTransactionCompleted(TransactionLocation location);
	}
}
