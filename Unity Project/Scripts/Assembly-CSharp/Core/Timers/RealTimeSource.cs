using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Core.Timers
{
	internal class RealTimeSource : ITimeSource
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetNtpTimeAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<DateTime?> _003C_003Et__builder;

			public string ntpServer;

			private HttpClient _003ChttpClient_003E5__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestNTPTime_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public RealTimeSource _003C_003E4__this;

			private int _003Ctries_003E5__2;

			private Task<DateTime?> _003CntpRequest_003E5__3;

			private TaskAwaiter<DateTime?> _003C_003Eu__1;

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
		private struct _003CWhenAnyNotNull_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<DateTime?> _003C_003Et__builder;

			public IEnumerable<Task<DateTime?>> tasks;

			private List<Task<DateTime?>> _003CremainingTasks_003E5__2;

			private TaskAwaiter<Task<DateTime?>> _003C_003Eu__1;

			private TaskAwaiter<DateTime?> _003C_003Eu__2;

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

		private readonly string[] NTP_SERVERS;

		private DateTime _networkUtcTime;

		private float _offset;

		public DateTime UtcNow => default(DateTime);

		public bool IsInitialized { get; private set; }

		private event Action _onRealtimeLoaded
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

		[AsyncStateMachine(typeof(_003CWhenAnyNotNull_003Ed__13))]
		private Task<DateTime?> WhenAnyNotNull(IEnumerable<Task<DateTime?>> tasks)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetNtpTimeAsync_003Ed__14))]
		private Task<DateTime?> GetNtpTimeAsync(string ntpServer)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestNTPTime_003Ed__15))]
		private void RequestNTPTime()
		{
		}

		public void SubscribeOnInitFinishedEventInternal(Action onInitFinished)
		{
		}
	}
}
