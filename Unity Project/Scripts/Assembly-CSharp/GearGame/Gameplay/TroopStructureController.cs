using Gameplay._Data;
using GearGame.Gameplay.Managers;

namespace GearGame.Gameplay
{
	public class TroopStructureController : TroopController
	{
		private StructureData _data;

		public override TroopData Data => null;

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}
	}
}
