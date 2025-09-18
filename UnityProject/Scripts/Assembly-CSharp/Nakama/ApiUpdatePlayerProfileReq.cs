using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiUpdatePlayerProfileReq
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

		public override string ToString()
		{
			return null;
		}
	}
}
