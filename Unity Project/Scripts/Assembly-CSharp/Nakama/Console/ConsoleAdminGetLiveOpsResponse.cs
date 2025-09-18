using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleAdminGetLiveOpsResponse
	{
		[DataMember(Name = "live_ops")]
		[Preserve]
		public List<VdLiveOp> LiveOps { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
