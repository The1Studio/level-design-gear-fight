using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ClaimGiftsReq
	{
		[DataMember(Name = "gift_ids")]
		[Preserve]
		public List<string> GiftIds;

		public ClaimGiftsReq()
		{
		}

		public ClaimGiftsReq(List<string> giftIdsParam)
		{
		}
	}
}
