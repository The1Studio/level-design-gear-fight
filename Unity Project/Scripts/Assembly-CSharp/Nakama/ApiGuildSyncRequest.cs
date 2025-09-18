using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildSyncRequest
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[Preserve]
		[DataMember(Name = "points")]
		public int Points { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
