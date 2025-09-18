using System;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class GameParams : ServerBaseData
	{
		public bool DoubleSpeedActive;

		public double TrailingBonusBlueCoins;

		public int NumFails;

		public int SceneOn;

		public int OverScene;

		public int AnalyticsTracking;

		public float Playtime;

		public DateTime FirstOpen;

		public int MiniBossSeed;

		public int StructureChestSeed;

		public int LastClaimedChestLevel;

		public float RunningLevelClock;
	}
}
