using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierAckResp
	{
		[DataMember(Name = "data")]
		[Preserve]
		public ApiGodTierData Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
