namespace Nakama
{
	public interface IUserPresence
	{
		bool Persistence { get; }

		string SessionId { get; }

		string Status { get; }

		string UserId { get; }
	}
}
