using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class UpdatePlayerProfileReq
	{
		[DataMember(Name = "badge_ids")]
		[Preserve]
		public List<string> BadgeIds;

		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName;

		[DataMember(Name = "avatar_id")]
		[Preserve]
		public string AvatarID;

		[DataMember(Name = "avatar_url")]
		[Preserve]
		public string AvatarURL;

		[Preserve]
		[DataMember(Name = "country_code")]
		public string CountryCode;

		[Preserve]
		[DataMember(Name = "frame_id")]
		public string FrameId;

		public UpdatePlayerProfileReq()
		{
		}

		public UpdatePlayerProfileReq(List<string> badgeIdsParam, string displayNameParam, string avatarIDParam, string avatarURLParam, string countryCodeParam, string frameIdParam)
		{
		}
	}
}
