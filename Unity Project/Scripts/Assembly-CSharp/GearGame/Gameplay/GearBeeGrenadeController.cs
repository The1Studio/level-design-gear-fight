using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearBeeGrenadeController : GearSpellSpawnerController
	{
		[SerializeField]
		private GameObject beeGrenadeGroundPrefab;

		public override GearSpawnerData SpawnerData => null;

		protected override GameObject InstantiateSpawnObject()
		{
			return null;
		}
	}
}
