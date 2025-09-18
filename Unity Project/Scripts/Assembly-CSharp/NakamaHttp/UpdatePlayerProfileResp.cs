using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class UpdatePlayerProfileResp
	{
		[DataMember(Name = "player_profile")]
		[Preserve]
		public PlayerData PlayerProfile;

		[DataMember(Name = "result")]
		[Preserve]
		public UpdatePlayerProfileResult Result;

		public UpdatePlayerProfileResp()
		{
		}

		public UpdatePlayerProfileResp(PlayerData playerProfileParam, UpdatePlayerProfileResult resultParam)
		{
		}
	}
}
