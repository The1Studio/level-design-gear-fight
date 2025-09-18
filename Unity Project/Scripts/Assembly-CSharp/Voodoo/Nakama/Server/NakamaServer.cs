using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Core.UI;
using GearGame.UI;
using JetBrains.Annotations;
using Nakama;
using NakamaHttp;
using UnityEngine;

namespace Voodoo.Nakama.Server
{
	[CreateAssetMenu(menuName = "Voodoo/Nakama/Server")]
	public class NakamaServer : ScriptableObject, IDisposable, INakamaCallbacks
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticate_003Ed__59 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaServer _003C_003E4__this;

			private TaskAwaiter<NakamaHttp.Session> _003C_003Eu__1;

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
		private struct _003CLinkProvider_003Ed__60<T> : IAsyncStateMachine where T : NakamaAuthProvider
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public NakamaServer _003C_003E4__this;

			public INakamaAccountMergeHandler mergeHandler;

			private NakamaAuthProvider _003Cprovider_003E5__2;

			private object _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private PopupBuilder<ProcessingPopup> _003CprocessingPopupBuilder_003E5__5;

			private TaskAwaiter<LinkResult> _003C_003Eu__1;

			private TaskAwaiter<bool> _003C_003Eu__2;

			private NakamaHttpClient _003CcurrentClient_003E5__6;

			private NakamaHttpClient _003CotherClient_003E5__7;

			private TaskAwaiter<NakamaHttpClient> _003C_003Eu__3;

			private AccountMergeOption _003CmergeDecision_003E5__8;

			private TaskAwaiter<AccountMergeOption> _003C_003Eu__4;

			private object _003C_003E7__wrap8;

			private int _003C_003E7__wrap9;

			private TaskAwaiter<MergeAccountResponse> _003C_003Eu__5;

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
		private struct _003CUnlinkProvider_003Ed__61<T> : IAsyncStateMachine where T : NakamaAuthProvider
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public NakamaServer _003C_003E4__this;

			private TaskAwaiter<bool> _003C_003Eu__1;

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

		[SerializeField]
		private List<NakamaEnvironmentDefinition> environments;

		[SerializeField]
		private NakamaLog.LogLevel logLevel;

		public const string PlayerPrefsEnvironmentKey = "Environment";

		public const string PlayerPrefsLoginStateKey = "nakama.login_state";

		public const int WriteToCloudBatchSizeLimit = 15000;

		public const bool UseCloudBatchSizeLimit = true;

		private const string PlayerPrefsTokenKey = "nakama.token";

		private const int InitialSecondsToWait = 2;

		private const int MaxSecondsToWait = 120;

		private string _voodooId;

		private NakamaLoginState _loginState;

		private List<NakamaAuthProvider> _authProviders;

		private Action _onInitFinishedEvent;

		private int _authenticationAttempts;

		private NakamaEnvironmentType? _customEnv;

		[PublicAPI]
		public string UserId => null;

		[PublicAPI]
		public string DeviceId => null;

		[PublicAPI]
		public NakamaHttpClient Client { get; private set; }

		[PublicAPI]
		public bool IsInitFinished { get; private set; }

		[PublicAPI]
		public bool IsUserAuthenticated { get; private set; }

		[PublicAPI]
		public bool IsTimeSynced { get; private set; }

		[PublicAPI]
		public NakamaTimer Timer { get; private set; }

		[PublicAPI]
		public event Action<AccountMergeOption> OnAccountMerged
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

		[PublicAPI]
		public event Action OnUserAuthenticated
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

		[PublicAPI]
		public event Action OnTimeSynced
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

		[PublicAPI]
		public void StartServer(string voodooId, List<NakamaAuthProvider> supportedAuthProviders = null, NakamaEnvironmentType? env = null)
		{
		}

		public NakamaHttpClient NewClient()
		{
			return null;
		}

		private void Init()
		{
		}

		[PublicAPI]
		public void SubscribeOnInitFinishedEvent(Action onInitFinished)
		{
		}

		[PublicAPI]
		public void UnSubscribeOnInitFinishedEvent(Action onInitFinished)
		{
		}

		private void OnInitFinished()
		{
		}

		private void VerifyProductionEnvironment()
		{
		}

		[PublicAPI]
		public T GetAuthProvider<T>() where T : NakamaAuthProvider
		{
			return null;
		}

		private NakamaEnvironmentDefinition GetEnvironment(NakamaEnvironmentType t)
		{
			return null;
		}

		[PublicAPI]
		public NakamaEnvironmentDefinition GetCurrentEnvironment(NakamaEnvironmentType? env = null)
		{
			return null;
		}

		[PublicAPI]
		public void ReAuthenticate()
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticate_003Ed__59))]
		private void Authenticate()
		{
		}

		[AsyncStateMachine(typeof(_003CLinkProvider_003Ed__60<>))]
		[PublicAPI]
		public Task<bool> LinkProvider<T>(INakamaAccountMergeHandler mergeHandler) where T : NakamaAuthProvider
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnlinkProvider_003Ed__61<>))]
		[PublicAPI]
		public Task<bool> UnlinkProvider<T>() where T : NakamaAuthProvider
		{
			return null;
		}

		private void SessionCreated(ISession createdSession)
		{
		}

		[PublicAPI]
		public void StopServer()
		{
		}

		public void Dispose()
		{
		}

		public static void DEBUG_ClearUserTokens()
		{
		}

		public void ClearUserData()
		{
		}

		private void SetProvidersUnlinked()
		{
		}
	}
}
