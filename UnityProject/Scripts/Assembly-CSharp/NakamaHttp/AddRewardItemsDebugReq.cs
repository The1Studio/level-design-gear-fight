using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AddRewardItemsDebugReq
	{
		[Preserve]
		[DataMember(Name = "reward_items")]
		public List<RewardItem> RewardItems;

		public AddRewardItemsDebugReq()
		{
		}

		public AddRewardItemsDebugReq(List<RewardItem> rewardItemsParam)
		{
		}
	}
}
