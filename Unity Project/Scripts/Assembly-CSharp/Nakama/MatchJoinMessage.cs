using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class MatchJoinMessage
	{
		[DataMember(Name = "match_id")]
		[Preserve]
		public string MatchId { get; set; }

		[Preserve]
		[DataMember(Name = "token")]
		public string Token { get; set; }

		[Preserve]
		[DataMember(Name = "metadata")]
		public IDictionary<string, string> Metadata { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
