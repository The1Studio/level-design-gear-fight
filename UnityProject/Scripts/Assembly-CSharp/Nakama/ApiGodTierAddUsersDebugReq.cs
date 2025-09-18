using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierAddUsersDebugReq
	{
		[Preserve]
		[DataMember(Name = "event_id")]
		public string EventId { get; set; }

		[DataMember(Name = "user_ids")]
		[Preserve]
		public List<string> UserIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
