using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiLeaderboardRecordList
	{
		[DataMember(Name = "next_cursor")]
		[Preserve]
		public string NextCursor { get; set; }

		[Preserve]
		[DataMember(Name = "owner_records")]
		public List<ApiLeaderboardRecord> OwnerRecords { get; set; }

		[Preserve]
		[DataMember(Name = "prev_cursor")]
		public string PrevCursor { get; set; }

		[Preserve]
		[DataMember(Name = "records")]
		public List<ApiLeaderboardRecord> Records { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
