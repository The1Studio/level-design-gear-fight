using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestGetDebugResp
	{
		[DataMember(Name = "ab_test_config")]
		[Preserve]
		public ApiAbTestConfiguration AbTestConfig { get; set; }

		[DataMember(Name = "ab_test_name")]
		[Preserve]
		public string AbTestName { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
