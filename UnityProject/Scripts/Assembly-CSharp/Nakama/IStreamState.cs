namespace Nakama
{
	public interface IStreamState
	{
		IUserPresence Sender { get; }

		string State { get; }

		IStream Stream { get; }
	}
}
