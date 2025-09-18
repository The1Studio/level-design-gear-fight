using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class MatchSendMessage
	{
		[DataMember(Name = "match_id")]
		[Preserve]
		public string MatchId { get; set; }

		[DataMember(Name = "op_code")]
		[Preserve]
		public string OpCode { get; set; }

		[Preserve]
		[DataMember(Name = "presences")]
		public List<UserPresence> Presences { get; set; }

		[DataMember(Name = "data")]
		[Preserve]
		public string State { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
