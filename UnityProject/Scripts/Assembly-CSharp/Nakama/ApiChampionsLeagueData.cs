using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiChampionsLeagueData
	{
		[DataMember(Name = "ahead_players")]
		[Preserve]
		public List<ApiPlayerData> AheadPlayers { get; set; }

		[Preserve]
		[DataMember(Name = "behind_players")]
		public List<ApiPlayerData> BehindPlayers { get; set; }

		[DataMember(Name = "league_data")]
		[Preserve]
		public ApiChampionsLeagueLeagueData LeagueData { get; set; }

		[DataMember(Name = "state")]
		[Preserve]
		public ChampionsLeagueDataChampionsLeagueUserState State { get; set; }

		[DataMember(Name = "top_players")]
		[Preserve]
		public List<ApiPlayerData> TopPlayers { get; set; }

		[Preserve]
		[DataMember(Name = "user_data")]
		public ApiPlayerData UserData { get; set; }

		[DataMember(Name = "users_per_level")]
		[Preserve]
		public List<int> UsersPerLevel { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
