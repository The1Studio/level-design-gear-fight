using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class User
	{
		[DataMember(Name = "device_ids")]
		[Preserve]
		public List<string> DeviceIds;

		[DataMember(Name = "voodoo_ids")]
		[Preserve]
		public List<string> VoodooIds;

		[Preserve]
		[DataMember(Name = "id")]
		public string Id;

		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName;

		[DataMember(Name = "avatar_url")]
		[Preserve]
		public string AvatarUrl;

		[DataMember(Name = "facebook_id")]
		[Preserve]
		public string FacebookId;

		[Preserve]
		[DataMember(Name = "google_id")]
		public string GoogleId;

		[Preserve]
		[DataMember(Name = "gamecenter_id")]
		public string GamecenterId;

		[Preserve]
		[DataMember(Name = "steam_id")]
		public string SteamId;

		[DataMember(Name = "create_time")]
		[Preserve]
		public string CreateTime;

		[DataMember(Name = "update_time")]
		[Preserve]
		public string UpdateTime;

		[Preserve]
		[DataMember(Name = "facebook_instant_game_id")]
		public string FacebookInstantGameId;

		[DataMember(Name = "apple_id")]
		[Preserve]
		public string AppleId;

		public User()
		{
		}

		public User(List<string> deviceIdsParam, List<string> voodooIdsParam, string idParam, string displayNameParam, string avatarUrlParam, string facebookIdParam, string googleIdParam, string gamecenterIdParam, string steamIdParam, string createTimeParam, string updateTimeParam, string facebookInstantGameIdParam, string appleIdParam)
		{
		}
	}
}
