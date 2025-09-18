using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestConfiguration
	{
		[Preserve]
		[DataMember(Name = "ab_test_versions")]
		public Dictionary<string, ApiAbTestVersion> AbTestVersions { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
