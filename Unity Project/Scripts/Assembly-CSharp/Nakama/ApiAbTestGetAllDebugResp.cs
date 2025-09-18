using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestGetAllDebugResp
	{
		[DataMember(Name = "ab_tests")]
		[Preserve]
		public Dictionary<string, ApiAbTestConfiguration> AbTests { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
