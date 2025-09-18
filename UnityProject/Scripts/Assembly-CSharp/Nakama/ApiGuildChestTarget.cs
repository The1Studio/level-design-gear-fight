using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChestTarget
	{
		[DataMember(Name = "reward_items")]
		[Preserve]
		public ApiRewardItems RewardItems { get; set; }

		[DataMember(Name = "status")]
		[Preserve]
		public ApiGuildChestTargetStatus Status { get; set; }

		[Preserve]
		[DataMember(Name = "target")]
		public int Target { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
