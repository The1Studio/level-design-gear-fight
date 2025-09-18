using System;
using UnityEngine;

namespace GearGame.Control
{
	public class ScriptableFightConfiguration : ScriptableObject
	{
		[Serializable]
		public class TroopTiming
		{
			[field: SerializeField]
			public ScriptableTroop.TroopCategory TroopLayout { get; set; }

			[field: SerializeField]
			public float BeastModePercent01 { get; set; }
		}

		[ReadOnly]
		[SerializeField]
		private int lastCheckedValue;

		[field: SerializeField]
		public int AssociatedFightIndex { get; private set; }

		[field: SerializeField]
		public TroopTiming[] TroopLayout { get; private set; }

		private void OnValidate()
		{
		}
	}
}
