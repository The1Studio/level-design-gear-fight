using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPiggyRaceData
	{
		[DataMember(Name = "ordered_players")]
		[Preserve]
		public List<ApiPlayerData> OrderedPlayers { get; set; }

		[DataMember(Name = "player")]
		[Preserve]
		public ApiPlayerData Player { get; set; }

		[DataMember(Name = "race_id")]
		[Preserve]
		public int RaceId { get; set; }

		[DataMember(Name = "seconds_until_autofill")]
		[Preserve]
		public int SecondsUntilAutofill { get; set; }

		[DataMember(Name = "seconds_until_end")]
		[Preserve]
		public int SecondsUntilEnd { get; set; }

		[DataMember(Name = "seconds_until_start")]
		[Preserve]
		public int SecondsUntilStart { get; set; }

		[DataMember(Name = "status")]
		[Preserve]
		public PiggyRaceDataPiggyRaceStatus Status { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
