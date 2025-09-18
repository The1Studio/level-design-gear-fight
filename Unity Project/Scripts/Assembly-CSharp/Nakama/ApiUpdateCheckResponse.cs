using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiUpdateCheckResponse
	{
		[Preserve]
		[DataMember(Name = "action")]
		public ApiUpdateCheckAction Action { get; set; }

		[DataMember(Name = "update_url")]
		[Preserve]
		public string UpdateUrl { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
