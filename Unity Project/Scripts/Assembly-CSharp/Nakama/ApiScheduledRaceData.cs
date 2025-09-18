using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduledRaceData
	{
		[Preserve]
		[DataMember(Name = "league_id")]
		public string LeagueId { get; set; }

		[DataMember(Name = "ordered_players")]
		[Preserve]
		public List<ApiPlayerData> OrderedPlayers { get; set; }

		[Preserve]
		[DataMember(Name = "player_progress")]
		public ApiScheduledRacePlayerProgress PlayerProgress { get; set; }

		[DataMember(Name = "race_id")]
		[Preserve]
		public int RaceId { get; set; }

		[DataMember(Name = "race_type")]
		[Preserve]
		public ApiScheduledRaceType RaceType { get; set; }

		[DataMember(Name = "real_players_count")]
		[Preserve]
		public int RealPlayersCount { get; set; }

		[DataMember(Name = "rewards")]
		[Preserve]
		public ApiScheduledRaceRewards Rewards { get; set; }

		[DataMember(Name = "seconds_until_end")]
		[Preserve]
		public int SecondsUntilEnd { get; set; }

		[DataMember(Name = "seconds_until_fill_with_bots")]
		[Preserve]
		public int SecondsUntilFillWithBots { get; set; }

		[Preserve]
		[DataMember(Name = "seconds_until_start")]
		public int SecondsUntilStart { get; set; }

		[DataMember(Name = "status")]
		[Preserve]
		public ScheduledRaceDataScheduledRaceStatus Status { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
