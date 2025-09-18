using Core.UI;
using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VInspector;

namespace GearGame.UI
{
	public class GearDetailsCanvas : Popup
	{
		[SerializeField]
		private SerializedDictionary<ScriptableGear.GearInfo.GearTags, GameObject> allTags;

		[SerializeField]
		private Transform spawnTransformForTags;

		[SerializeField]
		private Image gearBackgroundImage;

		[SerializeField]
		private Image gearForegroundImage;

		[SerializeField]
		private TextMeshProUGUI gearDisplayNumber;

		[SerializeField]
		private TextMeshProUGUI gearNameDisplay;

		[SerializeField]
		private TextMeshProUGUI gearDescriptionDisplay;

		[SerializeField]
		private TextMeshProUGUI costTextDisplay;

		[SerializeField]
		private GearLevelDisplayController levelDisplayController;

		[SerializeField]
		private SerializedDictionary<GearUpgradeUnlockProfile.Tier, GameObject> tierDisplayObjects;

		private ScriptableGear _gear;

		public ScriptableGear Gear => null;

		public void Initialize(ScriptableGear gear)
		{
		}

		private void SetLevelAndRarity(ScriptableGear gear)
		{
		}

		private void ClearTags()
		{
		}
	}
}
