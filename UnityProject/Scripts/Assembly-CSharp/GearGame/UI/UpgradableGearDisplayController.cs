using System.Collections.Generic;
using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VInspector;

namespace GearGame.UI
{
	public class UpgradableGearDisplayController : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI progressDisplayText;

		[SerializeField]
		private GameObject equippedBackground;

		[SerializeField]
		private Transform displayRoot;

		[SerializeField]
		private float offsetYWhenMaxLevelNoButton;

		[SerializeField]
		private Slider fillSlider;

		[SerializeField]
		private GameObject evolveText;

		[SerializeField]
		private GameObject unlockText;

		[SerializeField]
		private GameObject lockedParent;

		[SerializeField]
		private GameObject unlockedParent;

		[SerializeField]
		private GameObject pendingEvolutionParent;

		[SerializeField]
		private GameObject yesMaxLevelParent;

		[SerializeField]
		private GameObject noMaxLevelParent;

		[SerializeField]
		private GameObject miniGearUpgradeRoot;

		[SerializeField]
		private GameObject yesAffordParent;

		[SerializeField]
		private GameObject noAffordParent;

		[SerializeField]
		private GameObject gemUpgradeRootParent;

		[SerializeField]
		private TextMeshProUGUI gemUpgradeCostText;

		[SerializeField]
		private TextMeshProUGUI gemUpgradeNumberText;

		[SerializeField]
		private GemTransactionHelper gemTransactionHelper;

		[SerializeField]
		private Animator gemButtonAnimator;

		[SerializeField]
		private GameObject lockedButtonParent;

		[SerializeField]
		private GameObject upgradeButtonRootParent;

		[SerializeField]
		private GameObject shineParent;

		[SerializeField]
		private GameObject progressBarRoot;

		[SerializeField]
		private Animator wiggleAnim;

		[SerializeField]
		private Animator upgradeUnlockAnim;

		[SerializeField]
		private IndividualGearDisplayController gearDisplayController;

		[SerializeField]
		private SerializedDictionary<GearUpgradeUnlockProfile.Tier, GameObject> tierDisplayObjects;

		[SerializeField]
		private GameObject notificationObject;

		private ScriptableGear attachedGear;

		private float startingYOffsetForRoot;

		private bool isGemState;

		private int gemAmount;

		private int numberUpgrades;

		private bool hasInitialized;

		public ScriptableGear Gear => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Initialize(ScriptableGear gear)
		{
		}

		public void SetToGemStatus(bool status, bool doSetGemRootStatus, int gemAmount, int numberUpgrades)
		{
		}

		private void SetDisplayRootStatus()
		{
		}

		public void OnUnlockEvolveButtonPressed()
		{
		}

		private void NotificationChanged(ScriptableGear _, bool status)
		{
		}

		private void LoadoutChanged(IList<ScriptableGear> gears)
		{
		}

		private void GearUnlocked(ScriptableGear _)
		{
		}

		private void NumberChanged(ScriptableGear _, int num)
		{
		}

		private void EvolutionChanged(ScriptableGear _, GearUpgradeUnlockProfile.Tier tier)
		{
		}

		private void Unsubscribe()
		{
		}
	}
}
