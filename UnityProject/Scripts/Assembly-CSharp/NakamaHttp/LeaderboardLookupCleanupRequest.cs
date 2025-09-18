using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class LeaderboardLookupCleanupRequest
	{
		[DataMember(Name = "leaderboard_id")]
		[Preserve]
		public string LeaderboardId;

		[Preserve]
		[DataMember(Name = "time_unix")]
		public int TimeUnix;

		[Preserve]
		[DataMember(Name = "limit")]
		public int Limit;

		public LeaderboardLookupCleanupRequest()
		{
		}

		public LeaderboardLookupCleanupRequest(string leaderboardIdParam, int timeUnixParam, int limitParam)
		{
		}
	}
}
