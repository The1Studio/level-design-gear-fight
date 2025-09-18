using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Tutorials
{
	public class UnlockFirstMiniGearTutorial : UICanvasButtonBasedTutorialController
	{
		[SerializeField]
		private string uniqueIDForUpgradeableButtonStep;

		[SerializeField]
		private string uniqueIDForEquipButtonStep;

		private Button unlockButtonTarget;

		private TutorialButtonGUIDTarget equipButtonTarget;

		public override bool IsTutorialValid()
		{
			return false;
		}

		protected override Button GetButton(HandButton button)
		{
			return null;
		}
	}
}
