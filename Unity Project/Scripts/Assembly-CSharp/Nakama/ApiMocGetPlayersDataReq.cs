using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocGetPlayersDataReq
	{
		[DataMember(Name = "champions_league_max_ahead_scores")]
		[Preserve]
		public int ChampionsLeagueMaxAheadScores { get; set; }

		[DataMember(Name = "champions_league_max_behind_scores")]
		[Preserve]
		public int ChampionsLeagueMaxBehindScores { get; set; }

		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[Preserve]
		[DataMember(Name = "user_ids")]
		public List<string> UserIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
