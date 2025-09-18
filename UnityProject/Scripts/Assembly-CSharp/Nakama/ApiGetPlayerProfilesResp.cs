using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGetPlayerProfilesResp
	{
		[DataMember(Name = "player_profiles")]
		[Preserve]
		public Dictionary<string, ApiPlayerProfile> PlayerProfiles { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
