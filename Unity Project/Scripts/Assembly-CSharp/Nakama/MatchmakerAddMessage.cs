using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class MatchmakerAddMessage
	{
		[Preserve]
		[DataMember(Name = "max_count")]
		public int MaxCount { get; set; }

		[Preserve]
		[DataMember(Name = "min_count")]
		public int MinCount { get; set; }

		[DataMember(Name = "numeric_properties")]
		[Preserve]
		public Dictionary<string, double> NumericProperties { get; set; }

		[Preserve]
		[DataMember(Name = "query")]
		public string Query { get; set; }

		[DataMember(Name = "string_properties")]
		[Preserve]
		public Dictionary<string, string> StringProperties { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
