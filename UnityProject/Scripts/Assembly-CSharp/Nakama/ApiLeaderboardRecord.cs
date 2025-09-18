using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiLeaderboardRecord
	{
		[DataMember(Name = "leaderboard_id")]
		[Preserve]
		public string LeaderboardId { get; set; }

		[Preserve]
		[DataMember(Name = "owner_id")]
		public string OwnerId { get; set; }

		[DataMember(Name = "rank")]
		[Preserve]
		public int Rank { get; set; }

		[DataMember(Name = "score")]
		[Preserve]
		public int Score { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
