using GearGame.Control;
using UnityEngine;

namespace GearGame.Tutorials
{
	public class FirstChestShopTutorial : UICanvasButtonBasedTutorialController
	{
		[SerializeField]
		private CurrencySO chestCurrency;

		public override bool IsTutorialValid()
		{
			return false;
		}
	}
}
