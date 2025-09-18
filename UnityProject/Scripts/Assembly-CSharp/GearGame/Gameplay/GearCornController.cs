using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearCornController : GearSpellSpawnerController
	{
		[SerializeField]
		private GameObject cornGroundPrefab;

		public override GearSpawnerData SpawnerData => null;

		protected override GameObject InstantiateSpawnObject()
		{
			return null;
		}
	}
}
