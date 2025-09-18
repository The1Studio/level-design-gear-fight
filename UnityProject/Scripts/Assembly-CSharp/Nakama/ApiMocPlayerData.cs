using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPlayerData
	{
		[Preserve]
		[DataMember(Name = "achievements_data")]
		public ApiMocAchievementsData AchievementsData { get; set; }

		[DataMember(Name = "champions_league_data")]
		[Preserve]
		public ApiMocChampionsLeagueData ChampionsLeagueData { get; set; }

		[DataMember(Name = "cooldown_data")]
		[Preserve]
		public ApiMocPvpCooldownData CooldownData { get; set; }

		[Preserve]
		[DataMember(Name = "player_data")]
		public ApiPlayerData PlayerData { get; set; }

		[DataMember(Name = "pvp_player_data")]
		[Preserve]
		public ApiMocPvpPlayerData PvpPlayerData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
