using System.Collections.Generic;

namespace Nakama
{
	public interface IChannelPresenceEvent
	{
		string ChannelId { get; }

		IEnumerable<IUserPresence> Joins { get; }

		IEnumerable<IUserPresence> Leaves { get; }

		string RoomName { get; }

		string GroupId { get; }

		string UserIdOne { get; }

		string UserIdTwo { get; }
	}
}
