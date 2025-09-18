using UnityEngine;

namespace GearGame.Gameplay
{
	public class AcornBuffController : BoostController
	{
		[SerializeField]
		private ProjectileController launchingAcorn;

		protected override void ApplyGearModification(GearController gear)
		{
		}

		protected override void RevertGearModification(GearController gear)
		{
		}

		private void ObjectSpawned(GearSpawnerController spawner, GameObject _)
		{
		}

		protected virtual GameObject InstantiateSpawnObject(GearSpawnerController spawner)
		{
			return null;
		}

		private void NotifySpawning()
		{
		}
	}
}
