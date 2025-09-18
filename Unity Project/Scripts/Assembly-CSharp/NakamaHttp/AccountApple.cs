using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AccountApple
	{
		[DataMember(Name = "token")]
		[Preserve]
		public string Token;

		public AccountApple()
		{
		}

		public AccountApple(string tokenParam)
		{
		}
	}
}
