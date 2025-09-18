using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiChampionsLeagueRequestData
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[Preserve]
		[DataMember(Name = "max_ahead_scores")]
		public int MaxAheadScores { get; set; }

		[DataMember(Name = "max_behind_scores")]
		[Preserve]
		public int MaxBehindScores { get; set; }

		[DataMember(Name = "max_top_scores")]
		[Preserve]
		public int MaxTopScores { get; set; }

		[Preserve]
		[DataMember(Name = "player_score")]
		public int PlayerScore { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
