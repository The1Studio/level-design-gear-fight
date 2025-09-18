using System;
using GearGame.Control;
using GearGame.Gameplay;
using UnityEngine;

namespace Gameplay._Data
{
	[Serializable]
	public class SharpenedStickData : GearSpawnerData, IDamageSpellDataProvider
	{
		public double Damage => 0.0;

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
		public double DamageMultiplier { get; }

		[field: SerializeField]
		public float CritChance { get; }

		[field: SerializeField]
		public float CritMultiplier { get; }
	}
}
