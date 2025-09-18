using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class MatchPresenceEvent : IMatchPresenceEvent
	{
		public IEnumerable<IUserPresence> Joins => null;

		[DataMember(Name = "joins")]
		[Preserve]
		public List<UserPresence> _joins { get; set; }

		public IEnumerable<IUserPresence> Leaves => null;

		[Preserve]
		[DataMember(Name = "leaves")]
		public List<UserPresence> _leaves { get; set; }

		[DataMember(Name = "match_id")]
		[Preserve]
		public string MatchId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
