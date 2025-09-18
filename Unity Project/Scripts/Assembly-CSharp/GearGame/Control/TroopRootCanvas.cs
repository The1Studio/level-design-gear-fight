using Core.UI;
using GearGame.UI;
using UnityEngine;

namespace GearGame.Control
{
	public class TroopRootCanvas : Core.UI.Screen
	{
		[SerializeField]
		private TroopPackCanvasController packCanvasController;

		[SerializeField]
		private TroopPackSelectionController packSelectionController;

		[SerializeField]
		private TroopPackGearUnlockingCanvasController unlockCanvasController;

		private MainMenuScreen mainMenuScreen;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void TabButtonPressed(MainMenuScreen.Tab currentTab, MainMenuScreen.Tab pressedTab)
		{
		}

		public void ActivatePackUpgrade(ScriptablePack pack)
		{
		}

		public void OnAllPackButtonPressed()
		{
		}

		public void ActivatePack(ScriptablePack pack)
		{
		}
	}
}
