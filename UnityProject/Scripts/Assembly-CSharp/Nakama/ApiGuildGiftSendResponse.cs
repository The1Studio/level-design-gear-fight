using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGiftSendResponse
	{
		[Preserve]
		[DataMember(Name = "guild_gift_data")]
		public ApiGuildGiftData GuildGiftData { get; set; }

		[Preserve]
		[DataMember(Name = "result")]
		public GuildGiftSendResponseGuildGiftSendResult Result { get; set; }

		[DataMember(Name = "rewards")]
		[Preserve]
		public Dictionary<string, long> Rewards { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
