using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class LeaderboardList
	{
		[Preserve]
		[DataMember(Name = "leaderboards")]
		public List<Leaderboard> Leaderboards;

		[DataMember(Name = "cursor")]
		[Preserve]
		public string Cursor;

		public LeaderboardList()
		{
		}

		public LeaderboardList(List<Leaderboard> leaderboardsParam, string cursorParam)
		{
		}
	}
}
