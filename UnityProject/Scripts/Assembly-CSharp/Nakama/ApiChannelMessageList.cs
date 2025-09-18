using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiChannelMessageList
	{
		[DataMember(Name = "cacheable_cursor")]
		[Preserve]
		public string CacheableCursor { get; set; }

		[DataMember(Name = "messages")]
		[Preserve]
		public List<ApiChannelMessage> Messages { get; set; }

		[DataMember(Name = "next_cursor")]
		[Preserve]
		public string NextCursor { get; set; }

		[Preserve]
		[DataMember(Name = "prev_cursor")]
		public string PrevCursor { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
