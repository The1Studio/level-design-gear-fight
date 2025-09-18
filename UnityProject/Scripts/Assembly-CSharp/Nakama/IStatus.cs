using System.Collections.Generic;

namespace Nakama
{
	public interface IStatus
	{
		IEnumerable<IUserPresence> Presences { get; }
	}
}
