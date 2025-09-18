using System;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class ChapterSave : ServerBaseData
	{
		public int ChapterRewardsPending;

		public int ChapterRewardsClaimed;

		public int ChapterRewardsChestsClaimed;

		public void OnRewardsClaimed()
		{
		}
	}
}
