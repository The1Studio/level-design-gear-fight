using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class UpdateAccountRequest
	{
		[Preserve]
		[DataMember(Name = "display_name")]
		public string DisplayName;

		[DataMember(Name = "avatar_url")]
		[Preserve]
		public string AvatarUrl;

		public UpdateAccountRequest()
		{
		}

		public UpdateAccountRequest(string displayNameParam, string avatarUrlParam)
		{
		}
	}
}
