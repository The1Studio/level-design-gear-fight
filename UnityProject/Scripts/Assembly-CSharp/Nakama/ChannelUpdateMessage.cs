using System.Runtime.Serialization;

namespace Nakama
{
	public class ChannelUpdateMessage
	{
		[DataMember(Name = "channel_id")]
		[Preserve]
		public string ChannelId { get; set; }

		[Preserve]
		[DataMember(Name = "message_id")]
		public string MessageId { get; set; }

		[DataMember(Name = "content")]
		[Preserve]
		public string Content { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
