using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiRewardItems
	{
		[Preserve]
		[DataMember(Name = "reward_to_count")]
		public Dictionary<string, int> RewardToCount { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
