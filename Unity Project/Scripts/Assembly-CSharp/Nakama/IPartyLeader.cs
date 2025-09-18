namespace Nakama
{
	public interface IPartyLeader
	{
		string PartyId { get; }

		IUserPresence Presence { get; }
	}
}
