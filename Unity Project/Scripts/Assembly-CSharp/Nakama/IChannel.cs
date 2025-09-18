using System.Collections.Generic;

namespace Nakama
{
	public interface IChannel
	{
		string Id { get; }

		IEnumerable<IUserPresence> Presences { get; }

		IUserPresence Self { get; }

		string RoomName { get; }

		string GroupId { get; }

		string UserIdOne { get; }

		string UserIdTwo { get; }
	}
}
