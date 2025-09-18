using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierJoinResp
	{
		[Preserve]
		[DataMember(Name = "data")]
		public ApiGodTierData Data { get; set; }

		[DataMember(Name = "success")]
		[Preserve]
		public bool Success { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
