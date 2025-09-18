using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Nakama.Ninja.WebSockets
{
	public class WebSocketClientFactory : IWebSocketClientFactory
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnectAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<WebSocket> _003C_003Et__builder;

			public WebSocketClientFactory _003C_003E4__this;

			public Uri uri;

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
		private struct _003CConnectAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<WebSocket> _003C_003Et__builder;

			public Uri uri;

			public WebSocketClientFactory _003C_003E4__this;

			public WebSocketClientOptions options;

			public CancellationToken token;

			private Guid _003Cguid_003E5__2;

			private TaskAwaiter<System.IO.Stream> _003C_003Eu__1;

			private TaskAwaiter<WebSocket> _003C_003Eu__2;

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
		private struct _003CConnectAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<WebSocket> _003C_003Et__builder;

			public WebSocketClientFactory _003C_003E4__this;

			public System.IO.Stream responseStream;

			public string secWebSocketKey;

			public WebSocketClientOptions options;

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
		private struct _003CConnectAsync_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<WebSocket> _003C_003Et__builder;

			public System.IO.Stream responseStream;

			public CancellationToken token;

			public WebSocketClientFactory _003C_003E4__this;

			public Guid guid;

			public string secWebSocketKey;

			public TimeSpan keepAliveInterval;

			public string secWebSocketExtensions;

			public bool includeExceptionInCloseResponse;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetStream_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<System.IO.Stream> _003C_003Et__builder;

			public bool noDelay;

			public string host;

			public int port;

			public CancellationToken cancellationToken;

			public bool isSecure;

			public WebSocketClientFactory _003C_003E4__this;

			private TcpClient _003CtcpClient_003E5__2;

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
		private struct _003CPerformHandshake_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<WebSocket> _003C_003Et__builder;

			public WebSocketClientOptions options;

			public Uri uri;

			public System.IO.Stream stream;

			public WebSocketClientFactory _003C_003E4__this;

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

		private readonly Func<MemoryStream> _bufferFactory;

		private readonly IBufferPool _bufferPool;

		public WebSocketClientFactory()
		{
		}

		public WebSocketClientFactory(Func<MemoryStream> bufferFactory)
		{
		}

		[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__4))]
		public Task<WebSocket> ConnectAsync(Uri uri, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__5))]
		public Task<WebSocket> ConnectAsync(Uri uri, WebSocketClientOptions options, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__6))]
		public Task<WebSocket> ConnectAsync(System.IO.Stream responseStream, string secWebSocketKey, WebSocketClientOptions options, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__7))]
		private Task<WebSocket> ConnectAsync(Guid guid, System.IO.Stream responseStream, string secWebSocketKey, TimeSpan keepAliveInterval, string secWebSocketExtensions, bool includeExceptionInCloseResponse, CancellationToken token)
		{
			return null;
		}

		private string GetSubProtocolFromHeader(string response)
		{
			return null;
		}

		private void ThrowIfInvalidAcceptString(Guid guid, string response, string secWebSocketKey)
		{
		}

		private void ThrowIfInvalidResponseCode(string responseHeader)
		{
		}

		protected virtual void TlsAuthenticateAsClient(SslStream sslStream, string host)
		{
		}

		[AsyncStateMachine(typeof(_003CGetStream_003Ed__12))]
		protected virtual Task<System.IO.Stream> GetStream(Guid loggingGuid, bool isSecure, bool noDelay, string host, int port, CancellationToken cancellationToken)
		{
			return null;
		}

		private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return false;
		}

		private static string GetAdditionalHeaders(Dictionary<string, string> additionalHeaders)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CPerformHandshake_003Ed__15))]
		private Task<WebSocket> PerformHandshake(Guid guid, Uri uri, System.IO.Stream stream, WebSocketClientOptions options, CancellationToken token)
		{
			return null;
		}
	}
}
