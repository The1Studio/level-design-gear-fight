using UnityEngine;

namespace GearGame.Gameplay.UI
{
	public class MiniBossRewardButton : MonoBehaviour
	{
		public Animator Animator { get; private set; }

		public ScriptableMiniBossRewardsData.Reward Reward { get; set; }

		private void Awake()
		{
		}

		public void GiveReward()
		{
		}
	}
}
