using System.Runtime.Serialization;

namespace Nakama
{
	public class ChannelLeaveMessage
	{
		[DataMember(Name = "channel_id")]
		[Preserve]
		public string ChannelId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
