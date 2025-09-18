using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class NakamaconsoleUpdateAccountRequest
	{
		[DataMember(Name = "avatar_url")]
		[Preserve]
		public string AvatarUrl { get; set; }

		[DataMember(Name = "device_ids")]
		[Preserve]
		public Dictionary<string, string> DeviceIds { get; set; }

		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName { get; set; }

		[DataMember(Name = "email")]
		[Preserve]
		public string Email { get; set; }

		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[DataMember(Name = "lang_tag")]
		[Preserve]
		public string LangTag { get; set; }

		[DataMember(Name = "location")]
		[Preserve]
		public string Location { get; set; }

		[Preserve]
		[DataMember(Name = "metadata")]
		public string Metadata { get; set; }

		[Preserve]
		[DataMember(Name = "password")]
		public string Password { get; set; }

		[Preserve]
		[DataMember(Name = "timezone")]
		public string Timezone { get; set; }

		[Preserve]
		[DataMember(Name = "username")]
		public string Username { get; set; }

		[DataMember(Name = "wallet")]
		[Preserve]
		public string Wallet { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
