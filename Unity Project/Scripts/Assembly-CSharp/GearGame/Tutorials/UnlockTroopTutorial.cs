using GearGame.Control;
using UnityEngine;

namespace GearGame.Tutorials
{
	public class UnlockTroopTutorial : UICanvasButtonBasedTutorialController
	{
		[SerializeField]
		private ScriptableTroop character;

		[SerializeField]
		private CurrencySO currency;

		public override bool IsTutorialValid()
		{
			return false;
		}
	}
}
