using System;
using System.Collections.Generic;
using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.UI
{
	public class PackSelectedDisplayController : MonoBehaviour
	{
		[Serializable]
		private class GearDisplaySection
		{
			[field: SerializeField]
			public Transform Transform { get; private set; }

			[field: SerializeField]
			public int Number { get; private set; }
		}

		[SerializeField]
		private IndividualGearDisplayController gearDisplayPrefab;

		[SerializeField]
		private GearDisplaySection[] gearDisplaySpawnSections;

		[SerializeField]
		private TextMeshProUGUI titleText;

		[SerializeField]
		private TextMeshProUGUI rankText;

		[SerializeField]
		private TextMeshProUGUI numberTroopsText;

		[SerializeField]
		private TextMeshProUGUI numberGearsText;

		[SerializeField]
		private TroopPackSelectionController troopPackSelectionController;

		[SerializeField]
		private string levelLocalizationKey;

		[SerializeField]
		private GameObject pendingUpgradeGrunt;

		[SerializeField]
		private GameObject pendingUpgradeRanged;

		[SerializeField]
		private GameObject pendingUpgradeBrute;

		[SerializeField]
		private Image[] gruntTroopImages;

		[SerializeField]
		private Image[] rangedTroopImages;

		[SerializeField]
		private Image[] bruteTroopImages;

		[SerializeField]
		private GameObject gruntTroopObjectLocked;

		[SerializeField]
		private GameObject rangedTroopObjectLocked;

		[SerializeField]
		private GameObject bruteTroopObjectLocked;

		[SerializeField]
		private GameObject buyButtonRoot;

		[SerializeField]
		private GameObject buyButtonYesAffordRoot;

		[SerializeField]
		private GameObject buyButtonNoAffordRoot;

		[SerializeField]
		private GameObject freeButtonYesAffordRoot;

		[SerializeField]
		private GameObject freeButtonNoAffordRoot;

		[SerializeField]
		private GameObject useGemsRoot;

		[SerializeField]
		private GameObject useUnlockLevelRoot;

		[SerializeField]
		private TextMeshProUGUI[] costTexts;

		[SerializeField]
		private GameObject equipButtonRoot;

		[SerializeField]
		private GameObject upgradeButtonRoot;

		[SerializeField]
		private CurrencySO gemCurrency;

		[SerializeField]
		private CurrencySO blueCoinCurrency;

		private ScriptablePack pack;

		private List<IndividualGearDisplayController> spawnedGears;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Initialize(ScriptablePack pack)
		{
		}

		private void Subscribe(ScriptablePack pack)
		{
		}

		private void Unsubscribe()
		{
		}

		private void ActivePackChanged(ScriptablePack obj)
		{
		}

		private void CurrencyValueChanged(double obj)
		{
		}

		private void TroopUnlocked(ScriptableUnlockableUpgradable obj)
		{
		}

		private void TroopLevelUp(ScriptableUnlockableUpgradable obj)
		{
		}

		private void TroopEvolved(ScriptableUnlockableUpgradable obj)
		{
		}

		private void OnUnlocked(ScriptablePack obj)
		{
		}

		private void LevelChanged(ScriptablePack arg1, int arg2)
		{
		}

		private void RefreshPackBottomButtonDisplays()
		{
		}

		private void RefreshPackTitleDisplays()
		{
		}

		private void RefreshPackTroopDisplays()
		{
		}

		private void RefreshPackGearDisplays()
		{
		}

		public void OnEquipButtonPressed()
		{
		}

		public void OnBuyButtonPressed()
		{
		}

		public void OnPackUpgradeButtonPressed()
		{
		}

		public void OnEvolveButtonPressed()
		{
		}
	}
}
