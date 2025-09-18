using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Tutorials
{
	public class ClaimFirstQuestTutorial : UICanvasButtonBasedTutorialController
	{
		[SerializeField]
		private string uniqueIDForQuestButtonStep;

		[SerializeField]
		private string uniqueIDForClaimButtonStep;

		private Button questButtonTarget;

		private Button claimButtonTarget;

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
