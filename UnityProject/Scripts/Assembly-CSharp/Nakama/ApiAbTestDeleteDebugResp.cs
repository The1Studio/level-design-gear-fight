using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestDeleteDebugResp
	{
		[Preserve]
		[DataMember(Name = "ab_tests")]
		public Dictionary<string, ApiAbTestConfiguration> AbTests { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
