using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NakamaHttp;

namespace Nakama
{
	public class Socket : ISocket, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddMatchmakerAsync_003Ed__72 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IMatchmakerTicket> _003C_003Et__builder;

			public string query;

			public int minCount;

			public int maxCount;

			public Dictionary<string, string> stringProperties;

			public Dictionary<string, double> numericProperties;

			public Socket _003C_003E4__this;

			private TaskAwaiter<WebSocketMessageEnvelope> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateMatchAsync_003Ed__77 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IMatch> _003C_003Et__builder;

			public Socket _003C_003E4__this;

			private TaskAwaiter<WebSocketMessageEnvelope> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreatePartyAsync_003Ed__78 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IParty> _003C_003Et__builder;

			public bool open;

			public int maxSize;

			public Socket _003C_003E4__this;

			private TaskAwaiter<WebSocketMessageEnvelope> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFollowUsersAsync_003Ed__81 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IStatus> _003C_003Et__builder;

			public IEnumerable<string> userIDs;

			public Socket _003C_003E4__this;

			private TaskAwaiter<WebSocketMessageEnvelope> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CJoinChatAsync_003Ed__82 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IChannel> _003C_003Et__builder;

			public bool hidden;

			public bool persistence;

			public string target;

			public ChannelType type;

			public Socket _003C_003E4__this;

			private TaskAwaiter<WebSocketMessageEnvelope> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CJoinMatchAsync_003Ed__83 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IMatch> _003C_003Et__builder;

			public IMatchmakerMatched matched;

			public Socket _003C_003E4__this;

			private TaskAwaiter<WebSocketMessageEnvelope> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CJoinMatchAsync_003Ed__84 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IMatch> _003C_003Et__builder;

			public string matchId;

			public IDictionary<string, string> metadata;

			public Socket _003C_003E4__this;

			private TaskAwaiter<WebSocketMessageEnvelope> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CListPartyJoinRequestsAsync_003Ed__91 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IPartyJoinRequest> _003C_003Et__builder;

			public string partyId;

			public Socket _003C_003E4__this;

			private TaskAwaiter<WebSocketMessageEnvelope> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRemoveChatMessageAsync_003Ed__94 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IChannelMessageAck> _003C_003Et__builder;

			public string channelId;

			public string messageId;

			public Socket _003C_003E4__this;

			private TaskAwaiter<WebSocketMessageEnvelope> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateChatMessageAsync_003Ed__109 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IChannelMessageAck> _003C_003Et__builder;

			public string channelId;

			public string messageId;

			public string content;

			public Socket _003C_003E4__this;

			private TaskAwaiter<WebSocketMessageEnvelope> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWriteChatMessageAsync_003Ed__112 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IChannelMessageAck> _003C_003Et__builder;

			public string channelId;

			public string content;

			public Socket _003C_003E4__this;

			private TaskAwaiter<WebSocketMessageEnvelope> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private static int _cid;

		private readonly ISocketAdapter _adapter;

		private readonly Uri _baseUri;

		private readonly Dictionary<string, TaskCompletionSource<WebSocketMessageEnvelope>> _responses;

		private object _lockObj;

		public bool IsConnected => false;

		public bool IsConnecting => false;

		public ILogger Logger { get; set; }

		public event Action Closed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action Connected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<ApiChannelMessage> ReceivedChannelMessage
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IChannelPresenceEvent> ReceivedChannelPresence
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<Exception> ReceivedError
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IMatchmakerMatched> ReceivedMatchmakerMatched
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IMatchState> ReceivedMatchState
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IMatchPresenceEvent> ReceivedMatchPresence
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<ApiNotification> ReceivedNotification
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<StatusPresenceEvent> ReceivedStatusPresence
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<StreamPresenceEvent> ReceivedStreamPresence
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IStreamState> ReceivedStreamState
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IParty> ReceivedParty
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IPartyClose> ReceivedPartyClose
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IPartyData> ReceivedPartyData
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IPartyJoinRequest> ReceivedPartyJoinRequest
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IPartyLeader> ReceivedPartyLeader
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IPartyPresenceEvent> ReceivedPartyPresence
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IPartyMatchmakerTicket> ReceivedPartyMatchmakerTicket
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public Socket(string scheme, string host, int port, ISocketAdapter adapter)
		{
		}

		public Task AcceptPartyMemberAsync(string partyId, IUserPresence presence)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAddMatchmakerAsync_003Ed__72))]
		public Task<IMatchmakerTicket> AddMatchmakerAsync(string query = "*", int minCount = 2, int maxCount = 8, Dictionary<string, string> stringProperties = null, Dictionary<string, double> numericProperties = null)
		{
			return null;
		}

		public Task AddMatchmakerPartyAsync(string partyId, string query, int minCount, int maxCount, Dictionary<string, string> stringProperties = null, Dictionary<string, double> numericProperties = null)
		{
			return null;
		}

		public Task CloseAsync()
		{
			return null;
		}

		public Task ConnectAsync(ISession session, bool appearOnline = false, int connectTimeoutSec = 30)
		{
			return null;
		}

		public Task ClosePartyAsync(string partyId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateMatchAsync_003Ed__77))]
		public Task<IMatch> CreateMatchAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreatePartyAsync_003Ed__78))]
		public Task<IParty> CreatePartyAsync(bool open, int maxSize)
		{
			return null;
		}

		public void Dispose()
		{
		}

		public Task<IStatus> FollowUsersAsync(IEnumerable<ApiUser> users)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFollowUsersAsync_003Ed__81))]
		public Task<IStatus> FollowUsersAsync(IEnumerable<string> userIDs)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CJoinChatAsync_003Ed__82))]
		public Task<IChannel> JoinChatAsync(string target, ChannelType type, bool persistence = false, bool hidden = false)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CJoinMatchAsync_003Ed__83))]
		public Task<IMatch> JoinMatchAsync(IMatchmakerMatched matched)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CJoinMatchAsync_003Ed__84))]
		public Task<IMatch> JoinMatchAsync(string matchId, IDictionary<string, string> metadata = null)
		{
			return null;
		}

		public Task JoinPartyAsync(string partyId)
		{
			return null;
		}

		public Task LeaveChatAsync(IChannel channel)
		{
			return null;
		}

		public Task LeaveChatAsync(string channelId)
		{
			return null;
		}

		public Task LeaveMatchAsync(IMatch match)
		{
			return null;
		}

		public Task LeaveMatchAsync(string matchId)
		{
			return null;
		}

		public Task LeavePartyAsync(string partyId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CListPartyJoinRequestsAsync_003Ed__91))]
		public Task<IPartyJoinRequest> ListPartyJoinRequestsAsync(string partyId)
		{
			return null;
		}

		public Task PromotePartyMember(string partyId, IUserPresence partyMember)
		{
			return null;
		}

		public Task<IChannelMessageAck> RemoveChatMessageAsync(IChannel channel, string messageId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRemoveChatMessageAsync_003Ed__94))]
		public Task<IChannelMessageAck> RemoveChatMessageAsync(string channelId, string messageId)
		{
			return null;
		}

		public Task RemoveMatchmakerAsync(IMatchmakerTicket ticket)
		{
			return null;
		}

		public Task RemoveMatchmakerAsync(string ticket)
		{
			return null;
		}

		public Task RemoveMatchmakerPartyAsync(string partyId, string ticket)
		{
			return null;
		}

		public Task RemovePartyMemberAsync(string partyId, IUserPresence presence)
		{
			return null;
		}

		public Task SendMatchStateAsync(string matchId, long opCode, ArraySegment<byte> state, IEnumerable<IUserPresence> presences = null)
		{
			return null;
		}

		public Task SendMatchStateAsync(string matchId, long opCode, string state, IEnumerable<IUserPresence> presences = null)
		{
			return null;
		}

		public Task SendMatchStateAsync(string matchId, long opCode, byte[] state, IEnumerable<IUserPresence> presences = null)
		{
			return null;
		}

		public Task SendPartyDataAsync(string partyId, long opCode, ArraySegment<byte> data)
		{
			return null;
		}

		public Task SendPartyDataAsync(string partyId, long opCode, string data)
		{
			return null;
		}

		public Task SendPartyDataAsync(string partyId, long opCode, byte[] data)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public Task UnfollowUsersAsync(IEnumerable<ApiUser> users)
		{
			return null;
		}

		public Task UnfollowUsersAsync(IEnumerable<string> userIDs)
		{
			return null;
		}

		public Task<IChannelMessageAck> UpdateChatMessageAsync(IChannel channel, string messageId, string content)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdateChatMessageAsync_003Ed__109))]
		public Task<IChannelMessageAck> UpdateChatMessageAsync(string channelId, string messageId, string content)
		{
			return null;
		}

		public Task UpdateStatusAsync(string status)
		{
			return null;
		}

		public Task<IChannelMessageAck> WriteChatMessageAsync(IChannel channel, string content)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWriteChatMessageAsync_003Ed__112))]
		public Task<IChannelMessageAck> WriteChatMessageAsync(string channelId, string content)
		{
			return null;
		}

		public static ISocket From(NakamaHttpClient client)
		{
			return null;
		}

		public static ISocket ForTesting(NakamaHttpClient client, bool mustHaveLoadBalancerCookies)
		{
			return null;
		}

		private static ISocket From(NakamaHttpClient client, ISocketAdapter adapter)
		{
			return null;
		}

		private void ReceivedMessage(ArraySegment<byte> buffer)
		{
		}

		private Task<WebSocketMessageEnvelope> SendAsync(WebSocketMessageEnvelope envelope)
		{
			return null;
		}

		private static List<UserPresence> BuildPresenceList(IEnumerable<IUserPresence> presences)
		{
			return null;
		}
	}
}
