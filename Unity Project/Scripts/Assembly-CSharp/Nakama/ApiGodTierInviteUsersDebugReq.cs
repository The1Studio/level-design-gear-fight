using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierInviteUsersDebugReq
	{
		[DataMember(Name = "event_id")]
		[Preserve]
		public string EventId { get; set; }

		[Preserve]
		[DataMember(Name = "user_ids")]
		public List<string> UserIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
