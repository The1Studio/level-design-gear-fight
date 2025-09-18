using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearExplosiveBarrelController : GearSpellSpawnerController
	{
		[SerializeField]
		private GameObject explosiveBarrelGroundPrefab;

		public override GearSpawnerData SpawnerData => null;

		protected override GameObject InstantiateSpawnObject()
		{
			return null;
		}
	}
}
