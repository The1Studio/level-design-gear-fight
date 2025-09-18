using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildLeaderboardSyncResp
	{
		[Preserve]
		[DataMember(Name = "records")]
		public List<ApiGuildLeaderboardRecord> Records { get; set; }

		[Preserve]
		[DataMember(Name = "user_record")]
		public ApiGuildLeaderboardRecord UserRecord { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
