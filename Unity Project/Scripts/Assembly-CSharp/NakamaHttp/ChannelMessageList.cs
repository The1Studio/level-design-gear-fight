using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ChannelMessageList
	{
		[DataMember(Name = "messages")]
		[Preserve]
		public List<ChannelMessage> Messages;

		[Preserve]
		[DataMember(Name = "next_cursor")]
		public string NextCursor;

		[DataMember(Name = "prev_cursor")]
		[Preserve]
		public string PrevCursor;

		[Preserve]
		[DataMember(Name = "cacheable_cursor")]
		public string CacheableCursor;

		public ChannelMessageList()
		{
		}

		public ChannelMessageList(List<ChannelMessage> messagesParam, string nextCursorParam, string prevCursorParam, string cacheableCursorParam)
		{
		}
	}
}
