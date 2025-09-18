using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChestClaimResp
	{
		[DataMember(Name = "claimed_targets")]
		[Preserve]
		public List<int> ClaimedTargets { get; set; }

		[DataMember(Name = "guild_chest_data")]
		[Preserve]
		public ApiGuildChestData GuildChestData { get; set; }

		[DataMember(Name = "request_status")]
		[Preserve]
		public ApiRequestStatus RequestStatus { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
