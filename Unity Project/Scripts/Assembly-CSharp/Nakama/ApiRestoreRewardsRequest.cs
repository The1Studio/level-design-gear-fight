using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiRestoreRewardsRequest
	{
		[Preserve]
		[DataMember(Name = "rewards")]
		public List<ApiRewardToRestore> Rewards { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
