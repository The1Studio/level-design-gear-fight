using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiUpdatePlayerProfileResp
	{
		[DataMember(Name = "player_profile")]
		[Preserve]
		public ApiPlayerProfile PlayerProfile { get; set; }

		[DataMember(Name = "result")]
		[Preserve]
		public UpdatePlayerProfileRespUpdatePlayerProfileResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
