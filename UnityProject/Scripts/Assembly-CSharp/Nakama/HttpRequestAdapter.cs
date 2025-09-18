using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Nakama
{
	public class HttpRequestAdapter : IHttpAdapter
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSendAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public Uri uri;

			public string method;

			public IDictionary<string, string> headers;

			public byte[] body;

			public int timeout;

			public HttpRequestAdapter _003C_003E4__this;

			private HttpResponseMessage _003Cresponse_003E5__2;

			private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

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

		private const int GrpcUnauthenticatedCode = 16;

		private readonly INakamaCallbacks _callbacks;

		private readonly HttpClient _httpClient;

		public ILogger Logger { get; set; }

		public CookieContainer CookieContainer { get; }

		private HttpRequestAdapter(HttpClient httpClient, CookieContainer cookieContainer, INakamaCallbacks callbacks)
		{
		}

		[AsyncStateMachine(typeof(_003CSendAsync_003Ed__11))]
		public Task<string> SendAsync(string method, Uri uri, IDictionary<string, string> headers, byte[] body, int timeout)
		{
			return null;
		}

		public static IHttpAdapter WithGzip(INakamaCallbacks callbacks, bool decompression = false, bool compression = false)
		{
			return null;
		}
	}
}
