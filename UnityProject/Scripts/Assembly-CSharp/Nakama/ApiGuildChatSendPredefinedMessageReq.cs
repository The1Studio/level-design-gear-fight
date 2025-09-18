using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChatSendPredefinedMessageReq
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "data")]
		[Preserve]
		public ApiGuildEventStreamRequestData Data { get; set; }

		[DataMember(Name = "message_id")]
		[Preserve]
		public int MessageId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
