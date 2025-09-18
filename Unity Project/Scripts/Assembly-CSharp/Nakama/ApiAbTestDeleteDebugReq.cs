using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestDeleteDebugReq
	{
		[DataMember(Name = "ab_test_name")]
		[Preserve]
		public string AbTestName { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
