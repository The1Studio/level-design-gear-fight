using System.Collections.Generic;
using GearGame.Control;

namespace Items
{
	public class GearSystem : ItemSystem<ScriptableGear>
	{
		private static GearSystem _instance;

		private Dictionary<ItemNames, Gear> _gearInstances;

		public ScriptableGear[] Gears { get; private set; }

		public override IEnumerable<Reward> Claim(ItemSO item, double amount, RaritySO rarity)
		{
			return null;
		}

		public override void ClearRewards()
		{
		}

		public override IEnumerable<Reward> GetRewards()
		{
			return null;
		}

		public override void Save(IEnumerable<Reward> rewards)
		{
		}

		protected override void Initialize(ScriptableGear[] settings)
		{
		}

		public override void OnDataReloaded()
		{
		}

		public static ScriptableGear[] GetGears()
		{
			return null;
		}
	}
}
