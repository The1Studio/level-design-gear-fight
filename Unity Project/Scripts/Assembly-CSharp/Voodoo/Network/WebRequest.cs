using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace Voodoo.Network
{
	public static class WebRequest
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAsync_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<UnityWebRequest> _003C_003Et__builder;

			public string url;

			private UnityWebRequest _003Crequest_003E5__2;

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
		private struct _003CPostAsync_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<UnityWebRequest> _003C_003Et__builder;

			public string url;

			public string content;

			private UnityWebRequest _003Crequest_003E5__2;

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
		private struct _003CPutAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<UnityWebRequest> _003C_003Et__builder;

			public string url;

			public string content;

			private UnityWebRequest _003Crequest_003E5__2;

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
		private struct _003CSendAndCacheAsync_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UnityWebRequest request;

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

		private static Dictionary<int, IWebRequestHandler> idToResult;

		public static (string, string) requestHeader;

		public static void Get(string url, Action<UnityWebRequest> onSuccess = null, Action<UnityWebRequest> onError = null)
		{
		}

		[AsyncStateMachine(typeof(_003CGetAsync_003Ed__3))]
		public static Task<UnityWebRequest> GetAsync(string url)
		{
			return null;
		}

		public static void Put(string url, string content, Action<UnityWebRequest> onSuccess = null, Action<UnityWebRequest> onError = null)
		{
		}

		[AsyncStateMachine(typeof(_003CPutAsync_003Ed__5))]
		public static Task<UnityWebRequest> PutAsync(string url, string content)
		{
			return null;
		}

		public static void Post(string url, string content, Action<UnityWebRequest> onSuccess = null, Action<UnityWebRequest> onError = null)
		{
		}

		[AsyncStateMachine(typeof(_003CPostAsync_003Ed__7))]
		public static Task<UnityWebRequest> PostAsync(string url, string content)
		{
			return null;
		}

		private static void SendAndCache(UnityWebRequest request, Action<UnityWebRequest> onSuccess = null, Action<UnityWebRequest> onError = null)
		{
		}

		[AsyncStateMachine(typeof(_003CSendAndCacheAsync_003Ed__9))]
		private static Task SendAndCacheAsync(UnityWebRequest request)
		{
			return null;
		}

		private static void ApplyHeader(UnityWebRequest request)
		{
		}

		private static void OnAsyncOperationComplete(AsyncOperation operation)
		{
		}

		public static bool HadErrors(Task<UnityWebRequest> request)
		{
			return false;
		}

		public static bool HadErrors(UnityWebRequest request)
		{
			return false;
		}
	}
}
