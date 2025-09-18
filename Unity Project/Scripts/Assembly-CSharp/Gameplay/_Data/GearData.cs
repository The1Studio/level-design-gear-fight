using System;
using GearGame.Control;

namespace Gameplay._Data
{
	[Serializable]
	public abstract class GearData
	{
		public abstract float ProductionAddition { get; }

		public abstract int Cost { get; }

		public abstract ScriptableGear.SpawningTier RegularSpawnTier { get; }

		public abstract ScriptableGear.SpawningTier PremiumSpawnTier { get; }

		public abstract ScriptableGear.SpawningType SpawnType { get; }
	}
}
