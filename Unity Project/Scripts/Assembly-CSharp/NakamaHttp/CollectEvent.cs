using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class CollectEvent
	{
		[Preserve]
		[DataMember(Name = "timing_data")]
		public TimingData TimingData;

		[Preserve]
		[DataMember(Name = "configuration")]
		public CollectConfiguration Configuration;

		[DataMember(Name = "id")]
		[Preserve]
		public string Id;

		[DataMember(Name = "event_status")]
		[Preserve]
		public CollectStatus EventStatus;

		public CollectEvent()
		{
		}

		public CollectEvent(TimingData timingDataParam, CollectConfiguration configurationParam, string idParam, CollectStatus eventStatusParam)
		{
		}
	}
}
