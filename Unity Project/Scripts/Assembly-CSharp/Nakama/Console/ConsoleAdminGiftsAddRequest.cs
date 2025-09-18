using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleAdminGiftsAddRequest
	{
		[DataMember(Name = "new_gifts")]
		[Preserve]
		public List<VdGiftNew> NewGifts { get; set; }

		[Preserve]
		[DataMember(Name = "user_id")]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
