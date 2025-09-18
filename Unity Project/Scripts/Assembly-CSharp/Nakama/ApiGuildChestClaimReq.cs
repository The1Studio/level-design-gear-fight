using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChestClaimReq
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "delivered_target_ids")]
		[Preserve]
		public List<int> DeliveredTargetIds { get; set; }

		[DataMember(Name = "event_id")]
		[Preserve]
		public int EventId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
