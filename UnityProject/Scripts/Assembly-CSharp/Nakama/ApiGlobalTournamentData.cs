using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGlobalTournamentData
	{
		[DataMember(Name = "current_player_data")]
		[Preserve]
		public ApiPlayerData CurrentPlayerData { get; set; }

		[DataMember(Name = "players_descending")]
		[Preserve]
		public List<ApiPlayerData> PlayersDescending { get; set; }

		[DataMember(Name = "round_id")]
		[Preserve]
		public string RoundId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
