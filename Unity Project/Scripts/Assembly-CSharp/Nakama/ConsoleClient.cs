using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Nakama.Console;

namespace Nakama
{
	public class ConsoleClient
	{
		public class ConsoleToken
		{
			public string Token { get; }

			public ConsoleToken(string token)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticate_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleToken> _003C_003Et__builder;

			public ConsoleClient _003C_003E4__this;

			public string username;

			public string password;

			private TaskAwaiter<ConsoleConsoleSession> _003C_003Eu__1;

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
		private struct _003CFetchRandomStorageData_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleStorageDataResponse> _003C_003Et__builder;

			public ConsoleClient _003C_003E4__this;

			public ConsoleToken token;

			public string collection;

			public string key;

			public int numObjects;

			public int minUpdatedTimeEpochSeconds;

			private TaskAwaiter<ConsoleStorageDataResponse> _003C_003Eu__1;

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

		private readonly Nakama.Console.ApiClient _consoleClient;

		public ConsoleClient(string scheme, string host, int port, string serverKey, INakamaCallbacks callbacks, int timeout = 15)
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticate_003Ed__3))]
		public Task<ConsoleToken> Authenticate(string username, string password)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFetchRandomStorageData_003Ed__4))]
		public Task<ConsoleStorageDataResponse> FetchRandomStorageData(ConsoleToken token, string collection, string key, int numObjects = 10, int minUpdatedTimeEpochSeconds = 0)
		{
			return null;
		}
	}
}
