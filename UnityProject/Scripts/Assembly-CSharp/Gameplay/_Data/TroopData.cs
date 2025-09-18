using System;
using GearGame.Gameplay;

namespace Gameplay._Data
{
	[Serializable]
	public abstract class TroopData : GearSpawnerData, ITroopDataProvider
	{
		public abstract float AttackRange { get; }

		public abstract float DelayBetweenAttacks { get; }

		public abstract float Knockback { get; }

		public abstract float CritChance { get; }

		public abstract float MeleeCleaveRange { get; }

		public abstract float DamageMultiplier { get; }

		public abstract float HealthMultiplier { get; }

		public abstract float MovementSpeedMultiplier { get; }

		public abstract int MaxNumberOfEnemiesHitInMeleeCleave { get; }

		public abstract int DamageWhenReachingOtherSide { get; }

		public double GetDamage(int level)
		{
			return 0.0;
		}

		public double GetHealth(int level)
		{
			return 0.0;
		}
	}
}
