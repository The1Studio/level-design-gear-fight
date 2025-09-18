using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildLeaderboardSyncReq
	{
		[Preserve]
		[DataMember(Name = "around_record_count")]
		public int AroundRecordCount { get; set; }

		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[DataMember(Name = "top_record_count")]
		[Preserve]
		public int TopRecordCount { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
