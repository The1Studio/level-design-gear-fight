using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearHaunchOfMeatController : GearSpellSpawnerController
	{
		[SerializeField]
		private GameObject haunchOfMeatGroundPrefab;

		public override GearSpawnerData SpawnerData => null;

		protected override GameObject InstantiateSpawnObject()
		{
			return null;
		}
	}
}
