using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class GetPlayerProfilesReq
	{
		[Preserve]
		[DataMember(Name = "user_ids")]
		public List<string> UserIds;

		public GetPlayerProfilesReq()
		{
		}

		public GetPlayerProfilesReq(List<string> userIdsParam)
		{
		}
	}
}
