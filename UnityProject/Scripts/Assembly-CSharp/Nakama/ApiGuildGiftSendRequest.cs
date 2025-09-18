using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGiftSendRequest
	{
		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[Preserve]
		[DataMember(Name = "request_id")]
		public string RequestId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
