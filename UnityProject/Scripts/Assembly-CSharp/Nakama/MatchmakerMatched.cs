using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class MatchmakerMatched : IMatchmakerMatched
	{
		[DataMember(Name = "match_id")]
		[Preserve]
		public string MatchId { get; set; }

		[Preserve]
		[DataMember(Name = "ticket")]
		public string Ticket { get; set; }

		[Preserve]
		[DataMember(Name = "token")]
		public string Token { get; set; }

		public IEnumerable<IMatchmakerUser> Users => null;

		[DataMember(Name = "users")]
		[Preserve]
		public List<MatchmakerUser> _users { get; set; }

		public IMatchmakerUser Self => null;

		[DataMember(Name = "self")]
		[Preserve]
		public MatchmakerUser _self { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
