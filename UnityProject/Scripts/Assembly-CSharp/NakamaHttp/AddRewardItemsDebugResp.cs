using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AddRewardItemsDebugResp
	{
		[Preserve]
		[DataMember(Name = "reward_items")]
		public List<RewardItem> RewardItems;

		public AddRewardItemsDebugResp()
		{
		}

		public AddRewardItemsDebugResp(List<RewardItem> rewardItemsParam)
		{
		}
	}
}
