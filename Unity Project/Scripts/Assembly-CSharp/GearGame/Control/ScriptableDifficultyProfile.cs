using System;
using UnityEngine;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Gameplay/Difficulty Profile")]
	public class ScriptableDifficultyProfile : ScriptableObject
	{
		[Serializable]
		private class TupleWrapper
		{
			[field: SerializeField]
			public float Proportion { get; private set; }

			[field: SerializeField]
			public int LevelAdder { get; private set; }
		}

		[Serializable]
		public class WeightedTypeWrapper
		{
			[field: SerializeField]
			public float Weight { get; private set; }

			[field: SerializeField]
			public ScriptableTroop.TroopCategory Category { get; private set; }
		}

		[Serializable]
		public class WeightedTypeGroup
		{
			[field: SerializeField]
			public WeightedTypeWrapper[] Wrappers { get; private set; }

			[field: SerializeField]
			public float ElitePercent01 { get; private set; }
		}

		[SerializeField]
		private AnimationCurve difficultyCurve;

		[SerializeField]
		private TupleWrapper[] allLevelAddersProportion;

		[SerializeField]
		private AnimationCurve delayPerTroopCurve;

		[SerializeField]
		private AnimationCurve troopNumberCurve;

		[SerializeField]
		private AnimationCurve baseDelayCurve;

		[SerializeField]
		private WeightedTypeGroup[] weightTypeWrappers;

		public AnimationCurve DelayPerTroopCurve => null;

		public AnimationCurve TroopNumberCurve => null;

		public AnimationCurve BaseDelayCurve => null;

		public WeightedTypeGroup[] WeightTypeWrappers => null;

		public float GetRawEvaluation(float percent01)
		{
			return 0f;
		}

		public int[] ReturnAdjustedLevel(int numberEnemies, float percent01, System.Random rng)
		{
			return null;
		}
	}
}
