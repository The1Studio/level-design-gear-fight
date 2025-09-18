using System.Collections.Generic;

namespace Nakama
{
	public interface IStreamPresenceEvent
	{
		IEnumerable<IUserPresence> Leaves { get; }

		IEnumerable<IUserPresence> Joins { get; }

		IStream Stream { get; }
	}
}
