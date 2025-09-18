using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyPresenceEvent : IPartyPresenceEvent
	{
		[Preserve]
		[DataMember(Name = "party_id")]
		public string PartyId { get; set; }

		public IEnumerable<IUserPresence> Leaves => null;

		[Preserve]
		[DataMember(Name = "leaves")]
		public List<UserPresence> LeavesField { get; set; }

		public IEnumerable<IUserPresence> Joins => null;

		[Preserve]
		[DataMember(Name = "joins")]
		public List<UserPresence> JoinsField { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
