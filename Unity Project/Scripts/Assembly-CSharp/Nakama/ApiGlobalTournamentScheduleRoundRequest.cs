using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGlobalTournamentScheduleRoundRequest
	{
		[Preserve]
		[DataMember(Name = "round")]
		public ApiScheduleRoundCommonData Round { get; set; }

		[Preserve]
		[DataMember(Name = "settings")]
		public ApiGlobalTournamentRoundSettings Settings { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
