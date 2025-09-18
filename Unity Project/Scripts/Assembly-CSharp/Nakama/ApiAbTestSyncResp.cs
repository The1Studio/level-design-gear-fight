using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestSyncResp
	{
		[DataMember(Name = "ab_tests")]
		[Preserve]
		public Dictionary<string, ApiAbTestAssignment> AbTests { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
