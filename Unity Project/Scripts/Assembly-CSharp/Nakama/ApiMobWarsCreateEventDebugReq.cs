using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsCreateEventDebugReq
	{
		[DataMember(Name = "anticipation_start_unix_secs")]
		[Preserve]
		public int AnticipationStartUnixSecs { get; set; }

		[DataMember(Name = "bots_per_team")]
		[Preserve]
		public int BotsPerTeam { get; set; }

		[Preserve]
		[DataMember(Name = "event_end_unix_secs")]
		public int EventEndUnixSecs { get; set; }

		[Preserve]
		[DataMember(Name = "event_start_unix_secs")]
		public int EventStartUnixSecs { get; set; }

		[Preserve]
		[DataMember(Name = "event_week")]
		public int EventWeek { get; set; }

		[DataMember(Name = "point_config")]
		[Preserve]
		public ApiMobWarsPointConfig PointConfig { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
