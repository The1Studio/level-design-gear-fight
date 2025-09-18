using System;
using System.Collections.Generic;
using UnityEngine;

namespace Items
{
	public abstract class ItemSystem : MonoBehaviour
	{
		public abstract Type Type { get; }

		internal virtual void Initialize(ItemManagerSO settings)
		{
		}

		public abstract IEnumerable<Reward> Claim(ItemSO item, double amount, RaritySO rarity);

		public abstract void Save(IEnumerable<Reward> rewards);

		public abstract IEnumerable<Reward> GetRewards();

		public abstract void ClearRewards();

		public virtual void OnDataReloaded()
		{
		}

		public virtual void CancelItemsAnimation()
		{
		}

		public virtual void SetItemsAnimationtTimeScale(float timeScale)
		{
		}
	}
	public abstract class ItemSystem<T> : ItemSystem where T : ItemSO
	{
		public override Type Type => null;

		protected abstract void Initialize(T[] settings);

		internal override void Initialize(ItemManagerSO settings)
		{
		}
	}
}
