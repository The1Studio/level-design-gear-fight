using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleAdminGiftsGetResponse
	{
		[DataMember(Name = "delivered_gifts")]
		[Preserve]
		public List<VdGift> DeliveredGifts { get; set; }

		[DataMember(Name = "pending_gifts")]
		[Preserve]
		public List<VdGift> PendingGifts { get; set; }

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
