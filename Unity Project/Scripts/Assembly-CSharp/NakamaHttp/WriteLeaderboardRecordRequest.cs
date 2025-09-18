using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class WriteLeaderboardRecordRequest
	{
		[Preserve]
		[DataMember(Name = "leaderboard_id")]
		public string LeaderboardId;

		[Preserve]
		[DataMember(Name = "score")]
		public int Score;

		public WriteLeaderboardRecordRequest()
		{
		}

		public WriteLeaderboardRecordRequest(string leaderboardIdParam, int scoreParam)
		{
		}
	}
}
