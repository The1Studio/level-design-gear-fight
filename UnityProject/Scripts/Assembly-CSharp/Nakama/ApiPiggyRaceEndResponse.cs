using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPiggyRaceEndResponse
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "data")]
		[Preserve]
		public ApiPiggyRaceData Data { get; set; }

		[DataMember(Name = "status")]
		[Preserve]
		public ApiRequestStatus Status { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
