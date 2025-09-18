using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPlayerProfile
	{
		[Preserve]
		[DataMember(Name = "avatar_id")]
		public string AvatarId { get; set; }

		[DataMember(Name = "avatar_url")]
		[Preserve]
		public string AvatarUrl { get; set; }

		[DataMember(Name = "country_code")]
		[Preserve]
		public string CountryCode { get; set; }

		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName { get; set; }

		[Preserve]
		[DataMember(Name = "is_bot")]
		public bool IsBot { get; set; }

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
