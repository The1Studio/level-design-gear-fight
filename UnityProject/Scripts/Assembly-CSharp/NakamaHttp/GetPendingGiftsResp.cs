using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class GetPendingGiftsResp
	{
		[DataMember(Name = "data")]
		[Preserve]
		public GiftsData Data;

		public GetPendingGiftsResp()
		{
		}

		public GetPendingGiftsResp(GiftsData dataParam)
		{
		}
	}
}
