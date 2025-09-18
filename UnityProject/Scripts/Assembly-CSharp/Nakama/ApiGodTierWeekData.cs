using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierWeekData
	{
		[DataMember(Name = "badge_process")]
		[Preserve]
		public ApiGodTierBadgeProgress BadgeProcess { get; set; }

		[Preserve]
		[DataMember(Name = "progress_data")]
		public ApiGodTierProgressData ProgressData { get; set; }

		[Preserve]
		[DataMember(Name = "status")]
		public GodTierWeekDataWeekStatus Status { get; set; }

		[Preserve]
		[DataMember(Name = "timing_data")]
		public ApiTimingData TimingData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
