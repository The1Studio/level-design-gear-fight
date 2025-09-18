using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGetPlayerProfileResp
	{
		[DataMember(Name = "player_profile")]
		[Preserve]
		public ApiPlayerProfile PlayerProfile { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
