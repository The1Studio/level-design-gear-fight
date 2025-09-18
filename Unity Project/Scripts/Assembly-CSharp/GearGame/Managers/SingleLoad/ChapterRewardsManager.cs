using UnityEngine;

namespace GearGame.Managers.SingleLoad
{
	public class ChapterRewardsManager : MonoBehaviour
	{
		public class ChapterReward
		{
			public int NumberChests { get; }

			public int NumberGems { get; }

			public int TotalXP { get; }

			public ChapterReward(int numberChests, int numberGems, int totalXP)
			{
			}
		}

		private static ChapterRewardsManager instance;

		private bool hasInitializedChapterRewards;

		private bool isActive;

		public static ChapterRewardsManager Instance => null;

		protected void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		public ChapterReward GetPendingChapterRewards()
		{
			return null;
		}

		public void OnRewardsPaidOut()
		{
		}

		public void IncrementRewards()
		{
		}

		private void CheckFullInitialization()
		{
		}

		private void ChapterRewardsInitializationFinished(ABTestingChapterRewardsConfig config)
		{
		}
	}
}
