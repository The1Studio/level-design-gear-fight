using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiLeaderboardRecordList
	{
		[Preserve]
		[DataMember(Name = "owner_records")]
		public List<ApiLeaderboardRecord> OwnerRecords { get; set; }

		[DataMember(Name = "records")]
		[Preserve]
		public List<ApiLeaderboardRecord> Records { get; set; }

		[Preserve]
		[DataMember(Name = "total")]
		public int Total { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
