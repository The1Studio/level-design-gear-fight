using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class LinkFacebookRequest
	{
		[DataMember(Name = "account")]
		[Preserve]
		public AccountFacebook Account;

		[DataMember(Name = "sync")]
		[Preserve]
		public bool? Sync;

		public LinkFacebookRequest()
		{
		}

		public LinkFacebookRequest(AccountFacebook accountParam, bool? syncParam)
		{
		}
	}
}
