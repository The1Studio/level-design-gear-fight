using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearPepperController : GearSpellSpawnerController
	{
		[SerializeField]
		private GameObject pepperGroundPrefab;

		public override GearSpawnerData SpawnerData => null;

		protected override GameObject InstantiateSpawnObject()
		{
			return null;
		}
	}
}
