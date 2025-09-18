using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsJoinEventDebugReq
	{
		[Preserve]
		[DataMember(Name = "event_id")]
		public string EventId { get; set; }

		[Preserve]
		[DataMember(Name = "joined_blue")]
		public bool JoinedBlue { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
