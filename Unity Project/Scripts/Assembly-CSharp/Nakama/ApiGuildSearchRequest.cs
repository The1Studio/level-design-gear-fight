using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildSearchRequest
	{
		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[Preserve]
		[DataMember(Name = "current_points")]
		public int CurrentPoints { get; set; }

		[DataMember(Name = "exclude_closed")]
		[Preserve]
		public bool ExcludeClosed { get; set; }

		[Preserve]
		[DataMember(Name = "filter")]
		public string Filter { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
