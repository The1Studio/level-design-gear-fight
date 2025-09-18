using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Nakama.Ninja.WebSockets
{
	public class HttpHelper
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadHttpHeaderAsync_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public System.IO.Stream stream;

			public CancellationToken token;

			private int _003Clength_003E5__2;

			private byte[] _003Cbuffer_003E5__3;

			private int _003Coffset_003E5__4;

			private TaskAwaiter<int> _003C_003Eu__1;

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
		private struct _003CWriteHttpHeaderAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string response;

			public System.IO.Stream stream;

			public CancellationToken token;

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

		private const string HTTP_GET_HEADER_REGEX = "^GET(.*)HTTP\\/1\\.1";

		public static string CalculateWebSocketKey()
		{
			return null;
		}

		public static string ComputeSocketAcceptString(string secWebSocketKey)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadHttpHeaderAsync_003Ed__3))]
		public static Task<string> ReadHttpHeaderAsync(System.IO.Stream stream, CancellationToken token)
		{
			return null;
		}

		public static bool IsWebSocketUpgradeRequest(string header)
		{
			return false;
		}

		public static string GetPathFromHeader(string httpHeader)
		{
			return null;
		}

		public static IList<string> GetSubProtocols(string httpHeader)
		{
			return null;
		}

		public static string ReadHttpResponseCode(string response)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWriteHttpHeaderAsync_003Ed__8))]
		public static Task WriteHttpHeaderAsync(string response, System.IO.Stream stream, CancellationToken token)
		{
			return null;
		}
	}
}
