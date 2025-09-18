using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class SendGiftsDebugResp
	{
		[DataMember(Name = "gifts")]
		[Preserve]
		public List<Gift> Gifts;

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId;

		public SendGiftsDebugResp()
		{
		}

		public SendGiftsDebugResp(List<Gift> giftsParam, string userIdParam)
		{
		}
	}
}
