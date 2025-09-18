using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AuthenticateGoogleRequest
	{
		[DataMember(Name = "account")]
		[Preserve]
		public AccountGoogle Account;

		[DataMember(Name = "create")]
		[Preserve]
		public bool? Create;

		public AuthenticateGoogleRequest()
		{
		}

		public AuthenticateGoogleRequest(AccountGoogle accountParam, bool? createParam)
		{
		}
	}
}
