using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsEndEventReq
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "event_id")]
		[Preserve]
		public string EventId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
