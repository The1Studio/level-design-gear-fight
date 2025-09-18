using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ListLeaderboardRecordsRequest
	{
		[DataMember(Name = "owner_ids")]
		[Preserve]
		public List<string> OwnerIds;

		[DataMember(Name = "leaderboard_id")]
		[Preserve]
		public string LeaderboardId;

		[Preserve]
		[DataMember(Name = "sort_order")]
		public string SortOrder;

		[Preserve]
		[DataMember(Name = "limit")]
		public int Limit;

		[Preserve]
		[DataMember(Name = "offset")]
		public int Offset;

		public ListLeaderboardRecordsRequest()
		{
		}

		public ListLeaderboardRecordsRequest(List<string> ownerIdsParam, string leaderboardIdParam, string sortOrderParam, int limitParam, int offsetParam)
		{
		}
	}
}
