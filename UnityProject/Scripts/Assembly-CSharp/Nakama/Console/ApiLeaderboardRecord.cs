using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiLeaderboardRecord
	{
		[DataMember(Name = "create_time")]
		[Preserve]
		public string CreateTime { get; set; }

		[DataMember(Name = "leaderboard_id")]
		[Preserve]
		public string LeaderboardId { get; set; }

		[DataMember(Name = "owner_id")]
		[Preserve]
		public string OwnerId { get; set; }

		[Preserve]
		[DataMember(Name = "rank")]
		public long Rank { get; set; }

		[Preserve]
		[DataMember(Name = "score")]
		public long Score { get; set; }

		[DataMember(Name = "update_time")]
		[Preserve]
		public string UpdateTime { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
