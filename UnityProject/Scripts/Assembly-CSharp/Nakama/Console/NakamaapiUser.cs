using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class NakamaapiUser
	{
		[DataMember(Name = "apple_id")]
		[Preserve]
		public string AppleId { get; set; }

		[Preserve]
		[DataMember(Name = "avatar_url")]
		public string AvatarUrl { get; set; }

		[DataMember(Name = "create_time")]
		[Preserve]
		public string CreateTime { get; set; }

		[DataMember(Name = "device_ids")]
		[Preserve]
		public List<string> DeviceIds { get; set; }

		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName { get; set; }

		[DataMember(Name = "edge_count")]
		[Preserve]
		public int EdgeCount { get; set; }

		[DataMember(Name = "facebook_id")]
		[Preserve]
		public string FacebookId { get; set; }

		[DataMember(Name = "facebook_instant_game_id")]
		[Preserve]
		public string FacebookInstantGameId { get; set; }

		[DataMember(Name = "gamecenter_id")]
		[Preserve]
		public string GamecenterId { get; set; }

		[DataMember(Name = "google_id")]
		[Preserve]
		public string GoogleId { get; set; }

		[Preserve]
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "lang_tag")]
		public string LangTag { get; set; }

		[DataMember(Name = "location")]
		[Preserve]
		public string Location { get; set; }

		[DataMember(Name = "metadata")]
		[Preserve]
		public string Metadata { get; set; }

		[DataMember(Name = "online")]
		[Preserve]
		public bool Online { get; set; }

		[DataMember(Name = "steam_id")]
		[Preserve]
		public string SteamId { get; set; }

		[Preserve]
		[DataMember(Name = "timezone")]
		public string Timezone { get; set; }

		[DataMember(Name = "update_time")]
		[Preserve]
		public string UpdateTime { get; set; }

		[Preserve]
		[DataMember(Name = "username")]
		public string Username { get; set; }

		[Preserve]
		[DataMember(Name = "voodoo_ids")]
		public List<string> VoodooIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
