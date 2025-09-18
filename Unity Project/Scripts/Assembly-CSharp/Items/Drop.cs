using System;
using System.Collections.Generic;

namespace Items
{
	[Serializable]
	public class Drop : BaseDrop
	{
		public ItemSO Item;

		public DropRange Amount;

		public RaritySO RarityOverride;

		public override DropRange GetDropRange(DropRange amount)
		{
			return default(DropRange);
		}

		public override DropInfos GetInfos(DropRange amount, float percentage)
		{
			return default(DropInfos);
		}

		public override IEnumerable<Reward> Claim(double amount, bool record, TransactionLocation transactionLocation)
		{
			return null;
		}
	}
}
