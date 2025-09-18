using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class LeaderboardPlayerDataRecord
	{
		[Preserve]
		[DataMember(Name = "player_data")]
		public PlayerData PlayerData;

		[Preserve]
		[DataMember(Name = "leaderboard_id")]
		public string LeaderboardId;

		public LeaderboardPlayerDataRecord()
		{
		}

		public LeaderboardPlayerDataRecord(PlayerData playerDataParam, string leaderboardIdParam)
		{
		}
	}
}
