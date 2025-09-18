using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AuthenticateEmailRequestCodeRequest
	{
		[DataMember(Name = "email")]
		[Preserve]
		public string Email;

		[DataMember(Name = "create")]
		[Preserve]
		public bool Create;

		public AuthenticateEmailRequestCodeRequest()
		{
		}

		public AuthenticateEmailRequestCodeRequest(string emailParam, bool createParam)
		{
		}
	}
}
