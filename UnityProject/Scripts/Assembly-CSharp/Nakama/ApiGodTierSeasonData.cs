using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierSeasonData
	{
		[Preserve]
		[DataMember(Name = "lowest_position_for_weekly_badge")]
		public int LowestPositionForWeeklyBadge { get; set; }

		[DataMember(Name = "progress_data")]
		[Preserve]
		public ApiGodTierProgressData ProgressData { get; set; }

		[DataMember(Name = "timing_data")]
		[Preserve]
		public ApiTimingData TimingData { get; set; }

		[DataMember(Name = "total_weeks")]
		[Preserve]
		public int TotalWeeks { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
