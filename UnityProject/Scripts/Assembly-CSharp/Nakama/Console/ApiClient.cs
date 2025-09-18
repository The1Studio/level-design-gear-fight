using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Nakama.Console
{
	public class ApiClient
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConsoleAddUserAsync_003Ed__64 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ConsoleAddUserRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminAddUpdateCheckRuleAsync_003Ed__60 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ApiUpdateCheckRuleRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminClearUserStorageAsync_003Ed__52 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string userId;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminDeleteLiveOpAsync_003Ed__72 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleAdminGetLiveOpsResponse> _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminEditLiveOpRoundAsync_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleAdminGetLiveOpsResponse> _003C_003Et__builder;

			public ConsoleEditLiveOpRoundRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminGetAllUpdateCheckRulesAsync_003Ed__59 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleGetAllUpdateCheckRulesResponse> _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminGetLiveOpTypeDefaultDataAsync_003Ed__71 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleLiveOpTypeDefaultDataResponse> _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminGetLiveOpsAsync_003Ed__69 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleAdminGetLiveOpsResponse> _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminGiftsAddAsync_003Ed__68 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleAdminGiftsAddResponse> _003C_003Et__builder;

			public ConsoleAdminGiftsAddRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminGiftsGetAsync_003Ed__67 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleAdminGiftsGetResponse> _003C_003Et__builder;

			public ConsoleAdminGiftsGetRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminRemoveUpdateCheckRuleAsync_003Ed__61 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ApiUpdateCheckRuleRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminResetFeatureDefaultDataAsync_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleLiveOpTypeDefaultDataResponse> _003C_003Et__builder;

			public ConsoleResetFeatureDefaultDataRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminScheduleLiveOpAsync_003Ed__70 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleAdminGetLiveOpsResponse> _003C_003Et__builder;

			public ConsoleAdminScheduledLiveOp body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAdminUpdateFeatureDefaultDataAsync_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleLiveOpTypeDefaultDataResponse> _003C_003Et__builder;

			public ConsoleUpdateFeatureDefaultDataRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleAuthenticateAsync_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleConsoleSession> _003C_003Et__builder;

			public ConsoleAuthenticateRequest body;

			public ApiClient _003C_003E4__this;

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
		private struct _003CConsoleAuthenticateOktaAsync_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleConsoleSession> _003C_003Et__builder;

			public ConsoleOktaTokenRequest body;

			public ApiClient _003C_003E4__this;

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
		private struct _003CConsoleBanAccountAsync_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleCallApiEndpointAsync_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleCallApiEndpointResponse> _003C_003Et__builder;

			public string rpcMethod;

			public ConsoleCallApiEndpointRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleCreateLeaderboardAsync_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<NakamaconsoleLeaderboard> _003C_003Et__builder;

			public ConsoleCreateLeaderboardRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleDeleteAccountAsync_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleDeleteAccountsAsync_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleDeleteFriendAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public string friendId;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleDeleteGuildUserAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public string guildId;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleDeleteLeaderboardAsync_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ConsoleDeleteLeaderboardRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleDeleteLeaderboardRecordAsync_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public string ownerId;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleDeleteStorageAsync_003Ed__50 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleDeleteStorageObject2Async_003Ed__58 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string collection;

			public string key;

			public string userId;

			public string version;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleDeleteStorageObjectAsync_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string collection;

			public string key;

			public string userId;

			public string version;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleDeleteUserAsync_003Ed__62 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string username;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleDeleteWalletLedgerAsync_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public string walletId;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleExportAccountAsync_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleAccountExport> _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleFetchStorageDataAsync_003Ed__54 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleStorageDataResponse> _003C_003Et__builder;

			public ConsoleStorageDataRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGdprAccessRequestAsync_003Ed__65 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleGdprAccessRequestResponse> _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGdprDeleteRequestAsync_003Ed__66 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleGdprDeleteRequestResponse> _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGetAccountAsync_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<NakamaconsoleAccount> _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGetConfigAsync_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleConfig> _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGetConsoleUIConfigAsync_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleConsoleUIConfig> _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGetDeepLinkUrlAsync_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleGetDeepLinkUrlResponse> _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGetFriendsAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ApiFriendList> _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGetLeaderboardAsync_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<NakamaconsoleLeaderboard> _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGetMatchStateAsync_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleMatchState> _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGetStatusAsync_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleStatusList> _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGetStorageAsync_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ApiStorageObject> _003C_003Et__builder;

			public string collection;

			public string key;

			public string userId;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGetUserGuildAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleGetUserGuildResponse> _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleGetWalletLedgerAsync_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleWalletLedgerList> _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleListAccountsAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleAccountList> _003C_003Et__builder;

			public string filter;

			public string cursor;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleListApiEndpointsAsync_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleApiEndpointList> _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleListLeaderboardRecordsAsync_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ApiLeaderboardRecordList> _003C_003Et__builder;

			public string leaderboardId;

			public IEnumerable<string> ownerIds;

			public int? limit;

			public string cursor;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleListLeaderboardsAsync_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<NakamaconsoleLeaderboardList> _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleListMatchesAsync_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ApiMatchList> _003C_003Et__builder;

			public int? limit;

			public bool? authoritative;

			public string label;

			public int? minSize;

			public int? maxSize;

			public string query;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleListPurchasesAsync_003Ed__48 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ApiPurchaseList> _003C_003Et__builder;

			public string userId;

			public int? limit;

			public string cursor;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleListStorageAsync_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleStorageList> _003C_003Et__builder;

			public string userId;

			public string key;

			public string collection;

			public string cursor;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleListStorageCollectionsAsync_003Ed__53 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleStorageCollectionsList> _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleListUsersAsync_003Ed__63 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ConsoleUserList> _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleStopHammertimeAsync_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleUnbanAccountAsync_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleUnlinkAppleAsync_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleUnlinkDeviceAsync_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public ConsoleUnlinkDeviceRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleUnlinkEmailAsync_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleUnlinkFacebookAsync_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleUnlinkFacebookInstantGameAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleUnlinkGameCenterAsync_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleUnlinkGoogleAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleUnlinkVoodooIdAsync_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public ConsoleUnlinkVoodooIdRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleUpdateAccountAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string id;

			public NakamaconsoleUpdateAccountRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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
		private struct _003CConsoleWriteStorageObjectAsync_003Ed__57 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ApiStorageObjectAck> _003C_003Et__builder;

			public string collection;

			public string key;

			public string userId;

			public ConsoleWriteStorageObjectRequest body;

			public ApiClient _003C_003E4__this;

			public string bearerToken;

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

		public readonly IHttpAdapter HttpAdapter;

		private readonly Uri _baseUri;

		public int Timeout { get; set; }

		public ApiClient(Uri baseUri, IHttpAdapter httpAdapter, int timeout = 10)
		{
		}

		[AsyncStateMachine(typeof(_003CConsoleDeleteAccountsAsync_003Ed__7))]
		public Task ConsoleDeleteAccountsAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleListAccountsAsync_003Ed__8))]
		public Task<ConsoleAccountList> ConsoleListAccountsAsync(string bearerToken, string filter, string cursor)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleDeleteAccountAsync_003Ed__9))]
		public Task ConsoleDeleteAccountAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGetAccountAsync_003Ed__10))]
		public Task<NakamaconsoleAccount> ConsoleGetAccountAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleUpdateAccountAsync_003Ed__11))]
		public Task ConsoleUpdateAccountAsync(string bearerToken, string id, NakamaconsoleUpdateAccountRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleBanAccountAsync_003Ed__12))]
		public Task ConsoleBanAccountAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleExportAccountAsync_003Ed__13))]
		public Task<ConsoleAccountExport> ConsoleExportAccountAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGetFriendsAsync_003Ed__14))]
		public Task<ApiFriendList> ConsoleGetFriendsAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleDeleteFriendAsync_003Ed__15))]
		public Task ConsoleDeleteFriendAsync(string bearerToken, string id, string friendId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGetUserGuildAsync_003Ed__16))]
		public Task<ConsoleGetUserGuildResponse> ConsoleGetUserGuildAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleDeleteGuildUserAsync_003Ed__17))]
		public Task ConsoleDeleteGuildUserAsync(string bearerToken, string id, string guildId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleUnbanAccountAsync_003Ed__18))]
		public Task ConsoleUnbanAccountAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleUnlinkAppleAsync_003Ed__19))]
		public Task ConsoleUnlinkAppleAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleUnlinkDeviceAsync_003Ed__20))]
		public Task ConsoleUnlinkDeviceAsync(string bearerToken, string id, ConsoleUnlinkDeviceRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleUnlinkEmailAsync_003Ed__21))]
		public Task ConsoleUnlinkEmailAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleUnlinkFacebookAsync_003Ed__22))]
		public Task ConsoleUnlinkFacebookAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleUnlinkFacebookInstantGameAsync_003Ed__23))]
		public Task ConsoleUnlinkFacebookInstantGameAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleUnlinkGameCenterAsync_003Ed__24))]
		public Task ConsoleUnlinkGameCenterAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleUnlinkGoogleAsync_003Ed__25))]
		public Task ConsoleUnlinkGoogleAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleUnlinkVoodooIdAsync_003Ed__26))]
		public Task ConsoleUnlinkVoodooIdAsync(string bearerToken, string id, ConsoleUnlinkVoodooIdRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGetWalletLedgerAsync_003Ed__27))]
		public Task<ConsoleWalletLedgerList> ConsoleGetWalletLedgerAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleDeleteWalletLedgerAsync_003Ed__28))]
		public Task ConsoleDeleteWalletLedgerAsync(string bearerToken, string id, string walletId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleListApiEndpointsAsync_003Ed__29))]
		public Task<ConsoleApiEndpointList> ConsoleListApiEndpointsAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleCallApiEndpointAsync_003Ed__30))]
		public Task<ConsoleCallApiEndpointResponse> ConsoleCallApiEndpointAsync(string bearerToken, string rpcMethod, ConsoleCallApiEndpointRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAuthenticateAsync_003Ed__31))]
		public Task<ConsoleConsoleSession> ConsoleAuthenticateAsync(ConsoleAuthenticateRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAuthenticateOktaAsync_003Ed__32))]
		public Task<ConsoleConsoleSession> ConsoleAuthenticateOktaAsync(ConsoleOktaTokenRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGetConfigAsync_003Ed__33))]
		public Task<ConsoleConfig> ConsoleGetConfigAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGetConsoleUIConfigAsync_003Ed__34))]
		public Task<ConsoleConsoleUIConfig> ConsoleGetConsoleUIConfigAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGetDeepLinkUrlAsync_003Ed__35))]
		public Task<ConsoleGetDeepLinkUrlResponse> ConsoleGetDeepLinkUrlAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleStopHammertimeAsync_003Ed__36))]
		public Task ConsoleStopHammertimeAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleListLeaderboardsAsync_003Ed__37))]
		public Task<NakamaconsoleLeaderboardList> ConsoleListLeaderboardsAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleCreateLeaderboardAsync_003Ed__38))]
		public Task<NakamaconsoleLeaderboard> ConsoleCreateLeaderboardAsync(string bearerToken, ConsoleCreateLeaderboardRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleDeleteLeaderboardAsync_003Ed__39))]
		public Task ConsoleDeleteLeaderboardAsync(string bearerToken, ConsoleDeleteLeaderboardRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGetLeaderboardAsync_003Ed__40))]
		public Task<NakamaconsoleLeaderboard> ConsoleGetLeaderboardAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleDeleteLeaderboardRecordAsync_003Ed__41))]
		public Task ConsoleDeleteLeaderboardRecordAsync(string bearerToken, string id, string ownerId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleListLeaderboardRecordsAsync_003Ed__42))]
		public Task<ApiLeaderboardRecordList> ConsoleListLeaderboardRecordsAsync(string bearerToken, string leaderboardId, IEnumerable<string> ownerIds, int? limit, string cursor)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminResetFeatureDefaultDataAsync_003Ed__43))]
		public Task<ConsoleLiveOpTypeDefaultDataResponse> ConsoleAdminResetFeatureDefaultDataAsync(string bearerToken, ConsoleResetFeatureDefaultDataRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminUpdateFeatureDefaultDataAsync_003Ed__44))]
		public Task<ConsoleLiveOpTypeDefaultDataResponse> ConsoleAdminUpdateFeatureDefaultDataAsync(string bearerToken, ConsoleUpdateFeatureDefaultDataRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminEditLiveOpRoundAsync_003Ed__45))]
		public Task<ConsoleAdminGetLiveOpsResponse> ConsoleAdminEditLiveOpRoundAsync(string bearerToken, ConsoleEditLiveOpRoundRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleListMatchesAsync_003Ed__46))]
		public Task<ApiMatchList> ConsoleListMatchesAsync(string bearerToken, int? limit, bool? authoritative, string label, int? minSize, int? maxSize, string query)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGetMatchStateAsync_003Ed__47))]
		public Task<ConsoleMatchState> ConsoleGetMatchStateAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleListPurchasesAsync_003Ed__48))]
		public Task<ApiPurchaseList> ConsoleListPurchasesAsync(string bearerToken, string userId, int? limit, string cursor)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGetStatusAsync_003Ed__49))]
		public Task<ConsoleStatusList> ConsoleGetStatusAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleDeleteStorageAsync_003Ed__50))]
		public Task ConsoleDeleteStorageAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleListStorageAsync_003Ed__51))]
		public Task<ConsoleStorageList> ConsoleListStorageAsync(string bearerToken, string userId, string key, string collection, string cursor)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminClearUserStorageAsync_003Ed__52))]
		public Task ConsoleAdminClearUserStorageAsync(string bearerToken, string userId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleListStorageCollectionsAsync_003Ed__53))]
		public Task<ConsoleStorageCollectionsList> ConsoleListStorageCollectionsAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleFetchStorageDataAsync_003Ed__54))]
		public Task<ConsoleStorageDataResponse> ConsoleFetchStorageDataAsync(string bearerToken, ConsoleStorageDataRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleDeleteStorageObjectAsync_003Ed__55))]
		public Task ConsoleDeleteStorageObjectAsync(string bearerToken, string collection, string key, string userId, string version)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGetStorageAsync_003Ed__56))]
		public Task<ApiStorageObject> ConsoleGetStorageAsync(string bearerToken, string collection, string key, string userId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleWriteStorageObjectAsync_003Ed__57))]
		public Task<ApiStorageObjectAck> ConsoleWriteStorageObjectAsync(string bearerToken, string collection, string key, string userId, ConsoleWriteStorageObjectRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleDeleteStorageObject2Async_003Ed__58))]
		public Task ConsoleDeleteStorageObject2Async(string bearerToken, string collection, string key, string userId, string version)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminGetAllUpdateCheckRulesAsync_003Ed__59))]
		public Task<ConsoleGetAllUpdateCheckRulesResponse> ConsoleAdminGetAllUpdateCheckRulesAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminAddUpdateCheckRuleAsync_003Ed__60))]
		public Task ConsoleAdminAddUpdateCheckRuleAsync(string bearerToken, ApiUpdateCheckRuleRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminRemoveUpdateCheckRuleAsync_003Ed__61))]
		public Task ConsoleAdminRemoveUpdateCheckRuleAsync(string bearerToken, ApiUpdateCheckRuleRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleDeleteUserAsync_003Ed__62))]
		public Task ConsoleDeleteUserAsync(string bearerToken, string username)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleListUsersAsync_003Ed__63))]
		public Task<ConsoleUserList> ConsoleListUsersAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAddUserAsync_003Ed__64))]
		public Task ConsoleAddUserAsync(string bearerToken, ConsoleAddUserRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGdprAccessRequestAsync_003Ed__65))]
		public Task<ConsoleGdprAccessRequestResponse> ConsoleGdprAccessRequestAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleGdprDeleteRequestAsync_003Ed__66))]
		public Task<ConsoleGdprDeleteRequestResponse> ConsoleGdprDeleteRequestAsync(string bearerToken, string id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminGiftsGetAsync_003Ed__67))]
		public Task<ConsoleAdminGiftsGetResponse> ConsoleAdminGiftsGetAsync(string bearerToken, ConsoleAdminGiftsGetRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminGiftsAddAsync_003Ed__68))]
		public Task<ConsoleAdminGiftsAddResponse> ConsoleAdminGiftsAddAsync(string bearerToken, ConsoleAdminGiftsAddRequest body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminGetLiveOpsAsync_003Ed__69))]
		public Task<ConsoleAdminGetLiveOpsResponse> ConsoleAdminGetLiveOpsAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminScheduleLiveOpAsync_003Ed__70))]
		public Task<ConsoleAdminGetLiveOpsResponse> ConsoleAdminScheduleLiveOpAsync(string bearerToken, ConsoleAdminScheduledLiveOp body)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminGetLiveOpTypeDefaultDataAsync_003Ed__71))]
		public Task<ConsoleLiveOpTypeDefaultDataResponse> ConsoleAdminGetLiveOpTypeDefaultDataAsync(string bearerToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConsoleAdminDeleteLiveOpAsync_003Ed__72))]
		public Task<ConsoleAdminGetLiveOpsResponse> ConsoleAdminDeleteLiveOpAsync(string bearerToken, string id)
		{
			return null;
		}
	}
}
