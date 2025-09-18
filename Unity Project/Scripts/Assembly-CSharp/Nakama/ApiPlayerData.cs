using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPlayerData
	{
		[DataMember(Name = "avatar_id")]
		[Preserve]
		public string AvatarId { get; set; }

		[Preserve]
		[DataMember(Name = "avatar_url")]
		public string AvatarUrl { get; set; }

		[Preserve]
		[DataMember(Name = "country_code")]
		public string CountryCode { get; set; }

		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName { get; set; }

		[Preserve]
		[DataMember(Name = "is_bot")]
		public bool IsBot { get; set; }

		[Preserve]
		[DataMember(Name = "points")]
		public int Points { get; set; }

		[DataMember(Name = "position_in_ranking")]
		[Preserve]
		public int PositionInRanking { get; set; }

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
