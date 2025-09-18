using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGiftsSyncRequest
	{
		[DataMember(Name = "delivered_gift_ids")]
		[Preserve]
		public List<string> DeliveredGiftIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
