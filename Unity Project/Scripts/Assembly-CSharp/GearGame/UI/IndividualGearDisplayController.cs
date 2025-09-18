using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.UI
{
	public class IndividualGearDisplayController : MonoBehaviour
	{
		[SerializeField]
		private ScriptableGear associatedGear;

		[SerializeField]
		private Image[] gearBackgroundImages;

		[SerializeField]
		private Image[] gearForegroundImages;

		[SerializeField]
		private TextMeshProUGUI gearDisplayNumber;

		[SerializeField]
		private bool allowLockedDisplay;

		[SerializeField]
		private GameObject lockedRoot;

		[SerializeField]
		private GameObject unlockedRoot;

		[SerializeField]
		private TextMeshProUGUI unlockProgressDisplayNumber;

		public ScriptableGear Gear => null;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Reinitialize()
		{
		}

		public void Initialize(IndividualGearDisplayController gearDisplayController)
		{
		}

		private void Unsubscribe()
		{
		}

		public void Initialize(ScriptableGear associatedGear)
		{
		}

		private void GearNumberChanged(ScriptableGear gear, int _)
		{
		}

		private void SetDisplay()
		{
		}

		private void GearUnlocked(ScriptableGear obj)
		{
		}

		public void OnInfoPressed()
		{
		}
	}
}
