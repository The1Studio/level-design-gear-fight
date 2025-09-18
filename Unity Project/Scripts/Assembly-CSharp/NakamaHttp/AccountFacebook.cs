using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AccountFacebook
	{
		[DataMember(Name = "token")]
		[Preserve]
		public string Token;

		public AccountFacebook()
		{
		}

		public AccountFacebook(string tokenParam)
		{
		}
	}
}
