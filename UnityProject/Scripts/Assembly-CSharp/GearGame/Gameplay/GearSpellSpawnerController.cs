using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class GearSpellSpawnerController : GearSpawnerController
	{
		protected override float MaxProduction => 0f;

		public override bool CanBeFrozen => false;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		protected override void Start()
		{
		}

		private void Purchased(GearController obj)
		{
		}

		protected override void ObjectSpawned(GameObject go)
		{
		}
	}
}
