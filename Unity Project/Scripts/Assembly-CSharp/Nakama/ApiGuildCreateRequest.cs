using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildCreateRequest
	{
		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[DataMember(Name = "info")]
		[Preserve]
		public ApiGuildInfo Info { get; set; }

		[Preserve]
		[DataMember(Name = "points")]
		public int Points { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
