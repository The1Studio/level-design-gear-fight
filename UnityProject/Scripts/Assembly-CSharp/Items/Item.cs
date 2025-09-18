using System;
using UnityEngine;

namespace Items
{
	[Serializable]
	public abstract class Item : IEquatable<Item>
	{
		public abstract ItemSO Settings { get; }

		public ItemNames Id => default(ItemNames);

		public virtual string Name => null;

		public virtual Sprite Icon => null;

		public virtual RaritySO Rarity => null;

		public virtual bool Equals(Item other)
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

		public virtual void Animate(int burstAmount, Vector2 position)
		{
		}

		public virtual void Cancel()
		{
		}

		public virtual double GetBalance()
		{
			return 0.0;
		}
	}
}
