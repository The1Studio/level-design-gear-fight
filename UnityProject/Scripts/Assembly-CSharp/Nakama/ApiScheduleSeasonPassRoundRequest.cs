using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduleSeasonPassRoundRequest
	{
		[Preserve]
		[DataMember(Name = "feature")]
		public ApiSeasonPassData Feature { get; set; }

		[Preserve]
		[DataMember(Name = "round")]
		public ApiScheduleRoundCommonData Round { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
