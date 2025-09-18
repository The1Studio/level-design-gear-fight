using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestCase
	{
		[DataMember(Name = "case_name")]
		[Preserve]
		public string CaseName { get; set; }

		[DataMember(Name = "range_end_inclusive")]
		[Preserve]
		public int RangeEndInclusive { get; set; }

		[DataMember(Name = "range_start_inclusive")]
		[Preserve]
		public int RangeStartInclusive { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
