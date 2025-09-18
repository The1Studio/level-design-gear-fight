using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class AccountEmail
	{
		[Preserve]
		[DataMember(Name = "email")]
		public string Email;

		[DataMember(Name = "password")]
		[Preserve]
		public string Password;

		public AccountEmail()
		{
		}

		public AccountEmail(string emailParam, string passwordParam)
		{
		}
	}
}
