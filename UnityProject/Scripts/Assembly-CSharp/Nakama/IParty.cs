using System.Collections.Generic;

namespace Nakama
{
	public interface IParty
	{
		string Id { get; }

		bool Open { get; }

		int MaxSize { get; }

		IUserPresence Self { get; }

		IUserPresence Leader { get; }

		IEnumerable<IUserPresence> Presences { get; }
	}
}
