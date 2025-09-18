using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay.UI.Pregame
{
	public class SkillsTabController : PreGameTabController
	{
		[SerializeField]
		private CurrencySO greenCoinsCurrency;

		protected override bool DoesHaveWarning()
		{
			return false;
		}
	}
}
