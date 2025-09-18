using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AuthenticateEmailVerifyCodeRequest
	{
		[Preserve]
		[DataMember(Name = "email")]
		public string Email;

		[DataMember(Name = "code")]
		[Preserve]
		public string Code;

		[DataMember(Name = "create")]
		[Preserve]
		public bool Create;

		public AuthenticateEmailVerifyCodeRequest()
		{
		}

		public AuthenticateEmailVerifyCodeRequest(string emailParam, string codeParam, bool createParam)
		{
		}
	}
}
