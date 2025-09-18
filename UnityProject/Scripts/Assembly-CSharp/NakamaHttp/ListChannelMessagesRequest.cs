using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ListChannelMessagesRequest
	{
		[Preserve]
		[DataMember(Name = "channel_id")]
		public string ChannelId;

		[DataMember(Name = "limit")]
		[Preserve]
		public int? Limit;

		[DataMember(Name = "forward")]
		[Preserve]
		public bool? Forward;

		[DataMember(Name = "cursor")]
		[Preserve]
		public string Cursor;

		public ListChannelMessagesRequest()
		{
		}

		public ListChannelMessagesRequest(string channelIdParam, int? limitParam, bool? forwardParam, string cursorParam)
		{
		}
	}
}
