using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class BoostController : MonoBehaviour
	{
		protected GearController attachedGear;

		[SerializeField]
		private ParticleSystem system;

		[SerializeField]
		private Transform scalerTransform;

		public GearController AttachedGear => null;

		public event Action<BoostController> Destroyed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected abstract void ApplyGearModification(GearController gear);

		protected abstract void RevertGearModification(GearController gear);

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		public void Clear()
		{
		}

		private void Detach()
		{
		}

		public virtual void Attach(GearController gear)
		{
		}
	}
}
