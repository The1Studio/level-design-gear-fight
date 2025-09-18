using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class GiftsData
	{
		[Preserve]
		[DataMember(Name = "gifts")]
		public List<Gift> Gifts;

		public GiftsData()
		{
		}

		public GiftsData(List<Gift> giftsParam)
		{
		}
	}
}
