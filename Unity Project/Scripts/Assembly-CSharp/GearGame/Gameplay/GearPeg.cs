using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearPeg : MonoBehaviour, IGearHolder
	{
		public enum PegActivatorType
		{
			None = 0,
			Producer = 1,
			All = 2
		}

		[SerializeField]
		private Transform targetRestingPosition;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private Transform[] rotateWithGear;

		[SerializeField]
		private Animator hasActiveGearAnimator;

		[SerializeField]
		private PegActivatorType activatorType;

		private readonly List<object> allLockers;

		private bool gearActive;

		private readonly int activeHash;

		public GameObject GameObject => null;

		public bool CanBeUsedInSwaps => false;

		[field: SerializeField]
		public float ScaleMultiplier { get; set; }

		[field: SerializeField]
		public float AdditionalProductionMultiplier { get; private set; }

		public GearController GearDisplay { get; private set; }

		public bool CanSpawnSpinner { get; set; }

		public int Index { get; set; }

		public bool Locked { get; private set; }

		public float DefaultRotation { get; set; }

		public bool IsProductionMultiplierGear => false;

		public event Action<GearController> OnGearChanged
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

		protected virtual void Awake()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void AddPegLock(object o)
		{
		}

		public void RemovePegLock(object o)
		{
		}

		public void SetHighlightStatus(bool status)
		{
		}

		public void AddGear(GearController gear)
		{
		}

		protected virtual bool ValidatePegGlow(GearController gear)
		{
			return false;
		}

		protected void RecheckGlow()
		{
		}

		private void SelectionChanged(GearController gear, bool status)
		{
		}

		public void RemoveGear(GearController gear)
		{
		}
	}
}
