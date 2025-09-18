using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierSyncReq
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
