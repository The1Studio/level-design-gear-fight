using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.UI
{
	public class PackSelectionController : MonoBehaviour
	{
		[SerializeField]
		private ScriptablePack pack;

		[SerializeField]
		private TroopPackSelectionController troopPackSelectionController;

		[SerializeField]
		private AudioSource clickSource;

		[SerializeField]
		private TextMeshProUGUI packLevelText;

		[SerializeField]
		private TextMeshProUGUI unlockCostText;

		[SerializeField]
		private TextMeshProUGUI levelUpProgressText;

		[SerializeField]
		private Slider fillSlider;

		[SerializeField]
		private GameObject equippedOutline;

		[SerializeField]
		private GameObject selectionOutline;

		[SerializeField]
		private GameObject pendingUpgradeParent;

		[SerializeField]
		private GameObject unlockedParent;

		[SerializeField]
		private GameObject lockedParent;

		[SerializeField]
		private IndividualGearDisplayController gearDisplayPrefab;

		[SerializeField]
		private Transform gearDisplaySpawnTransform;

		[SerializeField]
		private Animator anim;

		private bool unlocked;

		public ScriptablePack Pack => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void PackUnlocked(ScriptablePack _)
		{
		}

		private void SelectedPackChanged(ScriptablePack pack)
		{
		}

		private void ActivePackChanged(ScriptablePack pack)
		{
		}

		public void OnClicked()
		{
		}

		private void PackXPChanged(ScriptablePack _, int __)
		{
		}

		private void PackLevelChanged(ScriptablePack pack, int level)
		{
		}

		private void ItemUnlocked(ScriptableGear obj)
		{
		}

		public void SetEquippedStatus(bool status)
		{
		}

		public void SetSelectedStatus(bool status)
		{
		}

		public void SetUnlockedStatus(bool status)
		{
		}

		private void RefreshUnlocks()
		{
		}
	}
}
