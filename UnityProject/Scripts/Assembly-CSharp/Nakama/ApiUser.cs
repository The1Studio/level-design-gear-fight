using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiUser
	{
		[Preserve]
		[DataMember(Name = "apple_id")]
		public string AppleId { get; set; }

		[Preserve]
		[DataMember(Name = "avatar_url")]
		public string AvatarUrl { get; set; }

		[Preserve]
		[DataMember(Name = "create_time")]
		public string CreateTime { get; set; }

		[Preserve]
		[DataMember(Name = "device_ids")]
		public List<string> DeviceIds { get; set; }

		[Preserve]
		[DataMember(Name = "display_name")]
		public string DisplayName { get; set; }

		[Preserve]
		[DataMember(Name = "edge_count")]
		public int EdgeCount { get; set; }

		[Preserve]
		[DataMember(Name = "eth_address")]
		public string EthAddress { get; set; }

		[Preserve]
		[DataMember(Name = "facebook_id")]
		public string FacebookId { get; set; }

		[Preserve]
		[DataMember(Name = "facebook_instant_game_id")]
		public string FacebookInstantGameId { get; set; }

		[DataMember(Name = "gamecenter_id")]
		[Preserve]
		public string GamecenterId { get; set; }

		[DataMember(Name = "google_id")]
		[Preserve]
		public string GoogleId { get; set; }

		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[DataMember(Name = "lang_tag")]
		[Preserve]
		public string LangTag { get; set; }

		[Preserve]
		[DataMember(Name = "location")]
		public string Location { get; set; }

		[DataMember(Name = "metadata")]
		[Preserve]
		public string Metadata { get; set; }

		[DataMember(Name = "online")]
		[Preserve]
		public bool Online { get; set; }

		[Preserve]
		[DataMember(Name = "steam_id")]
		public string SteamId { get; set; }

		[Preserve]
		[DataMember(Name = "timezone")]
		public string Timezone { get; set; }

		[DataMember(Name = "update_time")]
		[Preserve]
		public string UpdateTime { get; set; }

		[DataMember(Name = "voodoo_ids")]
		[Preserve]
		public List<string> VoodooIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
