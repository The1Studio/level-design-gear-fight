using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class LeaderboardRecordList
	{
		[Preserve]
		[DataMember(Name = "records")]
		public List<LeaderboardRecord> Records;

		[DataMember(Name = "owner_records")]
		[Preserve]
		public List<LeaderboardRecord> OwnerRecords;

		[DataMember(Name = "total")]
		[Preserve]
		public int Total;

		public LeaderboardRecordList()
		{
		}

		public LeaderboardRecordList(List<LeaderboardRecord> recordsParam, List<LeaderboardRecord> ownerRecordsParam, int totalParam)
		{
		}
	}
}
