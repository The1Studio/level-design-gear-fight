using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearStarController : GearSpellSpawnerController
	{
		[SerializeField]
		private GameObject starGroundPrefab;

		public override GearSpawnerData SpawnerData => null;

		protected override GameObject InstantiateSpawnObject()
		{
			return null;
		}
	}
}
