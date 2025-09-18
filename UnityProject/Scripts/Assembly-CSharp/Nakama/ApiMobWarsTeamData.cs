using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsTeamData
	{
		[DataMember(Name = "top_contributors")]
		[Preserve]
		public List<ApiPlayerData> TopContributors { get; set; }

		[DataMember(Name = "total_players")]
		[Preserve]
		public int TotalPlayers { get; set; }

		[DataMember(Name = "total_points")]
		[Preserve]
		public long TotalPoints { get; set; }

		[DataMember(Name = "total_wins")]
		[Preserve]
		public int TotalWins { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
