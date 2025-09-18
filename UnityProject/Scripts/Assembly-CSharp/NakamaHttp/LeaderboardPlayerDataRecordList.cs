using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class LeaderboardPlayerDataRecordList
	{
		[DataMember(Name = "records")]
		[Preserve]
		public List<LeaderboardPlayerDataRecord> Records;

		[Preserve]
		[DataMember(Name = "owner_records")]
		public List<LeaderboardPlayerDataRecord> OwnerRecords;

		[DataMember(Name = "total")]
		[Preserve]
		public int Total;

		public LeaderboardPlayerDataRecordList()
		{
		}

		public LeaderboardPlayerDataRecordList(List<LeaderboardPlayerDataRecord> recordsParam, List<LeaderboardPlayerDataRecord> ownerRecordsParam, int totalParam)
		{
		}
	}
}
