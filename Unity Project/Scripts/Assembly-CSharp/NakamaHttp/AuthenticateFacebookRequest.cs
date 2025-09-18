using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AuthenticateFacebookRequest
	{
		[DataMember(Name = "account")]
		[Preserve]
		public AccountFacebook Account;

		[DataMember(Name = "create")]
		[Preserve]
		public bool? Create;

		[Preserve]
		[DataMember(Name = "sync")]
		public bool? Sync;

		public AuthenticateFacebookRequest()
		{
		}

		public AuthenticateFacebookRequest(AccountFacebook accountParam, bool? createParam, bool? syncParam)
		{
		}
	}
}
