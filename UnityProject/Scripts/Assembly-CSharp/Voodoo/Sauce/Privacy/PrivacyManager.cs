using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Privacy.UI;

namespace Voodoo.Sauce.Privacy
{
	[Preserve]
	internal class PrivacyManager : PrivacyCore
	{
		public struct AdvertisingStatus
		{
			public string Idfa;

			public bool AdTrackingEnabled;
		}

		private static class IdfaHelper
		{
			[CompilerGenerated]
			private sealed class _003C_003Ec__DisplayClass0_0
			{
				public string idfa;

				public bool adTrackingEnabled;

				public bool waiting;

				internal void _003CRequestAdvertisingId_003Eb__0(string advertisingId, bool adTracking, string error)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[CompilerGenerated]
			private struct _003CRequestAdvertisingId_003Ed__0 : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncTaskMethodBuilder<AdvertisingStatus> _003C_003Et__builder;

				private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;

				private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

				private TaskAwaiter<AdvertisingStatus> _003C_003Eu__2;

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

			[AsyncStateMachine(typeof(_003CRequestAdvertisingId_003Ed__0))]
			public static Task<AdvertisingStatus> RequestAdvertisingId(VoodooSettings voodooSettings, PrivacyCore privacy)
			{
				return null;
			}
		}

		private static class IdfaHelperAndroid
		{
			public delegate void RequestAdvertisingIdCallback(string advertisingId, bool trackingEnabled);

			private const string TAG = "IdfaHelperAndroid";

			public static Task<AdvertisingStatus> GetIdfaAndroidAsync()
			{
				return null;
			}

			private static void GetIdfaAndroidPlayService(RequestAdvertisingIdCallback callBack)
			{
			}
		}

		private static class VendorIdHelperAndroid
		{
			private delegate void RequestVendorIdCallback(string vendorId);

			[StructLayout((LayoutKind)3)]
			[CompilerGenerated]
			private struct _003CRequestVendorId_003Ed__4 : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

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

			private const string TAG = "VendorIdHelperAndroid";

			private static string _vendorId;

			private static readonly bool IS_ANDROID;

			[AsyncStateMachine(typeof(_003CRequestVendorId_003Ed__4))]
			internal static Task<string> RequestVendorId()
			{
				return null;
			}

			private static Task<string> GetAndroidVendorIdAsync()
			{
				return null;
			}

			private static void DisposeObjects(List<AndroidJavaObject> androidJavaObjects)
			{
			}

			private static void GetAppSetIdAndroidPlayService(RequestVendorIdCallback callBack)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAskConsent_003Ed__53 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PrivacyConsent> _003C_003Et__builder;

			public PrivacyManager _003C_003E4__this;

			private TaskAwaiter<PrivacyConsent> _003C_003Eu__1;

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
		private struct _003CDeleteData_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public string email;

			public PrivacyManager _003C_003E4__this;

			private TaskAwaiter<PrivacyRequest> _003C_003Eu__1;

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
		private struct _003CInstantiate_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PrivacyManager _003C_003E4__this;

			public VoodooSettings voodooSettings;

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
		private struct _003COnSynchronizeWithServerEnd_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PrivacyManager _003C_003E4__this;

			public bool isSuccess;

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
		private struct _003COpenCmpPrivacySettings_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PrivacyManager _003C_003E4__this;

			private TaskAwaiter<CmpConsent> _003C_003Eu__1;

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
		private struct _003CRequestAccessToData_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public UserDetails userDetails;

			public PrivacyManager _003C_003E4__this;

			private TaskAwaiter<PrivacyRequest> _003C_003Eu__1;

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
		private struct _003CSendConsent_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PrivacyManager _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSendConsent_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public PrivacyManager _003C_003E4__this;

			public bool adsConsent;

			public bool analyticsConsent;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSynchronizeAdvertisingId_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PrivacyManager _003C_003E4__this;

			private TaskAwaiter<string> _003C_003Eu__1;

			private TaskAwaiter<AdvertisingStatus> _003C_003Eu__2;

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
		private struct _003CSynchronizeWithServer_003Ed__48 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PrivacyManager _003C_003E4__this;

			private TaskAwaiter<NeedConsent> _003C_003Eu__1;

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
		private struct _003CUpdateConsent_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PrivacyManager _003C_003E4__this;

			private bool _003CmustSendConsent_003E5__2;

			private TaskAwaiter<CmpConsent> _003C_003Eu__1;

			private TaskAwaiter<PrivacyConsent> _003C_003Eu__2;

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
		private struct _003CUpdatePrivacyConsent_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PrivacyManager _003C_003E4__this;

			public PrivacyUpdate privacyUpdate;

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

		private const string TAG = "PrivacyManager";

		private const int CONSENT_VALIDITY_PERIOD_IN_DAY = 182;

		private VoodooSettings _voodooSettings;

		private Action<GdprConsent> _onConsentGiven;

		private Action<GdprConsent> _onConsentUpdate;

		private Action<bool> _onPrivacyShown;

		private Action _onInternetAvailable;

		private Action _onGameStarted;

		private Action _onGameFinished;

		private Action _tryOpenDebugger;

		private Action _onDeleteDataRequest;

		private Func<bool> _hasGameStarted;

		private IPrivacyCanvas _privacyCanvas;

		private IRequest _request;

		private string _gdprTexts;

		private bool _isInitialized;

		private bool _showOfferWall;

		private PrivacyConfiguration _privacyConfiguration;

		private bool _alreadyAppliedGdpr;

		private int _startPlayDate;

		private int _limitedPlayTimeInSecond;

		private IPrivacyUIManager _uiManager;

		private NeedConsent _serverConsent;

		private NeedConsent.OfferWallStatus _offerWallStatus;

		private Action _onSettingsClosed;

		private IPrivacyAPI _privacyAPI;

		private IConsentManagementProvider _consentManagementProvider;

		private const string PLAYER_PREF_IS_SIXTEEN_OR_OLDER = "Voodoo.Sauce.Privacy.IsOverSixteen";

		private const string PLAYER_PREF_ADS_CONSENT = "Voodoo.Sauce.Privacy.AdsConsent";

		private const string PLAYER_PREF_ANALYTICS_CONSENT = "Voodoo.Sauce.Privacy.AnalyticsConsent";

		private const string PLAYER_PREF_PRIVACY_VERSION = "Voodoo.Sauce.Privacy.PrivacyVersion";

		private const string PLAYER_PREF_NEED_SEND_CONSENT = "Voodoo.Sauce.Privacy.NeedSendConsent";

		private const string PLAYER_PREF_LAST_CONSENT_DATE = "Voodoo.Sauce.Privacy.LastConsentDate";

		private const string PLAYER_PREF_LAST_PLAY_DATE = "Voodoo.Sauce.Privacy.LastPlayDate";

		private const string PLAYER_PREF_LAST_PLAY_TIME = "Voodoo.Sauce.Privacy.LastPlayTime";

		private const string PLAYER_PREF_AD_TRACKING_ENABLED = "Voodoo.Sauce.Privacy.AdTrackingEnabled";

		private const string PLAYER_PREF_PRIVACY_LIST = "Voodoo.Sauce.Privacy.List";

		private const string PLAYER_PREF_USER_REQUEST_TO_BE_FORGOTTEN = "Voodoo.Sauce.Privacy.UserRequestedToBeForgotten";

		private const string PLAYER_PREF_SOURCEPOINT_SHOWN = "Voodoo.Sauce.Privacy.SourcepointShown";

		private IPrivacyUIManager UIManager => null;

		private IPrivacyAPI PrivacyAPI => null;

		[AsyncStateMachine(typeof(_003CInstantiate_003Ed__34))]
		public override Task Instantiate(VoodooSettings voodooSettings)
		{
			return null;
		}

		public override void Initialize(PrivacyManagerParameters parameters)
		{
		}

		internal override void ShowPrivacyAuthorization()
		{
		}

		public override string GetAdvertisingId(bool forceZerosForLimitedAdTracking = true)
		{
			return null;
		}

		internal override void OpenPrivacySettings(Action onSettingsClosed = null)
		{
		}

		private void CloseCmpPrivacySettings()
		{
		}

		private void ClosePrivacySettings()
		{
		}

		[AsyncStateMachine(typeof(_003COpenCmpPrivacySettings_003Ed__41))]
		private void OpenCmpPrivacySettings()
		{
		}

		[AsyncStateMachine(typeof(_003CUpdatePrivacyConsent_003Ed__42))]
		private void UpdatePrivacyConsent(PrivacyUpdate privacyUpdate)
		{
		}

		private void UpdateCachedConsent(PrivacyUpdate privacyUpdate)
		{
		}

		[AsyncStateMachine(typeof(_003CDeleteData_003Ed__44))]
		private void DeleteData(string email)
		{
		}

		[AsyncStateMachine(typeof(_003CRequestAccessToData_003Ed__45))]
		private void RequestAccessToData(UserDetails userDetails)
		{
		}

		[AsyncStateMachine(typeof(_003CSynchronizeAdvertisingId_003Ed__46))]
		private Task SynchronizeAdvertisingId()
		{
			return null;
		}

		private void TrySynchronizeWithServer()
		{
		}

		[AsyncStateMachine(typeof(_003CSynchronizeWithServer_003Ed__48))]
		private void SynchronizeWithServer()
		{
		}

		[AsyncStateMachine(typeof(_003COnSynchronizeWithServerEnd_003Ed__49))]
		private void OnSynchronizeWithServerEnd(bool isSuccess)
		{
		}

		private void TryUpdateConsent()
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateConsent_003Ed__51))]
		private void UpdateConsent()
		{
		}

		private void TrySendConsent()
		{
		}

		[AsyncStateMachine(typeof(_003CAskConsent_003Ed__53))]
		private Task<PrivacyConsent> AskConsent()
		{
			return null;
		}

		private Task<NeedConsent> RequestConsent()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSendConsent_003Ed__55))]
		private void SendConsent()
		{
		}

		[AsyncStateMachine(typeof(_003CSendConsent_003Ed__56))]
		private Task<bool> SendConsent(bool adsConsent, bool analyticsConsent)
		{
			return null;
		}

		private Type GetCmpType()
		{
			return null;
		}

		private void CacheConsent(PrivacyConsent privacyConsent)
		{
		}

		private void LoadCache()
		{
		}

		private bool NeedUpdateLocalConsent()
		{
			return false;
		}

		private bool NeedConsentToNewVoodooPolicy()
		{
			return false;
		}

		private bool NeedConsentToNew3rdPartyPolicy()
		{
			return false;
		}

		private static bool ConsentNotUpToDate()
		{
			return false;
		}

		private bool AdTrackingIsReEnabled()
		{
			return false;
		}

		private bool IsInternetAvailable()
		{
			return false;
		}

		private bool IsCmpActive()
		{
			return false;
		}

		internal override string GetCmpName()
		{
			return null;
		}

		internal override void ClearCMPCache()
		{
		}

		private void CacheAdsConsent(bool consent)
		{
		}

		private bool GetAdsConsent()
		{
			return false;
		}

		private void CacheAnalyticsConsent(bool consent)
		{
		}

		private bool GetAnalyticsConsent()
		{
			return false;
		}

		private string GetPrivacyVersion()
		{
			return null;
		}

		private void CachePrivacyVersion(string privacyVersion)
		{
		}

		private bool GetAlreadyAppliedGdpr()
		{
			return false;
		}

		private void CacheSixteenOrOlder(bool isSixteenOrOlder)
		{
		}

		private bool GetSixteenOrOlder()
		{
			return false;
		}

		private void CacheNeedSendConsent(bool needSend)
		{
		}

		private bool NeedSendConsent()
		{
			return false;
		}

		private static void CacheConsentDate()
		{
		}

		private static int GetConsentDate()
		{
			return 0;
		}

		private void CacheAdTrackingEnabled(bool adTrackingEnabled)
		{
		}

		private bool GetCachedAdTrackingEnabled()
		{
			return false;
		}

		private void CachePrivacyList()
		{
		}

		private string[] GetPrivacyList()
		{
			return null;
		}

		private bool IsCachePresent()
		{
			return false;
		}

		private void CacheUserRequestedToBeForgotten(bool value)
		{
		}

		public override bool UserRequestedToBeForgotten()
		{
			return false;
		}

		private void CacheCurrentPlayDate()
		{
		}

		private int GetLastPlayDate()
		{
			return 0;
		}

		private void CacheCurrentPlaytime(int playtimeInSecond)
		{
		}

		private int GetLastPlaytimeInSecond()
		{
			return 0;
		}
	}
}
