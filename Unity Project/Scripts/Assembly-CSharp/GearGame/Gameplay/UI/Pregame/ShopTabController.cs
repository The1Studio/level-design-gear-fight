using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay.UI.Pregame
{
	public class ShopTabController : PreGameTabController
	{
		[SerializeField]
		private CurrencySO freeChestCurrency;

		[SerializeField]
		private LockedTabButtonController lockedTabButtonController;

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void ChestValueChanged(double obj)
		{
		}

		protected override bool DoesHaveWarning()
		{
			return false;
		}

		public static bool DoesHaveFreebie()
		{
			return false;
		}
	}
}
