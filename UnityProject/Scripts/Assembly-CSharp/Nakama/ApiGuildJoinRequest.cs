using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildJoinRequest
	{
		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[DataMember(Name = "points")]
		[Preserve]
		public int Points { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
