using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class SendGiftsDebugReq
	{
		[Preserve]
		[DataMember(Name = "new_gifts")]
		public List<NewGift> NewGifts;

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId;

		public SendGiftsDebugReq()
		{
		}

		public SendGiftsDebugReq(List<NewGift> newGiftsParam, string userIdParam)
		{
		}
	}
}
