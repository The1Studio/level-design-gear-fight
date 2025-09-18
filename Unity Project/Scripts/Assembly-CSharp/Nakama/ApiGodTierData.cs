using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierData
	{
		[Preserve]
		[DataMember(Name = "current_gods")]
		public ApiGodTierGodData CurrentGods { get; set; }

		[Preserve]
		[DataMember(Name = "season_data")]
		public ApiGodTierSeasonData SeasonData { get; set; }

		[Preserve]
		[DataMember(Name = "status")]
		public GodTierDataGodTierStatus Status { get; set; }

		[Preserve]
		[DataMember(Name = "weeks_data")]
		public List<ApiGodTierWeekData> WeeksData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
