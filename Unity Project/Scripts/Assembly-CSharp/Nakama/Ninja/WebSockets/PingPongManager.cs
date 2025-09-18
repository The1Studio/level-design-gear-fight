using System;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Nakama.Ninja.WebSockets.Internal;

namespace Nakama.Ninja.WebSockets
{
	public class PingPongManager : IPingPongManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPingForever_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PingPongManager _003C_003E4__this;

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
		private struct _003CSendPing_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PingPongManager _003C_003E4__this;

			public ArraySegment<byte> payload;

			public CancellationToken cancellation;

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

		private readonly WebSocketImplementation _webSocket;

		private readonly Guid _guid;

		private readonly TimeSpan _keepAliveInterval;

		private readonly Task _pingTask;

		private readonly CancellationToken _cancellationToken;

		private Stopwatch _stopwatch;

		private long _pingSentTicks;

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

		public PingPongManager(Guid guid, WebSocket webSocket, TimeSpan keepAliveInterval, CancellationToken cancellationToken)
		{
		}

		[AsyncStateMachine(typeof(_003CSendPing_003Ed__11))]
		public Task SendPing(ArraySegment<byte> payload, CancellationToken cancellation)
		{
			return null;
		}

		protected virtual void OnPong(PongEventArgs e)
		{
		}

		[AsyncStateMachine(typeof(_003CPingForever_003Ed__13))]
		private Task PingForever()
		{
			return null;
		}

		private void WebSocketImpl_Pong(object sender, PongEventArgs e)
		{
		}
	}
}
