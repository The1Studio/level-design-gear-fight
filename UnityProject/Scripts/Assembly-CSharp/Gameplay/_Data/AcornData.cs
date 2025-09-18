using System;
using GearGame.Control;
using GearGame.Gameplay;
using UnityEngine;

namespace Gameplay._Data
{
	[Serializable]
	public class AcornData : BuffData, IDamageSpellDataProvider
	{
		[field: SerializeField]
		public override string AttachmentType { get; }

		[field: SerializeField]
		public override float Probability { get; }

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

		public double Damage => 0.0;

		[field: SerializeField]
		public float CritChance { get; }

		[field: SerializeField]
		public float CritMultiplier { get; }
	}
}
