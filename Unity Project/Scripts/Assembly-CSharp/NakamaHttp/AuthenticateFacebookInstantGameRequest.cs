using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AuthenticateFacebookInstantGameRequest
	{
		[DataMember(Name = "account")]
		[Preserve]
		public AccountFacebookInstantGame Account;

		[DataMember(Name = "create")]
		[Preserve]
		public bool? Create;

		public AuthenticateFacebookInstantGameRequest()
		{
		}

		public AuthenticateFacebookInstantGameRequest(AccountFacebookInstantGame accountParam, bool? createParam)
		{
		}
	}
}
