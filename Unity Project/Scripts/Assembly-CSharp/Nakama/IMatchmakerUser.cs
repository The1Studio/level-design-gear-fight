using System.Collections.Generic;

namespace Nakama
{
	public interface IMatchmakerUser
	{
		IDictionary<string, double> NumericProperties { get; }

		IUserPresence Presence { get; }

		IDictionary<string, string> StringProperties { get; }
	}
}
