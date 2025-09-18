using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGiftsAddResponse
	{
		[DataMember(Name = "pending_gifts")]
		[Preserve]
		public List<ApiGift> PendingGifts { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
