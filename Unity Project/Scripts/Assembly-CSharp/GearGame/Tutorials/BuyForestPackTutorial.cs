using GearGame.Control;
using UnityEngine;

namespace GearGame.Tutorials
{
	public class BuyForestPackTutorial : UICanvasButtonBasedTutorialController
	{
		[SerializeField]
		private ScriptablePack forestPack;

		public override bool IsTutorialValid()
		{
			return false;
		}
	}
}
