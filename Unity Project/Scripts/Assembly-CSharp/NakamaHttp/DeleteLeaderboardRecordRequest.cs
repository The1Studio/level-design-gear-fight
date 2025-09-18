using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class DeleteLeaderboardRecordRequest
	{
		[DataMember(Name = "leaderboard_id")]
		[Preserve]
		public string LeaderboardId;

		public DeleteLeaderboardRecordRequest()
		{
		}

		public DeleteLeaderboardRecordRequest(string leaderboardIdParam)
		{
		}
	}
}
