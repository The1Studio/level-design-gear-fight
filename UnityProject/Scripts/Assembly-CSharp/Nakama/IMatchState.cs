namespace Nakama
{
	public interface IMatchState
	{
		string MatchId { get; }

		long OpCode { get; }

		byte[] State { get; }

		IUserPresence UserPresence { get; }
	}
}
