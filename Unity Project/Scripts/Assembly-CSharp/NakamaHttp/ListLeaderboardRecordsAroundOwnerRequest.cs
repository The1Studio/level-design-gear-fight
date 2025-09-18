using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ListLeaderboardRecordsAroundOwnerRequest
	{
		[Preserve]
		[DataMember(Name = "leaderboard_id")]
		public string LeaderboardId;

		[Preserve]
		[DataMember(Name = "limit")]
		public int? Limit;

		[Preserve]
		[DataMember(Name = "owner_id")]
		public string OwnerId;

		public ListLeaderboardRecordsAroundOwnerRequest()
		{
		}

		public ListLeaderboardRecordsAroundOwnerRequest(string leaderboardIdParam, int? limitParam, string ownerIdParam)
		{
		}
	}
}
