using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NakamaHttp;
using Voodoo.Nakama.Data;
using Voodoo.Nakama.Server;

namespace Voodoo.Nakama.Account
{
	public class NakamaAccountMergeHandler : INakamaAccountMergeHandler
	{
		public delegate void MergeConflictDelegate(string otherUserId, List<ServerBaseData> otherData, Action<AccountMergeOption> finishCallback);

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public NakamaAccountMergeHandler _003C_003E4__this;

			public StorageObjects newStorage;

			public TaskCompletionSource<AccountMergeOption> result;

			internal void _003CMergeAccounts_003Eb__0(AccountMergeOption selectedMergeOption)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadStorage_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<StorageObjects> _003C_003Et__builder;

			public NakamaAccountMergeHandler _003C_003E4__this;

			public NakamaHttpClient newClient;

			private TaskAwaiter<StorageObjects> _003C_003Eu__1;

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
		private struct _003CMergeAccounts_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AccountMergeOption> _003C_003Et__builder;

			public NakamaAccountMergeHandler _003C_003E4__this;

			public NakamaHttpClient newClient;

			private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

			private string _003CotherUserId_003E5__2;

			private TaskAwaiter<StorageObjects> _003C_003Eu__1;

			private TaskAwaiter<AccountMergeOption> _003C_003Eu__2;

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

		private readonly DataManager m_DataManager;

		private AccountMergeOption m_SelectedOption;

		public AccountMergeOption SelectedOption => default(AccountMergeOption);

		public MergeConflictDelegate OnMergeConflict { get; set; }

		public NakamaAccountMergeHandler(DataManager dataManager)
		{
		}

		[AsyncStateMachine(typeof(_003CMergeAccounts_003Ed__10))]
		public Task<AccountMergeOption> MergeAccounts(NakamaHttpClient currentClient, NakamaHttpClient newClient)
		{
			return null;
		}

		private List<ServerBaseData> GetServerData(StorageObjects newStorage)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadStorage_003Ed__12))]
		private Task<StorageObjects> LoadStorage(NakamaHttpClient newClient)
		{
			return null;
		}
	}
}
