using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduledRaceScheduleRoundRequest
	{
		[DataMember(Name = "configuration")]
		[Preserve]
		public ApiScheduledRaceScheduleRoundConfiguration Configuration { get; set; }

		[DataMember(Name = "round")]
		[Preserve]
		public ApiScheduleRoundCommonData Round { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
