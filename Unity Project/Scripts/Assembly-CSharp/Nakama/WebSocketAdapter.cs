using System;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Nakama.Ninja.WebSockets;

namespace Nakama
{
	public class WebSocketAdapter : ISocketAdapter, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnect_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public WebSocketAdapter _003C_003E4__this;

			public Uri uri;

			public int timeout;

			private WebSocket _003C_003E7__wrap1;

			private TaskAwaiter<WebSocket> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private struct _003CReadFrames_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ArraySegment<byte>> _003C_003Et__builder;

			public WebSocketReceiveResult result;

			public WebSocket webSocket;

			public WebSocketAdapter _003C_003E4__this;

			public byte[] buffer;

			private int _003Ccount_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private ConfiguredTaskAwaitable<WebSocketReceiveResult>.ConfiguredTaskAwaiter _003C_003Eu__2;

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
		private struct _003CReceiveLoop_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public WebSocket webSocket;

			public CancellationToken cancellationToken;

			public WebSocketAdapter _003C_003E4__this;

			private byte[] _003Cbuffer_003E5__2;

			private ConfiguredTaskAwaitable<WebSocketReceiveResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<ArraySegment<byte>> _003C_003Eu__2;

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
		private struct _003CSend_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public WebSocketAdapter _003C_003E4__this;

			public ArraySegment<byte> buffer;

			public CancellationToken cancellationToken;

			private TaskAwaiter<Task> _003C_003Eu__1;

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

		private const int MaxMessageSize = 262144;

		private readonly WebSocketClientOptions _options;

		private readonly TimeSpan _sendTimeoutSec;

		private CancellationTokenSource _cancellationSource;

		private WebSocket _webSocket;

		private Uri _uri;

		public bool IsConnected { get; private set; }

		public bool IsConnecting { get; private set; }

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

		public event Action<ArraySegment<byte>> Received
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

		public WebSocketAdapter(string cookie, int keepAliveIntervalSec = 15, int sendTimeoutSec = 10)
		{
		}

		private WebSocketAdapter(WebSocketClientOptions options, int sendTimeoutSec)
		{
		}

		public void Close()
		{
		}

		[AsyncStateMachine(typeof(_003CConnect_003Ed__29))]
		public void Connect(Uri uri, int timeout)
		{
		}

		public void Dispose()
		{
		}

		[AsyncStateMachine(typeof(_003CSend_003Ed__31))]
		public void Send(ArraySegment<byte> buffer, CancellationToken cancellationToken, bool reliable = true)
		{
		}

		public override string ToString()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReceiveLoop_003Ed__33))]
		private Task ReceiveLoop(WebSocket webSocket, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadFrames_003Ed__34))]
		private Task<ArraySegment<byte>> ReadFrames(WebSocketReceiveResult result, WebSocket webSocket, byte[] buffer)
		{
			return null;
		}
	}
}
