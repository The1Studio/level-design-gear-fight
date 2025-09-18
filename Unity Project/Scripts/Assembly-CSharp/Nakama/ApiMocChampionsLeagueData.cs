using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocChampionsLeagueData
	{
		[DataMember(Name = "ahead_players")]
		[Preserve]
		public List<ApiPlayerData> AheadPlayers { get; set; }

		[Preserve]
		[DataMember(Name = "behind_players")]
		public List<ApiPlayerData> BehindPlayers { get; set; }

		[Preserve]
		[DataMember(Name = "league_id")]
		public int LeagueId { get; set; }

		[DataMember(Name = "player_data")]
		[Preserve]
		public ApiPlayerData PlayerData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
