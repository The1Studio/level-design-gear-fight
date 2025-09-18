using System;
using GearGame.Control;
using UnityEngine;

namespace Gameplay._Data
{
	[Serializable]
	public class HaunchOfMeatData : GearSpawnerData
	{
		[field: SerializeField]
		public override float ProductionRequirement { get; }

		[field: SerializeField]
		public override float Cooldown { get; }

		[field: SerializeField]
		public override bool OnlySpawnWhenEnemiesExist { get; }

		[field: SerializeField]
		public override bool OnlySpawnWhenAlliesExist { get; }

		[field: SerializeField]
		public override int LimitLock { get; }

		[field: SerializeField]
		public override float ProductionAddition { get; }

		[field: SerializeField]
		public override int Cost { get; }

		[field: SerializeField]
		public override ScriptableGear.SpawningTier RegularSpawnTier { get; }

		[field: SerializeField]
		public override ScriptableGear.SpawningTier PremiumSpawnTier { get; }

		[field: SerializeField]
		public override ScriptableGear.SpawningType SpawnType { get; }

		[field: SerializeField]
		public float HealthMultiplier { get; }

		[field: SerializeField]
		public float KnockbackAddition { get; }
	}
}
