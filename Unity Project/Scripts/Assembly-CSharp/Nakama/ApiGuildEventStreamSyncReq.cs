using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildEventStreamSyncReq
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "data")]
		[Preserve]
		public ApiGuildEventStreamRequestData Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
