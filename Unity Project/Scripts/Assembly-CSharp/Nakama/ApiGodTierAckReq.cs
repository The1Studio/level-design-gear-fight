using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierAckReq
	{
		[Preserve]
		[DataMember(Name = "data")]
		public ApiGodTierRequestData Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
