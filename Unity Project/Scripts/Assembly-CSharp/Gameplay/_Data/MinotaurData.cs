using System;
using GearGame.Control;
using UnityEngine;

namespace Gameplay._Data
{
	[Serializable]
	public class MinotaurData : TroopData
	{
		[field: SerializeField]
		public override float AttackRange { get; }

		[field: SerializeField]
		public override float DelayBetweenAttacks { get; }

		[field: SerializeField]
		public override float Knockback { get; }

		[field: SerializeField]
		public override float CritChance { get; }

		[field: SerializeField]
		public override float MeleeCleaveRange { get; }

		[field: SerializeField]
		public override float MovementSpeedMultiplier { get; }

		[field: SerializeField]
		public override int MaxNumberOfEnemiesHitInMeleeCleave { get; }

		[field: SerializeField]
		public override int DamageWhenReachingOtherSide { get; }

		[field: SerializeField]
		public override float DamageMultiplier { get; }

		[field: SerializeField]
		public override float HealthMultiplier { get; }

		[field: SerializeField]
		public float KnockbackOnCharge { get; }

		[field: SerializeField]
		public override bool OnlySpawnWhenEnemiesExist { get; }

		[field: SerializeField]
		public override bool OnlySpawnWhenAlliesExist { get; }

		[field: SerializeField]
		public override int LimitLock { get; }

		[field: SerializeField]
		public override ScriptableGear.SpawningTier RegularSpawnTier { get; }

		[field: SerializeField]
		public override ScriptableGear.SpawningTier PremiumSpawnTier { get; }

		[field: SerializeField]
		public override ScriptableGear.SpawningType SpawnType { get; }

		[field: SerializeField]
		public override int Cost { get; }

		[field: SerializeField]
		public override float ProductionAddition { get; }

		[field: SerializeField]
		public override float ProductionRequirement { get; }

		[field: SerializeField]
		public override float Cooldown { get; }
	}
}
