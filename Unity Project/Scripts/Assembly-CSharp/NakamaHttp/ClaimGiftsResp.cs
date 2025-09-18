using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ClaimGiftsResp
	{
		[Preserve]
		[DataMember(Name = "data")]
		public GiftsData Data;

		[Preserve]
		[DataMember(Name = "claimed_gifts")]
		public Dictionary<string, bool> ClaimedGifts;

		public ClaimGiftsResp()
		{
		}

		public ClaimGiftsResp(GiftsData dataParam, Dictionary<string, bool> claimedGiftsParam)
		{
		}
	}
}
