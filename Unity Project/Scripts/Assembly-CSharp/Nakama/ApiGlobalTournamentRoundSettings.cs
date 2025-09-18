using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGlobalTournamentRoundSettings
	{
		[DataMember(Name = "around_user_entries")]
		[Preserve]
		public int AroundUserEntries { get; set; }

		[DataMember(Name = "bot_point_range_max")]
		[Preserve]
		public int BotPointRangeMax { get; set; }

		[Preserve]
		[DataMember(Name = "bot_point_range_min")]
		public int BotPointRangeMin { get; set; }

		[DataMember(Name = "number_of_bots")]
		[Preserve]
		public int NumberOfBots { get; set; }

		[DataMember(Name = "top_entries")]
		[Preserve]
		public int TopEntries { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
