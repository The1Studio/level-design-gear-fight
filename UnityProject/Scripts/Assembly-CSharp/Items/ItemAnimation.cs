using System;
using UnityEngine;

namespace Items
{
	[Serializable]
	public abstract class ItemAnimation
	{
		public Action<bool> onAnimationUpdate;

		public bool IsAnimating { get; protected set; }

		public virtual float Progress { get; }

		public abstract void Animate(int amount, Vector2 position);

		public abstract void Cancel();

		public virtual void SetTimeScale(float timeScale)
		{
		}
	}
}
