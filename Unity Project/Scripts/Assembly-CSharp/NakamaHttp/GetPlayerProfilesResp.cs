using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class GetPlayerProfilesResp
	{
		[Preserve]
		[DataMember(Name = "player_profiles")]
		public Dictionary<string, PlayerData> PlayerProfiles;

		public GetPlayerProfilesResp()
		{
		}

		public GetPlayerProfilesResp(Dictionary<string, PlayerData> playerProfilesParam)
		{
		}
	}
}
