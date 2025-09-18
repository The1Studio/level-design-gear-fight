using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class PlayerData
	{
		[Preserve]
		[DataMember(Name = "badge")]
		public Badge Badge;

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId;

		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName;

		[DataMember(Name = "avatar_url")]
		[Preserve]
		public string AvatarURL;

		[Preserve]
		[DataMember(Name = "avatar_id")]
		public string AvatarID;

		[Preserve]
		[DataMember(Name = "points")]
		public int Points;

		[Preserve]
		[DataMember(Name = "position_in_ranking")]
		public int PositionInRanking;

		[Preserve]
		[DataMember(Name = "country_code")]
		public string CountryCode;

		public PlayerData()
		{
		}

		public PlayerData(Badge badgeParam, string userIdParam, string displayNameParam, string avatarURLParam, string avatarIDParam, int pointsParam, int positionInRankingParam, string countryCodeParam)
		{
		}
	}
}
