using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiWriteLeaderboardRecordRequest
	{
		[Preserve]
		[DataMember(Name = "leaderboard_id")]
		public string LeaderboardId { get; set; }

		[Preserve]
		[DataMember(Name = "score")]
		public int Score { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
