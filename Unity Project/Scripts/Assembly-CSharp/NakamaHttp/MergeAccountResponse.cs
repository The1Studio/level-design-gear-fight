using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class MergeAccountResponse
	{
		[Preserve]
		[DataMember(Name = "account")]
		public Account Account;

		public MergeAccountResponse()
		{
		}

		public MergeAccountResponse(Account accountParam)
		{
		}
	}
}
