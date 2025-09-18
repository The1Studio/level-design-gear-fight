using System;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class MiniBossSave : ServerBaseData
	{
		public int MiniBossSeed;

		public int MiniBossRewardBundleOn;

		public int MiniBossRewardForcedBundleOn;

		public int MiniBossRewardBundleSeed;
	}
}
