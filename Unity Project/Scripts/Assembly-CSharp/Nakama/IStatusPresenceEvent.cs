using System.Collections.Generic;

namespace Nakama
{
	public interface IStatusPresenceEvent
	{
		IEnumerable<IUserPresence> Leaves { get; }

		IEnumerable<IUserPresence> Joins { get; }
	}
}
