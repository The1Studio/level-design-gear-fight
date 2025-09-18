using System.Collections.Generic;

namespace Nakama
{
	public interface IMatchmakerMatched
	{
		string MatchId { get; }

		string Ticket { get; }

		string Token { get; }

		IEnumerable<IMatchmakerUser> Users { get; }

		IMatchmakerUser Self { get; }
	}
}
