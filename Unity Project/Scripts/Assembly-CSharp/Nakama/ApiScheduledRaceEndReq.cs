using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduledRaceEndReq
	{
		[DataMember(Name = "config")]
		[Preserve]
		public ApiScheduledRaceConfiguration Config { get; set; }

		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[DataMember(Name = "current_level")]
		[Preserve]
		public int CurrentLevel { get; set; }

		[DataMember(Name = "next_league_id")]
		[Preserve]
		public string NextLeagueId { get; set; }

		[DataMember(Name = "race_id")]
		[Preserve]
		public int RaceId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
