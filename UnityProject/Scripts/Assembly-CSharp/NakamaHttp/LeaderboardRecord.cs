using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class LeaderboardRecord
	{
		[Preserve]
		[DataMember(Name = "leaderboard_id")]
		public string LeaderboardId;

		[Preserve]
		[DataMember(Name = "owner_id")]
		public string OwnerId;

		[DataMember(Name = "score")]
		[Preserve]
		public int Score;

		[Preserve]
		[DataMember(Name = "rank")]
		public int Rank;

		public LeaderboardRecord()
		{
		}

		public LeaderboardRecord(string leaderboardIdParam, string ownerIdParam, int scoreParam, int rankParam)
		{
		}
	}
}
