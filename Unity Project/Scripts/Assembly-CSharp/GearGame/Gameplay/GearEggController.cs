using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearEggController : GearSpellSpawnerController
	{
		[SerializeField]
		private GameObject eggGroundPrefab;

		public override GearSpawnerData SpawnerData => null;

		protected override GameObject InstantiateSpawnObject()
		{
			return null;
		}
	}
}
