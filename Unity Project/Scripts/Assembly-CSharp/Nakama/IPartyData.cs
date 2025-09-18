namespace Nakama
{
	public interface IPartyData
	{
		string PartyId { get; }

		IUserPresence Presence { get; }

		long OpCode { get; }

		byte[] Data { get; }
	}
}
