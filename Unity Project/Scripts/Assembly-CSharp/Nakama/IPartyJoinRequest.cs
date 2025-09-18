using System.Collections.Generic;

namespace Nakama
{
	public interface IPartyJoinRequest
	{
		string PartyId { get; }

		IEnumerable<IUserPresence> Presences { get; }
	}
}
