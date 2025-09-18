using System;
using UnityEngine;
using VInspector;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Gameplay/Power Profile")]
	public class ScriptablePowerProfile : ScriptableObject
	{
		[Serializable]
		public class PowerScaler
		{
			[field: SerializeField]
			public float DamageMultiplier { get; private set; }

			[field: SerializeField]
			public float HealthMultiplier { get; private set; }

			public PowerScaler(float damageMultiplier, float healthMultiplier)
			{
			}
		}

		public SerializedDictionary<GearUpgradeUnlockProfile.Tier, PowerScaler> AllPowerScalers;

		private void OnValidate()
		{
		}
	}
}
