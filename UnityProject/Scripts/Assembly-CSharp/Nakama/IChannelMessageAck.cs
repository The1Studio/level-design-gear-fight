namespace Nakama
{
	public interface IChannelMessageAck
	{
		string ChannelId { get; }

		int Code { get; }

		string CreateTime { get; }

		string MessageId { get; }

		bool Persistent { get; }

		string UpdateTime { get; }

		string RoomName { get; }

		string GroupId { get; }

		string UserIdOne { get; }

		string UserIdTwo { get; }
	}
}
