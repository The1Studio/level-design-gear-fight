using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class SessionRefreshRequest
	{
		[Preserve]
		[DataMember(Name = "token")]
		public string Token;

		public SessionRefreshRequest()
		{
		}

		public SessionRefreshRequest(string tokenParam)
		{
		}
	}
}
