using GearGame.Control;
using UnityEngine;

namespace GearGame.Tutorials
{
	public class UnlockPackTutorial : UICanvasButtonBasedTutorialController
	{
		[SerializeField]
		private ScriptablePack pack;

		public override bool IsTutorialValid()
		{
			return false;
		}
	}
}
