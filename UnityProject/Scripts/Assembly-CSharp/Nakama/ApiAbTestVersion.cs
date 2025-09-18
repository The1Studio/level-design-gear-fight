using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestVersion
	{
		[Preserve]
		[DataMember(Name = "ab_test_cases")]
		public Dictionary<string, ApiAbTestCase> AbTestCases { get; set; }

		[DataMember(Name = "creation_seconds")]
		[Preserve]
		public long CreationSeconds { get; set; }

		[Preserve]
		[DataMember(Name = "salt")]
		public string Salt { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
