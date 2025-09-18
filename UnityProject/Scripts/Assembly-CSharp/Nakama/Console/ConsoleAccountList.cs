using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleAccountList
	{
		[DataMember(Name = "next_cursor")]
		[Preserve]
		public string NextCursor { get; set; }

		[DataMember(Name = "total_count")]
		[Preserve]
		public int TotalCount { get; set; }

		[DataMember(Name = "users")]
		[Preserve]
		public List<NakamaapiUser> Users { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
