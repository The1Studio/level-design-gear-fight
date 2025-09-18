using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AuthenticateAppleRequest
	{
		[DataMember(Name = "account")]
		[Preserve]
		public AccountApple Account;

		[DataMember(Name = "create")]
		[Preserve]
		public bool? Create;

		public AuthenticateAppleRequest()
		{
		}

		public AuthenticateAppleRequest(AccountApple accountParam, bool? createParam)
		{
		}
	}
}
