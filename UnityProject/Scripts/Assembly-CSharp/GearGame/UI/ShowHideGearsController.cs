using UnityEngine;
using UnityEngine.UI;

namespace GearGame.UI
{
	public class ShowHideGearsController : MonoBehaviour
	{
		[SerializeField]
		private Transform rootTransformForSpawning;

		[SerializeField]
		private AnimationCurve scalerCurve;

		[SerializeField]
		private AnimationCurve scalerCurveExit;

		[SerializeField]
		private GameObject gearsShownStateRoot;

		[SerializeField]
		private GameObject gearsHiddenStateRoot;

		[SerializeField]
		private GridLayoutGroup gridLayoutGroup;

		[SerializeField]
		private float motionDuration;

		[SerializeField]
		private float startingDelay;

		[SerializeField]
		private float additionalDelayPerUnitY;

		private float delayDeactivate;

		private bool isOpen;

		private bool hasInitialized;

		private void Update()
		{
		}

		private void TryInitialize()
		{
		}

		public void TogglePosition()
		{
		}

		private void SetOpenStatus(bool status)
		{
		}

		public void JumpToPosition()
		{
		}

		private PackSpecificIndividualGearDisplay[] GetPackSpecificIndividualGearDisplays()
		{
			return null;
		}
	}
}
