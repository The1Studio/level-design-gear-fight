using System;

namespace Items
{
	[Serializable]
	public struct Reward : IEquatable<Reward>
	{
		public Item Item;

		public double Amount;

		public Reward(Item item, double amount)
		{
			Item = null;
			Amount = 0.0;
		}

		public bool Equals(Reward other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
