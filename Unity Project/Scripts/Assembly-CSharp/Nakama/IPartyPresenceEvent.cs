using System.Collections.Generic;

namespace Nakama
{
	public interface IPartyPresenceEvent
	{
		string PartyId { get; }

		IEnumerable<IUserPresence> Joins { get; }

		IEnumerable<IUserPresence> Leaves { get; }
	}
}
