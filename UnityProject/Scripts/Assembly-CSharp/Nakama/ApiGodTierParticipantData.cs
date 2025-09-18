using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierParticipantData
	{
		[DataMember(Name = "ahead_players")]
		[Preserve]
		public List<ApiPlayerData> AheadPlayers { get; set; }

		[Preserve]
		[DataMember(Name = "behind_players")]
		public List<ApiPlayerData> BehindPlayers { get; set; }

		[Preserve]
		[DataMember(Name = "user_data")]
		public ApiPlayerData UserData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
