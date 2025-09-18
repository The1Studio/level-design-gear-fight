using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.Networking;

namespace Voodoo.Live
{
	public static class ConfigLoader
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetConfigAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConfigResponse> _003C_003Et__builder;

			public int timeoutInMilliseconds;

			public string url;

			private ConfigResponse _003Cconfig_003E5__2;

			private TaskAwaiter<UnityWebRequest> _003C_003Eu__1;

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
		private struct _003CSendWebRequestAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<UnityWebRequest> _003C_003Et__builder;

			public ConfigResponse response;

			private DateTime _003CstartTime_003E5__2;

			private Task<UnityWebRequest> _003Crequest_003E5__3;

			private CancellationTokenSource _003Ccts_003E5__4;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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

		public static ConfigResponse GetConfig(string url, int timeoutInMilliseconds = -1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetConfigAsync_003Ed__1))]
		public static Task<ConfigResponse> GetConfigAsync(string url, int timeoutInMilliseconds = -1)
		{
			return null;
		}

		private static void UpdateConfigResponse(ConfigResponse config, UnityWebRequest request)
		{
		}

		private static string GetRequestError(UnityWebRequest request, double duration)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSendWebRequestAsync_003Ed__4))]
		private static Task<UnityWebRequest> SendWebRequestAsync(ConfigResponse response)
		{
			return null;
		}

		private static UnityWebRequest SendWebRequest(ConfigResponse response)
		{
			return null;
		}
	}
}
