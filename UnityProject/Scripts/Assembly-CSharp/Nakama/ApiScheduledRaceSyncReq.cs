using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduledRaceSyncReq
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

		[Preserve]
		[DataMember(Name = "join")]
		public bool Join { get; set; }

		[DataMember(Name = "league_id")]
		[Preserve]
		public string LeagueId { get; set; }

		[DataMember(Name = "points")]
		[Preserve]
		public int Points { get; set; }

		[DataMember(Name = "race_id")]
		[Preserve]
		public int RaceId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
