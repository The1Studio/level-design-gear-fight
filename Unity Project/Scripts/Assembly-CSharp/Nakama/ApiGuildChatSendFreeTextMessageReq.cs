using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChatSendFreeTextMessageReq
	{
		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[Preserve]
		[DataMember(Name = "data")]
		public ApiGuildEventStreamRequestData Data { get; set; }

		[Preserve]
		[DataMember(Name = "message")]
		public string Message { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
