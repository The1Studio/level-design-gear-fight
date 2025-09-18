using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AuthenticateEmailRequest
	{
		[DataMember(Name = "account")]
		[Preserve]
		public AccountEmail Account;

		[DataMember(Name = "create")]
		[Preserve]
		public bool? Create;

		public AuthenticateEmailRequest()
		{
		}

		public AuthenticateEmailRequest(AccountEmail accountParam, bool? createParam)
		{
		}
	}
}
