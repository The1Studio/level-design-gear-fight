using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class LeaderboardCleanupResponse
	{
		[Preserve]
		[DataMember(Name = "owners")]
		public List<string> Owners;

		[DataMember(Name = "total_existing")]
		[Preserve]
		public int TotalExisting;

		public LeaderboardCleanupResponse()
		{
		}

		public LeaderboardCleanupResponse(List<string> ownersParam, int totalExistingParam)
		{
		}
	}
}
