using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierSyncResp
	{
		[Preserve]
		[DataMember(Name = "data")]
		public ApiGodTierData Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
