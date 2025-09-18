using System;
using Voodoo.Live.Offers;

namespace Voodoo.Live
{
	public class Transaction
	{
		public string productId;

		public string featureId;

		public string featureName;

		public string featureType;

		public ItemToQuantity[] rewards;

		public DateTime lastUpdate;

		public TransactionStatus status;

		public void SetStatus(TransactionStatus newStatus)
		{
		}
	}
}
