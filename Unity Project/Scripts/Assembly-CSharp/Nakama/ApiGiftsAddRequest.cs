using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGiftsAddRequest
	{
		[DataMember(Name = "new_gifts")]
		[Preserve]
		public List<ApiGiftNew> NewGifts { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
