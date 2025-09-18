using Core.UI;
using GearGame.Gameplay.Managers;
using GearGame.Gameplay.UI.Pregame;

namespace Core.Flow
{
	public class MainMenu : Mode
	{
		private MainMenuScreen _mainScreen;

		private PreGameRootCanvasController _home;

		private const GameStateManager.GameState STARTING_GAME_STATE = GameStateManager.GameState.Pregame;

		protected override void OnEnterInternal()
		{
		}

		private void InitGameState()
		{
		}

		protected override void OnExitInternal()
		{
		}

		private void PlayNormalGameplay()
		{
		}

		private void PlayBossGameplay()
		{
		}
	}
}
