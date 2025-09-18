using System;
using System.Diagnostics;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Nakama.Ninja.WebSockets.Internal
{
	public class WebSocketImplementation : WebSocket
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCloseAsync_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public WebSocketImplementation _003C_003E4__this;

			public WebSocketCloseStatus closeStatus;

			public string statusDescription;

			public CancellationToken cancellationToken;

			private MemoryStream _003Cstream_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CCloseOutputAsync_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public WebSocketImplementation _003C_003E4__this;

			public WebSocketCloseStatus closeStatus;

			public string statusDescription;

			public CancellationToken cancellationToken;

			private MemoryStream _003Cstream_003E5__2;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

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
		private struct _003CCloseOutputAutoTimeoutAsync_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public WebSocketImplementation _003C_003E4__this;

			public string statusDescription;

			public Exception ex;

			public WebSocketCloseStatus closeStatus;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CReceiveAsync_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<WebSocketReceiveResult> _003C_003Et__builder;

			public WebSocketImplementation _003C_003E4__this;

			public CancellationToken cancellationToken;

			public ArraySegment<byte> buffer;

			private object _003C_003E7__wrap1;

			private CancellationTokenSource _003ClinkedCts_003E5__3;

			private WebSocketFrame _003Cframe_003E5__4;

			private object _003C_003E7__wrap4;

			private int _003C_003E7__wrap5;

			private TaskAwaiter<WebSocketFrame> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private Exception _003Cex_003E5__7;

			private TaskAwaiter<WebSocketReceiveResult> _003C_003Eu__3;

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
		private struct _003CRespondToCloseFrame_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<WebSocketReceiveResult> _003C_003Et__builder;

			public WebSocketImplementation _003C_003E4__this;

			public WebSocketFrame frame;

			public CancellationToken token;

			private MemoryStream _003Cstream_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CSendAsync_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public WebSocketImplementation _003C_003E4__this;

			public WebSocketMessageType messageType;

			public ArraySegment<byte> buffer;

			public bool endOfMessage;

			public CancellationToken cancellationToken;

			private MemoryStream _003Cstream_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CSendPingAsync_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ArraySegment<byte> payload;

			public WebSocketImplementation _003C_003E4__this;

			public CancellationToken cancellationToken;

			private MemoryStream _003Cstream_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CSendPongAsync_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ArraySegment<byte> payload;

			public WebSocketImplementation _003C_003E4__this;

			public CancellationToken cancellationToken;

			private Exception _003Cex_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private object _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private MemoryStream _003Cstream_003E5__5;

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
		private struct _003CWriteStreamToNetwork_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public WebSocketImplementation _003C_003E4__this;

			public MemoryStream stream;

			public CancellationToken cancellationToken;

			private ArraySegment<byte> _003Cbuffer_003E5__2;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

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

		private readonly Guid _guid;

		private readonly Func<MemoryStream> _recycledStreamFactory;

		private readonly System.IO.Stream _stream;

		private readonly bool _includeExceptionInCloseResponse;

		private readonly bool _isClient;

		private readonly string _subProtocol;

		private CancellationTokenSource _internalReadCts;

		private WebSocketState _state;

		private readonly IPingPongManager _pingPongManager;

		private bool _isContinuationFrame;

		private WebSocketMessageType _continuationFrameMessageType;

		private readonly bool _usePerMessageDeflate;

		private bool _tryGetBufferFailureLogged;

		private const int MAX_PING_PONG_PAYLOAD_LEN = 125;

		private WebSocketCloseStatus? _closeStatus;

		private string _closeStatusDescription;

		private readonly SemaphoreSlim _semaphore;

		public override WebSocketCloseStatus? CloseStatus => null;

		public override string CloseStatusDescription => null;

		public override WebSocketState State => default(WebSocketState);

		public override string SubProtocol => null;

		public TimeSpan KeepAliveInterval { get; private set; }

		public event EventHandler<PongEventArgs> Pong
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

		internal WebSocketImplementation(Guid guid, Func<MemoryStream> recycledStreamFactory, System.IO.Stream stream, TimeSpan keepAliveInterval, string secWebSocketExtensions, bool includeExceptionInCloseResponse, bool isClient, string subProtocol)
		{
		}

		[AsyncStateMachine(typeof(_003CReceiveAsync_003Ed__33))]
		public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSendAsync_003Ed__34))]
		public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSendPingAsync_003Ed__35))]
		public Task SendPingAsync(ArraySegment<byte> payload, CancellationToken cancellationToken)
		{
			return null;
		}

		public override void Abort()
		{
		}

		[AsyncStateMachine(typeof(_003CCloseAsync_003Ed__37))]
		public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCloseOutputAsync_003Ed__38))]
		public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			return null;
		}

		public override void Dispose()
		{
		}

		protected virtual void OnPong(PongEventArgs e)
		{
		}

		private ArraySegment<byte> BuildClosePayload(WebSocketCloseStatus closeStatus, string statusDescription)
		{
			return default(ArraySegment<byte>);
		}

		[AsyncStateMachine(typeof(_003CSendPongAsync_003Ed__42))]
		private Task SendPongAsync(ArraySegment<byte> payload, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRespondToCloseFrame_003Ed__43))]
		private Task<WebSocketReceiveResult> RespondToCloseFrame(WebSocketFrame frame, ArraySegment<byte> buffer, CancellationToken token)
		{
			return null;
		}

		private ArraySegment<byte> GetBuffer(MemoryStream stream)
		{
			return default(ArraySegment<byte>);
		}

		[AsyncStateMachine(typeof(_003CWriteStreamToNetwork_003Ed__45))]
		private Task WriteStreamToNetwork(MemoryStream stream, CancellationToken cancellationToken)
		{
			return null;
		}

		private WebSocketOpCode GetOppCode(WebSocketMessageType messageType)
		{
			return default(WebSocketOpCode);
		}

		[AsyncStateMachine(typeof(_003CCloseOutputAutoTimeoutAsync_003Ed__47))]
		private Task CloseOutputAutoTimeoutAsync(WebSocketCloseStatus closeStatus, string statusDescription, Exception ex)
		{
			return null;
		}
	}
}
