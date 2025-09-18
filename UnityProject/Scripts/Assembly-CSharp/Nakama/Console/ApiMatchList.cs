using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiMatchList
	{
		[Preserve]
		[DataMember(Name = "matches")]
		public List<NakamaapiMatch> Matches { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
