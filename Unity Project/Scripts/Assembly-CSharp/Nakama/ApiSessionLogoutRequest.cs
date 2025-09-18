using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiSessionLogoutRequest
	{
		[DataMember(Name = "refresh_token")]
		[Preserve]
		public string RefreshToken { get; set; }

		[DataMember(Name = "token")]
		[Preserve]
		public string Token { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
