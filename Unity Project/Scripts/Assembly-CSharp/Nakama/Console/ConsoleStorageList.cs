using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleStorageList
	{
		[DataMember(Name = "next_cursor")]
		[Preserve]
		public string NextCursor { get; set; }

		[DataMember(Name = "objects")]
		[Preserve]
		public List<ApiStorageObject> Objects { get; set; }

		[DataMember(Name = "total_count")]
		[Preserve]
		public int TotalCount { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
