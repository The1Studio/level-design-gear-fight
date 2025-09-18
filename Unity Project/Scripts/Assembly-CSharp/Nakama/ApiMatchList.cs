using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMatchList
	{
		[DataMember(Name = "matches")]
		[Preserve]
		public List<ApiMatch> Matches { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
