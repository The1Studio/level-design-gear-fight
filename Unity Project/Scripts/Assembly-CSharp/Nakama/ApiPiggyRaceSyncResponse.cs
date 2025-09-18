using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPiggyRaceSyncResponse
	{
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
