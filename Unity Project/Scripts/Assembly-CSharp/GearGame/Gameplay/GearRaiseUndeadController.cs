using Gameplay._Data;
using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearRaiseUndeadController : GearSpawnerController
	{
		private float lastCheckedPercent;

		public override GearSpawnerData SpawnerData => null;

		protected override float MaxProduction => 0f;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnEnemyKilled(TroopController character)
		{
		}

		protected override void ObjectSpawned(GameObject go)
		{
		}

		protected override string GetProductionDisplayText(float output)
		{
			return null;
		}

		protected override void DoSpawn(int spawnNumber)
		{
		}
	}
}
