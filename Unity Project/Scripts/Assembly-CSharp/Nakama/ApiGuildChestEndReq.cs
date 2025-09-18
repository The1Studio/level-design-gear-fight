using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChestEndReq
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "event_id")]
		[Preserve]
		public int EventId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
