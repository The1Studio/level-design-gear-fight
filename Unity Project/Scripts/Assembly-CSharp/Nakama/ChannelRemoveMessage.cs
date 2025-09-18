using System.Runtime.Serialization;

namespace Nakama
{
	public class ChannelRemoveMessage
	{
		[Preserve]
		[DataMember(Name = "channel_id")]
		public string ChannelId { get; set; }

		[DataMember(Name = "message_id")]
		[Preserve]
		public string MessageId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
