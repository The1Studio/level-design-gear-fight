using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace Voodoo.Analytics
{
	internal static class AnalyticsApi
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSendEvents_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public List<string> events;

			public string bundleId;

			public Action<bool, HttpStatusCode?> complete;

			private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

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

		private const string TAG = "Analytics - Sender";

		private static HttpClient _client;

		private static string AnalyticsGatewayUrl { get; set; }

		public static string ProxyServer { get; set; }

		private static HttpClient DefaultVoodooAnalyticsHttpClient()
		{
			return null;
		}

		internal static void SetAnalyticsGatewayUrl(string url)
		{
		}

		internal static void SetHttpClient([CanBeNull] HttpClient httpClient)
		{
		}

		[AsyncStateMachine(typeof(_003CSendEvents_003Ed__13))]
		internal static void SendEvents(List<string> events, string bundleId, Action<bool, HttpStatusCode?> complete)
		{
		}
	}
}
