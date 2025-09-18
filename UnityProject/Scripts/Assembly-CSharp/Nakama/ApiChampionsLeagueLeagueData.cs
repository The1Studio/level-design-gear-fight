using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiChampionsLeagueLeagueData
	{
		[DataMember(Name = "has_promotion")]
		[Preserve]
		public bool HasPromotion { get; set; }

		[DataMember(Name = "league_id")]
		[Preserve]
		public int LeagueId { get; set; }

		[DataMember(Name = "num_participants")]
		[Preserve]
		public int NumParticipants { get; set; }

		[DataMember(Name = "promotion_points")]
		[Preserve]
		public int PromotionPoints { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
