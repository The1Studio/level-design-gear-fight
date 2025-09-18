using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ImportFacebookFriendsRequest
	{
		[DataMember(Name = "account")]
		[Preserve]
		public AccountFacebook Account;

		[Preserve]
		[DataMember(Name = "reset")]
		public bool? Reset;

		public ImportFacebookFriendsRequest()
		{
		}

		public ImportFacebookFriendsRequest(AccountFacebook accountParam, bool? resetParam)
		{
		}
	}
}
