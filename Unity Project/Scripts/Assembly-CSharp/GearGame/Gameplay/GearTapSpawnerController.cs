using GearGame.Control;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class GearTapSpawnerController : GearSpawnerController
	{
		public enum ObjectInstantiationType
		{
			CenterCameraOnlyAdjustX = 0
		}

		[SerializeField]
		private ObjectInstantiationType instantiationType;

		[SerializeField]
		private GameObject tapToActivateObject;

		protected override float MaxProduction => 0f;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void StateChanged(GameStateManager.GameState state)
		{
		}

		protected override void ObjectSpawned(GameObject go)
		{
		}

		protected override void DoSpawn(int spawnNumber)
		{
		}

		private void TryLaunch()
		{
		}
	}
}
