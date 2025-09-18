using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPurchaseValidationVanInfo
	{
		[DataMember(Name = "ab_test_uuid")]
		[Preserve]
		public string AbTestUuid { get; set; }

		[Preserve]
		[DataMember(Name = "cohort_uuid")]
		public string CohortUuid { get; set; }

		[DataMember(Name = "segment_uuid")]
		[Preserve]
		public string SegmentUuid { get; set; }

		[DataMember(Name = "session_count")]
		[Preserve]
		public int SessionCount { get; set; }

		[Preserve]
		[DataMember(Name = "session_id")]
		public string SessionId { get; set; }

		[DataMember(Name = "session_length")]
		[Preserve]
		public int SessionLength { get; set; }

		[Preserve]
		[DataMember(Name = "version_uuid")]
		public string VersionUuid { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
