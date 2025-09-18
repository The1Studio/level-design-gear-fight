using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyMatchmakerAdd
	{
		[DataMember(Name = "party_id")]
		[Preserve]
		public string PartyId { get; set; }

		[DataMember(Name = "max_count")]
		[Preserve]
		public int MaxCount { get; set; }

		[DataMember(Name = "min_count")]
		[Preserve]
		public int MinCount { get; set; }

		[DataMember(Name = "query")]
		[Preserve]
		public string Query { get; set; }

		[DataMember(Name = "string_properties")]
		[Preserve]
		public Dictionary<string, string> StringProperties { get; set; }

		[Preserve]
		[DataMember(Name = "numeric_properties")]
		public Dictionary<string, double> NumericProperties { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
