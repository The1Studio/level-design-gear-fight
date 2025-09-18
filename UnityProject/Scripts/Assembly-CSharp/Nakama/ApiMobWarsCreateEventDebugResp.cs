using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsCreateEventDebugResp
	{
		[DataMember(Name = "event_id")]
		[Preserve]
		public string EventId { get; set; }

		[DataMember(Name = "point_config")]
		[Preserve]
		public ApiMobWarsPointConfig PointConfig { get; set; }

		[DataMember(Name = "seconds_until_end")]
		[Preserve]
		public int SecondsUntilEnd { get; set; }

		[DataMember(Name = "seconds_until_start")]
		[Preserve]
		public int SecondsUntilStart { get; set; }

		[DataMember(Name = "week_num_since_epoch")]
		[Preserve]
		public int WeekNumSinceEpoch { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
