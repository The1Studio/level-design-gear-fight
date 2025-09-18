using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsPlayerData
	{
		[DataMember(Name = "player_data")]
		[Preserve]
		public ApiPlayerData PlayerData { get; set; }

		[DataMember(Name = "player_team")]
		[Preserve]
		public ApiMobWarsPlayerTeam PlayerTeam { get; set; }

		[Preserve]
		[DataMember(Name = "total_wins")]
		public int TotalWins { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
