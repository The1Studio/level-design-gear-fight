using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiUpdateAccountRequest
	{
		[DataMember(Name = "avatar_url")]
		[Preserve]
		public string AvatarUrl { get; set; }

		[Preserve]
		[DataMember(Name = "display_name")]
		public string DisplayName { get; set; }

		[Preserve]
		[DataMember(Name = "lang_tag")]
		public string LangTag { get; set; }

		[DataMember(Name = "location")]
		[Preserve]
		public string Location { get; set; }

		[DataMember(Name = "timezone")]
		[Preserve]
		public string Timezone { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
