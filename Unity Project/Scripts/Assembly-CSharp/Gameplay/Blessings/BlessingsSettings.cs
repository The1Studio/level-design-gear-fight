using UnityEngine;

namespace Gameplay.Blessings
{
	[CreateAssetMenu(fileName = "BlessingsSettings", menuName = "Blessings/BlessingsSettings", order = 0)]
	public class BlessingsSettings : ScriptableObject
	{
		public int LevelToUnlock;

		[Space(20f)]
		public int SubLevelsPerLevel;

		public int MaxBoostLevels;

		public int GemsWithIAP;

		public float StartingBoostPercentage;

		public float BoostPercentagePerLevel;

		public float BoostDurationMinutes;
	}
}
