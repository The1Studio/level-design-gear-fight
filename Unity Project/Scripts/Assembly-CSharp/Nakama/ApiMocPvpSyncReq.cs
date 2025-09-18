using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpSyncReq
	{
		[Preserve]
		[DataMember(Name = "battle_results")]
		public List<ApiMocPvpBattleResult> BattleResults { get; set; }

		[DataMember(Name = "champions_league_max_ahead_scores")]
		[Preserve]
		public int ChampionsLeagueMaxAheadScores { get; set; }

		[DataMember(Name = "champions_league_max_behind_scores")]
		[Preserve]
		public int ChampionsLeagueMaxBehindScores { get; set; }

		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "player_data")]
		[Preserve]
		public ApiMocPvpPlayerData PlayerData { get; set; }

		[DataMember(Name = "player_score")]
		[Preserve]
		public int PlayerScore { get; set; }

		[DataMember(Name = "received_attack_id_acks")]
		[Preserve]
		public List<string> ReceivedAttackIdAcks { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
