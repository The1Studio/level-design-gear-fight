using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI
{
	public class UpgradeableTroopUIController : MonoBehaviour
	{
		[SerializeField]
		private CurrencySO associatedCurrency;

		[SerializeField]
		private ScriptableTroop associatedTroop;

		[SerializeField]
		private Animator groupAnimator;

		[SerializeField]
		private GameObject[] allStarsObjects;

		[SerializeField]
		private GameObject yesAffordRoot;

		[SerializeField]
		private Image displayImage;

		[SerializeField]
		private TextMeshProUGUI levelText;

		[SerializeField]
		private TextMeshProUGUI evolutionProgressText;

		[SerializeField]
		private Slider evolutionProgressSlider;

		[SerializeField]
		private GameObject purchaseRoot;

		[SerializeField]
		private GameObject purchaseButtonRoot;

		[SerializeField]
		private GameObject purchaseYesAfford;

		[SerializeField]
		private GameObject purchaseNoAfford;

		[SerializeField]
		private TextMeshProUGUI purchaseCost;

		[SerializeField]
		private GameObject ownedRoot;

		[SerializeField]
		private GameObject upgradeButtonRoot;

		[SerializeField]
		private GameObject yesAffordBasicRoot;

		[SerializeField]
		private GameObject yesAffordEvoRoot;

		[SerializeField]
		private GameObject noAffordRoot;

		[SerializeField]
		private GameObject yesMaxLevelRoot;

		[SerializeField]
		private GameObject noMaxLevelRoot;

		[SerializeField]
		private GameObject buttonRoot;

		[SerializeField]
		private GameObject lockedRoot;

		[SerializeField]
		private int lockedUntil;

		[SerializeField]
		private AudioSource upgradeSuccessfulSource;

		[SerializeField]
		private AudioSource upgradeFailedSource;

		[SerializeField]
		private GameObject discountTicketRoot;

		[SerializeField]
		private TextMeshProUGUI currentDamageText;

		[SerializeField]
		private TextMeshProUGUI currentHPText;

		[SerializeField]
		private TextMeshProUGUI costText;

		[SerializeField]
		private GameObject activateWhenLocked;

		[SerializeField]
		private TextMeshProUGUI nameText;

		private float targetProgress;

		private float currentProgress;

		private bool hasInitialized;

		private ScriptableTroop rootTroop;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateDisplay(ScriptableTroop obj)
		{
		}

		private void OnEvolve(ScriptableUnlockableUpgradable c)
		{
		}

		private void TroopUnlocked(ScriptableUnlockableUpgradable character)
		{
		}

		private void Unsubscribe()
		{
		}

		public bool CanAffordUnlock(double additionalCoins)
		{
			return false;
		}

		public bool CanAffordUpgrade(double additionalCoins)
		{
			return false;
		}

		public void OnClicked()
		{
		}

		private void UpdateCostTextDisplay()
		{
		}

		private void LevelChanged(ScriptableUnlockableUpgradable c)
		{
		}

		private void CurrencyValueChanged(double value)
		{
		}
	}
}
