using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierCreateEventDebugResp
	{
		[DataMember(Name = "event_data")]
		[Preserve]
		public ApiGodTierData EventData { get; set; }

		[DataMember(Name = "success")]
		[Preserve]
		public bool Success { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
