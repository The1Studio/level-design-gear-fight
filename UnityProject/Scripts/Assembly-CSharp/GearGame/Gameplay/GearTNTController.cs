using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearTNTController : GearSpellSpawnerController
	{
		[SerializeField]
		private GameObject TNTGroundPrefab;

		public override GearSpawnerData SpawnerData => null;

		protected override GameObject InstantiateSpawnObject()
		{
			return null;
		}
	}
}
