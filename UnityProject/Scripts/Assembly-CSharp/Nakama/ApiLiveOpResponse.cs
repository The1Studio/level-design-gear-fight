using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiLiveOpResponse
	{
		[Preserve]
		[DataMember(Name = "scheduled_live_ops")]
		public List<ApiLiveOp> ScheduledLiveOps { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
