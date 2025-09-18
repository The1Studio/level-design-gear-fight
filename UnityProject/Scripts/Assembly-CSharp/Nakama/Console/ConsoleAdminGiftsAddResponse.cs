using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleAdminGiftsAddResponse
	{
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
