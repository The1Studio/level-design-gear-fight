using System.Collections.Generic;

namespace Nakama
{
	public interface IMatchPresenceEvent
	{
		IEnumerable<IUserPresence> Joins { get; }

		IEnumerable<IUserPresence> Leaves { get; }

		string MatchId { get; }
	}
}
