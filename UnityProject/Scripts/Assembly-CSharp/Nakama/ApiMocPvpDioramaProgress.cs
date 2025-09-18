using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpDioramaProgress
	{
		[Preserve]
		[DataMember(Name = "damaged")]
		public bool Damaged { get; set; }

		[Preserve]
		[DataMember(Name = "index")]
		public int Index { get; set; }

		[DataMember(Name = "segment_index")]
		[Preserve]
		public int SegmentIndex { get; set; }

		[DataMember(Name = "segment_spent_resources")]
		[Preserve]
		public int SegmentSpentResources { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
