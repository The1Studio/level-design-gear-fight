using System;

namespace Gameplay._Data
{
	[Serializable]
	public abstract class GearSpawnerData : GearData
	{
		public abstract float ProductionRequirement { get; }

		public abstract float Cooldown { get; }

		public abstract bool OnlySpawnWhenEnemiesExist { get; }

		public abstract bool OnlySpawnWhenAlliesExist { get; }

		public abstract int LimitLock { get; }

		public static double GetDamage(int level, float multiplier)
		{
			return 0.0;
		}
	}
}
