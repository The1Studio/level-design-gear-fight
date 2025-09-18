using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class ItemTransactionParameters
	{
		public ItemTransactionInfo item;

		public double nbUnits;

		public TransactionType transactionType;

		[CanBeNull]
		public string level;

		[CanBeNull]
		public double? unitCost;

		[CanBeNull]
		public Enum currencyUsed;

		[CanBeNull]
		public double? balance;

		[CanBeNull]
		public string iapLocalCurrency;

		[CanBeNull]
		public Enum placement;

		[CanBeNull]
		public string subPlacement;

		[CanBeNull]
		public string placementId;

		[CanBeNull]
		public Dictionary<string, object> eventContextProperties;

		public ItemTransactionParameters(ItemTransactionInfo item, double nbUnits, TransactionType transactionType)
		{
		}
	}
}
