using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nakama
{
	public interface ISocket : IDisposable
	{
		bool IsConnected { get; }

		bool IsConnecting { get; }

		event Action Closed;

		event Action Connected;

		event Action<ApiChannelMessage> ReceivedChannelMessage;

		event Action<IChannelPresenceEvent> ReceivedChannelPresence;

		event Action<Exception> ReceivedError;

		event Action<IMatchmakerMatched> ReceivedMatchmakerMatched;

		event Action<IMatchState> ReceivedMatchState;

		event Action<IMatchPresenceEvent> ReceivedMatchPresence;

		event Action<ApiNotification> ReceivedNotification;

		event Action<IParty> ReceivedParty;

		event Action<IPartyClose> ReceivedPartyClose;

		event Action<IPartyData> ReceivedPartyData;

		event Action<IPartyJoinRequest> ReceivedPartyJoinRequest;

		event Action<IPartyLeader> ReceivedPartyLeader;

		event Action<IPartyMatchmakerTicket> ReceivedPartyMatchmakerTicket;

		event Action<IPartyPresenceEvent> ReceivedPartyPresence;

		event Action<StatusPresenceEvent> ReceivedStatusPresence;

		event Action<StreamPresenceEvent> ReceivedStreamPresence;

		event Action<IStreamState> ReceivedStreamState;

		Task AcceptPartyMemberAsync(string partyId, IUserPresence presence);

		Task<IMatchmakerTicket> AddMatchmakerAsync(string query = "*", int minCount = 2, int maxCount = 8, Dictionary<string, string> stringProperties = null, Dictionary<string, double> numericProperties = null);

		Task AddMatchmakerPartyAsync(string partyId, string query, int minCount, int maxCount, Dictionary<string, string> stringProperties = null, Dictionary<string, double> numericProperties = null);

		Task ClosePartyAsync(string partyId);

		Task CloseAsync();

		Task ConnectAsync(ISession session, bool appearOnline = false, int connectTimeout = 30);

		Task<IMatch> CreateMatchAsync();

		Task<IParty> CreatePartyAsync(bool open, int maxSize);

		Task<IStatus> FollowUsersAsync(IEnumerable<ApiUser> users);

		Task<IStatus> FollowUsersAsync(IEnumerable<string> userIDs);

		Task<IChannel> JoinChatAsync(string target, ChannelType type, bool persistence = false, bool hidden = false);

		Task JoinPartyAsync(string partyId);

		Task<IMatch> JoinMatchAsync(IMatchmakerMatched matched);

		Task<IMatch> JoinMatchAsync(string matchId, IDictionary<string, string> metadata = null);

		Task LeaveChatAsync(IChannel channel);

		Task LeaveChatAsync(string channelId);

		Task LeaveMatchAsync(IMatch match);

		Task LeaveMatchAsync(string matchId);

		Task LeavePartyAsync(string partyId);

		Task<IPartyJoinRequest> ListPartyJoinRequestsAsync(string partyId);

		Task PromotePartyMember(string partyId, IUserPresence partyMember);

		Task<IChannelMessageAck> RemoveChatMessageAsync(IChannel channel, string messageId);

		Task<IChannelMessageAck> RemoveChatMessageAsync(string channelId, string messageId);

		Task RemoveMatchmakerAsync(IMatchmakerTicket ticket);

		Task RemoveMatchmakerAsync(string ticket);

		Task RemoveMatchmakerPartyAsync(string partyId, string ticket);

		Task RemovePartyMemberAsync(string partyId, IUserPresence presence);

		Task SendMatchStateAsync(string matchId, long opCode, string state, IEnumerable<IUserPresence> presences = null);

		Task SendMatchStateAsync(string matchId, long opCode, ArraySegment<byte> state, IEnumerable<IUserPresence> presences = null);

		Task SendMatchStateAsync(string matchId, long opCode, byte[] state, IEnumerable<IUserPresence> presences = null);

		Task SendPartyDataAsync(string partyId, long opCode, ArraySegment<byte> data);

		Task SendPartyDataAsync(string partyId, long opCode, string data);

		Task SendPartyDataAsync(string partyId, long opCode, byte[] data);

		Task UnfollowUsersAsync(IEnumerable<ApiUser> users);

		Task UnfollowUsersAsync(IEnumerable<string> userIDs);

		Task<IChannelMessageAck> UpdateChatMessageAsync(IChannel channel, string messageId, string content);

		Task<IChannelMessageAck> UpdateChatMessageAsync(string channelId, string messageId, string content);

		Task UpdateStatusAsync(string status);

		Task<IChannelMessageAck> WriteChatMessageAsync(IChannel channel, string content);

		Task<IChannelMessageAck> WriteChatMessageAsync(string channelId, string content);
	}
}
