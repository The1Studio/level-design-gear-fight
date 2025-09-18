using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiLeaderboardPlayerDataRecordList
	{
		[Preserve]
		[DataMember(Name = "owner_records")]
		public List<ApiLeaderboardPlayerDataRecord> OwnerRecords { get; set; }

		[Preserve]
		[DataMember(Name = "records")]
		public List<ApiLeaderboardPlayerDataRecord> Records { get; set; }

		[Preserve]
		[DataMember(Name = "total")]
		public int Total { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
