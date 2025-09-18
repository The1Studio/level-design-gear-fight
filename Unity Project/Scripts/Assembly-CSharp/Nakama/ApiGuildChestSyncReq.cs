using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChestSyncReq
	{
		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[Preserve]
		[DataMember(Name = "event_id")]
		public int EventId { get; set; }

		[DataMember(Name = "points")]
		[Preserve]
		public int Points { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
