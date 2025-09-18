using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierTopData
	{
		[Preserve]
		[DataMember(Name = "top_players")]
		public List<ApiPlayerData> TopPlayers { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
