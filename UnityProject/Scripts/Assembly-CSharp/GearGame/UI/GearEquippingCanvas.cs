using System;
using System.Collections.Generic;
using Core.UI;
using UnityEngine;

namespace GearGame.UI
{
	public class GearEquippingCanvas : Core.UI.Screen
	{
		[SerializeField]
		private Transform spawnTransform;

		[SerializeField]
		private GameObject displayPrefab;

		[SerializeField]
		private GameObject bottomDisplay;

		[SerializeField]
		private IndividualGearDisplayController gearDisplayController;

		[SerializeField]
		private CustomGearsBottomTrayController bottomTrayController;

		[SerializeField]
		private float chanceOfBonusGear;

		[SerializeField]
		private float chanceOfBonusGearPerGear;

		[SerializeField]
		private float chanceOfBonusGearStartingLevel;

		private List<SelectableGearController> allGears;

		private bool swapActive;

		private bool pendingClickOff;

		private SelectableGearController selectedGearForSwap;

		private const int diamondCostForPremiumUpgrade = 10;

		private readonly Tuple<float, int>[] diamondPremiumUpgradeRange;

		public static Transform LastSelectedTransform { get; set; }

		public IList<SelectableGearController> AllGears => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		public void ActivateSwap(SelectableGearController selectableGearController)
		{
		}

		private void DeactivateSwap()
		{
		}

		public void DoSwap(CustomEquippedGearSlotDisplayController slotDisplay)
		{
		}
	}
}
