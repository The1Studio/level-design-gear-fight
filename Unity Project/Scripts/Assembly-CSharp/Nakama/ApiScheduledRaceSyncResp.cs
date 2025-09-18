using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduledRaceSyncResp
	{
		[Preserve]
		[DataMember(Name = "feature_data")]
		public ApiFeatureData FeatureData { get; set; }

		[DataMember(Name = "request_status")]
		[Preserve]
		public ApiRequestStatus RequestStatus { get; set; }

		[DataMember(Name = "scheduled_race_data")]
		[Preserve]
		public ApiScheduledRaceData ScheduledRaceData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
