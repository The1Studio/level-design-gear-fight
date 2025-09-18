using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiLeaderboardPlayerDataRecord
	{
		[DataMember(Name = "create_time")]
		[Preserve]
		public string CreateTime { get; set; }

		[Preserve]
		[DataMember(Name = "leaderboard_id")]
		public string LeaderboardId { get; set; }

		[DataMember(Name = "player_data")]
		[Preserve]
		public ApiPlayerData PlayerData { get; set; }

		[Preserve]
		[DataMember(Name = "update_time")]
		public string UpdateTime { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
