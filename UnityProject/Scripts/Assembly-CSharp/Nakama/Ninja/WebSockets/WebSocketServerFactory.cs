using System;
using System.Diagnostics;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Nakama.Ninja.WebSockets
{
	public class WebSocketServerFactory : IWebSocketServerFactory
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAcceptWebSocketAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<WebSocket> _003C_003Et__builder;

			public WebSocketServerFactory _003C_003E4__this;

			public WebSocketHttpContext context;

			public CancellationToken token;

			private TaskAwaiter<WebSocket> _003C_003Eu__1;

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
		private struct _003CAcceptWebSocketAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<WebSocket> _003C_003Et__builder;

			public WebSocketHttpContext context;

			public WebSocketServerOptions options;

			public CancellationToken token;

			public WebSocketServerFactory _003C_003E4__this;

			private Guid _003Cguid_003E5__2;

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
		private struct _003CPerformHandshakeAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string httpHeader;

			public string subProtocol;

			public System.IO.Stream stream;

			public CancellationToken token;

			private object _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

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
		private struct _003CReadHttpHeaderFromStreamAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<WebSocketHttpContext> _003C_003Et__builder;

			public System.IO.Stream stream;

			public CancellationToken token;

			private TaskAwaiter<string> _003C_003Eu__1;

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

		private readonly Func<MemoryStream> _bufferFactory;

		private readonly IBufferPool _bufferPool;

		public WebSocketServerFactory()
		{
		}

		public WebSocketServerFactory(Func<MemoryStream> bufferFactory)
		{
		}

		[AsyncStateMachine(typeof(_003CReadHttpHeaderFromStreamAsync_003Ed__4))]
		public Task<WebSocketHttpContext> ReadHttpHeaderFromStreamAsync(System.IO.Stream stream, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAcceptWebSocketAsync_003Ed__5))]
		public Task<WebSocket> AcceptWebSocketAsync(WebSocketHttpContext context, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAcceptWebSocketAsync_003Ed__6))]
		public Task<WebSocket> AcceptWebSocketAsync(WebSocketHttpContext context, WebSocketServerOptions options, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		private static void CheckWebSocketVersion(string httpHeader)
		{
		}

		[AsyncStateMachine(typeof(_003CPerformHandshakeAsync_003Ed__8))]
		private static Task PerformHandshakeAsync(Guid guid, string httpHeader, string subProtocol, System.IO.Stream stream, CancellationToken token)
		{
			return null;
		}
	}
}
