using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiRestoreRewardsResponse
	{
		[Preserve]
		[DataMember(Name = "results")]
		public List<ApiRestoreResult> Results { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
