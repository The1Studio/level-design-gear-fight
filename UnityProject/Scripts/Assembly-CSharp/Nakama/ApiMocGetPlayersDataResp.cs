using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocGetPlayersDataResp
	{
		[Preserve]
		[DataMember(Name = "players_data")]
		public Dictionary<string, ApiMocPlayerData> PlayersData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
