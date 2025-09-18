using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class MergeAccountRequest
	{
		[Preserve]
		[DataMember(Name = "from_account_session_token")]
		public string FromAccountSessionToken;

		public MergeAccountRequest()
		{
		}

		public MergeAccountRequest(string fromAccountSessionTokenParam)
		{
		}
	}
}
