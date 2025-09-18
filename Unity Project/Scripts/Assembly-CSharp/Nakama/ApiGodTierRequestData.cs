using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierRequestData
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[Preserve]
		[DataMember(Name = "max_participant_ahead_scores")]
		public int MaxParticipantAheadScores { get; set; }

		[Preserve]
		[DataMember(Name = "max_participant_behind_scores")]
		public int MaxParticipantBehindScores { get; set; }

		[DataMember(Name = "max_participant_top_scores")]
		[Preserve]
		public int MaxParticipantTopScores { get; set; }

		[DataMember(Name = "max_spectator_top_scores")]
		[Preserve]
		public int MaxSpectatorTopScores { get; set; }

		[DataMember(Name = "player_score")]
		[Preserve]
		public int PlayerScore { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
