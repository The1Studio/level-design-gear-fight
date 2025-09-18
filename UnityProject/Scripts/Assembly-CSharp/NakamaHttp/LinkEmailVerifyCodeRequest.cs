using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class LinkEmailVerifyCodeRequest
	{
		[Preserve]
		[DataMember(Name = "email")]
		public string Email;

		[Preserve]
		[DataMember(Name = "code")]
		public string Code;

		public LinkEmailVerifyCodeRequest()
		{
		}

		public LinkEmailVerifyCodeRequest(string emailParam, string codeParam)
		{
		}
	}
}
