using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class LeaderboardCleanupRequest
	{
		[Preserve]
		[DataMember(Name = "leaderboard_id")]
		public string LeaderboardId;

		[Preserve]
		[DataMember(Name = "time_unix")]
		public int TimeUnix;

		[DataMember(Name = "limit")]
		[Preserve]
		public int Limit;

		[Preserve]
		[DataMember(Name = "confirm")]
		public bool Confirm;

		[DataMember(Name = "password")]
		[Preserve]
		public string Password;

		public LeaderboardCleanupRequest()
		{
		}

		public LeaderboardCleanupRequest(string leaderboardIdParam, int timeUnixParam, int limitParam, bool confirmParam, string passwordParam)
		{
		}
	}
}
