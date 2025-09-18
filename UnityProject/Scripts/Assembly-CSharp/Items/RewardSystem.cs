using System.Collections.Generic;

namespace Items
{
	public class RewardSystem : ItemSystem<RewardSO>
	{
		private List<BaseDrop> GetDropsFromRewardSO(RewardSO rewardSO)
		{
			return null;
		}

		public override IEnumerable<Reward> Claim(ItemSO item, double amount, RaritySO rarity)
		{
			return null;
		}

		protected override void Initialize(RewardSO[] settings)
		{
		}

		public override void Save(IEnumerable<Reward> rewards)
		{
		}

		public override IEnumerable<Reward> GetRewards()
		{
			return null;
		}

		public override void ClearRewards()
		{
		}

		public override void OnDataReloaded()
		{
		}
	}
}
