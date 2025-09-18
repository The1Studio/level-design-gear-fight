using System.Collections.Generic;

namespace Nakama
{
	public interface IMatch
	{
		bool Authoritative { get; }

		string Id { get; }

		string Label { get; }

		IEnumerable<IUserPresence> Presences { get; }

		int Size { get; }

		IUserPresence Self { get; }
	}
}
