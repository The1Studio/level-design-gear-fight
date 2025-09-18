using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChatSendPredefinedMessageResp
	{
		[DataMember(Name = "ordered_guild_events")]
		[Preserve]
		public List<ApiGuildEvent> OrderedGuildEvents { get; set; }

		[DataMember(Name = "result")]
		[Preserve]
		public ApiEventStreamStatus Result { get; set; }

		[Preserve]
		[DataMember(Name = "seconds_until_next_message")]
		public long SecondsUntilNextMessage { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
