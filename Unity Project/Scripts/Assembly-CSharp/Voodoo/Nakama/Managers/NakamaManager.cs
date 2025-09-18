using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NakamaHttp;
using UnityEngine;
using Voodoo.Nakama.Account;
using Voodoo.Nakama.Data;
using Voodoo.Nakama.Server;
using Voodoo.Nakama.Utils;

namespace Voodoo.Nakama.Managers
{
	public class NakamaManager : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLogIn_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public NakamaManager _003C_003E4__this;

			public ELoginType type;

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

		[CompilerGenerated]
		private sealed class _003CWaitForDataInstallationAndDoCoroutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NakamaManager _003C_003E4__this;

			public Action onFinish;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitForDataInstallationAndDoCoroutine_003Ed__29(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public static bool ReloadingGame;

		[SerializeField]
		private NakamaServer m_NakamaServer;

		[SerializeField]
		[Tooltip("Defines the maximum weight difference for a merge conflict to be resolved automatically. If the weight difference is below this value, the player will have to choose.")]
		[Space]
		private int _maxMergeConflictWeight;

		[SerializeField]
		private List<ELoginType> _debugSupportedProviders;

		[SerializeField]
		private List<ELoginType> _iOSSupportedProviders;

		[SerializeField]
		private List<ELoginType> _AndroidSupportedProviders;

		private static NakamaManager _instance;

		private DataManager m_DataManager;

		private NakamaAccountMergeHandler m_NakamaAccountMergeHandler;

		private IDataConfigurator m_DataConfigurator;

		private Action m_OnInitCompleteCallback;

		private bool _dataLoaded;

		private string _cachedVoodooID;

		public static NakamaManager Instance => null;

		public string VoodooID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string UserId => null;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnMergeConflict(string otherUserId, List<ServerBaseData> otherData, Action<AccountMergeOption> closeCallback)
		{
		}

		private int GetArbitratingWeight(List<ServerBaseData> otherData)
		{
			return 0;
		}

		private void CreateDataManagerAndInstallData()
		{
		}

		public void CreateData<T>() where T : ServerBaseData, new()
		{
		}

		public T GetData<T>() where T : ServerBaseData
		{
			return null;
		}

		public void ReplaceData<T>(T newData) where T : ServerBaseData
		{
		}

		public void WaitForDataInstallationAndDo(Action onFinish)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForDataInstallationAndDoCoroutine_003Ed__29))]
		private IEnumerator WaitForDataInstallationAndDoCoroutine(Action onFinish)
		{
			return null;
		}

		private DataManager CreateDataManager()
		{
			return null;
		}

		public List<ELoginType> GetSupportedPlatformLoginTypes()
		{
			return null;
		}

		private List<NakamaAuthProvider> GetSupportedPlatformAuthProviders()
		{
			return null;
		}

		public void StartServer(IDataConfigurator dataConfigurator, Action onInitComplete)
		{
		}

		private void OnAccountsMerged(AccountMergeOption option)
		{
		}

		private void OnServerStarted()
		{
		}

		private void LoadData(Action onFinish)
		{
		}

		[AsyncStateMachine(typeof(_003CLogIn_003Ed__37))]
		public Task<bool> LogIn(ELoginType type)
		{
			return null;
		}

		public void LogOut()
		{
		}

		public void DeleteAccountAndRestart(Action<HttpStatusCode, string> onResponseError, Action<Exception> onGenericError)
		{
		}

		public void ReloadGame()
		{
		}

		public void SetEmailCredentials(string email, string pass)
		{
		}

		public bool IsLoggedIn()
		{
			return false;
		}

		public bool DatasLoaded()
		{
			return false;
		}

		public void GetLeaderboardTop(string leaderboardID, int userCount, Action<LeaderboardPlayerDataRecordList> successCallback, Action failCallback)
		{
		}

		public void GetLeaderboardAroundUser(string leaderboardID, int userCount, Action<LeaderboardPlayerDataRecordList> successCallback, Action failCallback)
		{
		}

		public void SetPersonalLeaderboardRecord(int score, string leaderboardID, Action successCallback, Action failCallback)
		{
		}

		public void UpdatePlayerProfile(string name, Action successCallback, Action failCallback)
		{
		}

		public void GetPlayerProfile(Action<PlayerData> successCallback, Action failCallback)
		{
		}

		public void SavePendingData()
		{
		}
	}
}
