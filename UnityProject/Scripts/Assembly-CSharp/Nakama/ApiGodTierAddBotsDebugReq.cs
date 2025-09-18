using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierAddBotsDebugReq
	{
		[Preserve]
		[DataMember(Name = "event_id")]
		public string EventId { get; set; }

		[Preserve]
		[DataMember(Name = "new_bots")]
		public List<ApiGodTierBot> NewBots { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
