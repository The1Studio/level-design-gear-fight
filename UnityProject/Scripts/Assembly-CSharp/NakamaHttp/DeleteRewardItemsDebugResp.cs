using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class DeleteRewardItemsDebugResp
	{
		[DataMember(Name = "reward_items")]
		[Preserve]
		public List<RewardItem> RewardItems;

		public DeleteRewardItemsDebugResp()
		{
		}

		public DeleteRewardItemsDebugResp(List<RewardItem> rewardItemsParam)
		{
		}
	}
}
