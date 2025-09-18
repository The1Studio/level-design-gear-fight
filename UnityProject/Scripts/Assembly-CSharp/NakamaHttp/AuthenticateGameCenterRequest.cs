using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AuthenticateGameCenterRequest
	{
		[DataMember(Name = "account")]
		[Preserve]
		public AccountGameCenter Account;

		[Preserve]
		[DataMember(Name = "create")]
		public bool? Create;

		public AuthenticateGameCenterRequest()
		{
		}

		public AuthenticateGameCenterRequest(AccountGameCenter accountParam, bool? createParam)
		{
		}
	}
}
