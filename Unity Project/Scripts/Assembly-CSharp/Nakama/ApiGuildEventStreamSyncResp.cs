using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildEventStreamSyncResp
	{
		[DataMember(Name = "ordered_guild_events")]
		[Preserve]
		public List<ApiGuildEvent> OrderedGuildEvents { get; set; }

		[Preserve]
		[DataMember(Name = "result")]
		public ApiEventStreamStatus Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
