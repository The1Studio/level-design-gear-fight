using System.Runtime.Serialization;

namespace Nakama
{
	public class ChannelSendMessage
	{
		[DataMember(Name = "channel_id")]
		[Preserve]
		public string ChannelId { get; set; }

		[DataMember(Name = "content")]
		[Preserve]
		public string Content { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
