using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGiftClaimResponse
	{
		[DataMember(Name = "claimed_gift_ids")]
		[Preserve]
		public List<string> ClaimedGiftIds { get; set; }

		[Preserve]
		[DataMember(Name = "guild_gift_data")]
		public ApiGuildGiftData GuildGiftData { get; set; }

		[Preserve]
		[DataMember(Name = "result")]
		public GuildGiftClaimResponseGuildGiftClaimResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
