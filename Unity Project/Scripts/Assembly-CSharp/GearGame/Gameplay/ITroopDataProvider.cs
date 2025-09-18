namespace GearGame.Gameplay
{
	public interface ITroopDataProvider
	{
		float AttackRange { get; }

		float DelayBetweenAttacks { get; }

		float Knockback { get; }

		float CritChance { get; }

		float MeleeCleaveRange { get; }

		float MovementSpeedMultiplier { get; }

		int MaxNumberOfEnemiesHitInMeleeCleave { get; }

		int DamageWhenReachingOtherSide { get; }

		double GetDamage(int level);

		double GetHealth(int level);

		static double GetDummyDamage(int level, float dummyMultiplier)
		{
			return 0.0;
		}

		static double GetDummyHealth(int level, float dummyMultiplier)
		{
			return 0.0;
		}

		static double GetDummyDamageSpecialTroop(float dummyMultiplier)
		{
			return 0.0;
		}

		static double GetDummyHealthSpecialTroop(float dummyMultiplier)
		{
			return 0.0;
		}
	}
}
