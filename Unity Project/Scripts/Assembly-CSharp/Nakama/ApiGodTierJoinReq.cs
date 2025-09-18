using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierJoinReq
	{
		[Preserve]
		[DataMember(Name = "accepted")]
		public bool Accepted { get; set; }

		[DataMember(Name = "data")]
		[Preserve]
		public ApiGodTierRequestData Data { get; set; }

		[DataMember(Name = "event_id")]
		[Preserve]
		public string EventId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
