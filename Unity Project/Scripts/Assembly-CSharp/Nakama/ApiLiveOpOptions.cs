using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiLiveOpOptions
	{
		[Preserve]
		[DataMember(Name = "duration_in_seconds")]
		public long DurationInSeconds { get; set; }

		[Preserve]
		[DataMember(Name = "round_data")]
		public string RoundData { get; set; }

		[Preserve]
		[DataMember(Name = "start_in_seconds_from_now")]
		public long StartInSecondsFromNow { get; set; }

		[Preserve]
		[DataMember(Name = "type")]
		public string Type { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
