using System;
using System.Runtime.CompilerServices;
using GearGame.Advertising;
using GearGame.Control;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearStoreSlot : MonoBehaviour, IGearHolder
	{
		[SerializeField]
		private Transform targetRestingPosition;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private TextMeshPro displayCostText;

		[SerializeField]
		private GameObject discountTag;

		[SerializeField]
		private GameObject costRoot;

		[SerializeField]
		private GameObject yesAffordParent;

		[SerializeField]
		private GameObject noAffordParent;

		[SerializeField]
		private GameObject purchaseRootParent;

		[SerializeField]
		private GameObject freeRootParent;

		[SerializeField]
		private ScriptableSkill luckSkill;

		[SerializeField]
		private RewardedADButtonController rewardedADButtonController;

		private bool isRVGear;

		private bool gemStatus;

		public GameObject GameObject => null;

		public bool CanBeUsedInSwaps => false;

		public float DefaultRotation => 0f;

		[field: SerializeField]
		public float ScaleMultiplier { get; private set; }

		public GearController GearDisplay { get; private set; }

		public bool IsFree { get; set; }

		public bool HadGear { get; set; }

		public event Action<GearStoreSlot> OnGearChanged
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

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void CoinsChanged(float value)
		{
		}

		public void AddGear(GearController gearController)
		{
		}

		public void SetStatusToNull()
		{
		}

		private void CheckPurchaseState()
		{
		}

		public void SetRVStatus(bool isRVGear)
		{
		}

		private void SelectionStatusChanged(GearController gearController, bool status)
		{
		}

		private void GearFailedPurchase(GearController gearController)
		{
		}

		public void RemoveGear(GearController gearController)
		{
		}
	}
}
