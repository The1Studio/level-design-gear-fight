using GearGame.Control;
using UnityEngine;

namespace GearGame.Tutorials
{
	public class SkillActivationTutorial : UICanvasButtonBasedTutorialController
	{
		[SerializeField]
		private CurrencySO greenCurrency;

		public override bool IsTutorialValid()
		{
			return false;
		}
	}
}
