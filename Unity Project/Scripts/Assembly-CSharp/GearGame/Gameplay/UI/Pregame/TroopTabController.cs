using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay.UI.Pregame
{
	public class TroopTabController : PreGameTabController
	{
		[SerializeField]
		private CurrencySO blueCoinCurrency;

		protected override bool DoesHaveWarning()
		{
			return false;
		}

		private bool CanAffordUpgradeUnlock(ScriptableTroop character)
		{
			return false;
		}
	}
}
