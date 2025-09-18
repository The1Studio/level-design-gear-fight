using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsEndEventDebugReq
	{
		[Preserve]
		[DataMember(Name = "event_id")]
		public string EventId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
