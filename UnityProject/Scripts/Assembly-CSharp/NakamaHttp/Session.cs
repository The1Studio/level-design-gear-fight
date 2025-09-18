using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class Session
	{
		[Preserve]
		[DataMember(Name = "created")]
		public bool Created;

		[DataMember(Name = "token")]
		[Preserve]
		public string Token;

		[DataMember(Name = "refresh_token")]
		[Preserve]
		public string RefreshToken;

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId;

		public Session()
		{
		}

		public Session(bool createdParam, string tokenParam, string refreshTokenParam, string userIdParam)
		{
		}
	}
}
