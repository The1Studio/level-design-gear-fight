using System;
using System.Collections.Generic;

namespace Items
{
	[Serializable]
	public class PayoutableDrop : BaseDrop
	{
		public ItemSO Item;

		public float PayoutPercentage;

		public int RoundToNearest;

		public RaritySO RarityOverride;

		private double GetPayout()
		{
			return 0.0;
		}

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
