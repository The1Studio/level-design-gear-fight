using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestCreateVersionDebugResp
	{
		[DataMember(Name = "ab_test_config")]
		[Preserve]
		public ApiAbTestConfiguration AbTestConfig { get; set; }

		[DataMember(Name = "ab_test_name")]
		[Preserve]
		public string AbTestName { get; set; }

		[DataMember(Name = "status")]
		[Preserve]
		public AbTestCreateVersionDebugRespAbTestStatus Status { get; set; }

		[DataMember(Name = "version")]
		[Preserve]
		public int Version { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
