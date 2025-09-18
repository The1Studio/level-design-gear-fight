using System;
using GearGame.Control;
using UnityEngine;

namespace Gameplay._Data
{
	[Serializable]
	public class BrainData : BuffData
	{
		[field: SerializeField]
		public override string AttachmentType { get; }

		[field: SerializeField]
		public override float Probability { get; }

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
		public float ProductionMultiplier { get; }

		[field: SerializeField]
		public float DamageMultiplier { get; }
	}
}
