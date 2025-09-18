using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Tutorials
{
	public class EquipFirstGearsTutorial : UICanvasButtonBasedTutorialController
	{
		[SerializeField]
		private string findButtonUniqueID;

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
