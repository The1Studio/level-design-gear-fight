using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class GetPlayerProfileResp
	{
		[DataMember(Name = "player_profile")]
		[Preserve]
		public PlayerData PlayerProfile;

		public GetPlayerProfileResp()
		{
		}

		public GetPlayerProfileResp(PlayerData playerProfileParam)
		{
		}
	}
}
