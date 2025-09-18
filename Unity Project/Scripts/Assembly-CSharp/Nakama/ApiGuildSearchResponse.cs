using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildSearchResponse
	{
		[Preserve]
		[DataMember(Name = "results")]
		public List<ApiGuildSearchResult> Results { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
