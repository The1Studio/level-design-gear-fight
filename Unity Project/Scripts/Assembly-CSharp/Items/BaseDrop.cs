using System;
using System.Collections.Generic;

namespace Items
{
	[Serializable]
	public abstract class BaseDrop
	{
		public int Weight;

		[ReadOnly]
		public float Percentage;

		public abstract DropRange GetDropRange(DropRange amount);

		public abstract DropInfos GetInfos(DropRange amount, float percentage);

		public abstract IEnumerable<Reward> Claim(double amount, bool record, TransactionLocation transactionLocation);
	}
}
