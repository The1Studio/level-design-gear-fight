using UnityEngine;

namespace GearGame.Gameplay.UI.Pregame
{
	public class QuestsTabController : PreGameTabController
	{
		[SerializeField]
		private LockedTabButtonController lockedTabButtonController;

		protected override bool DoesHaveWarning()
		{
			return false;
		}
	}
}
