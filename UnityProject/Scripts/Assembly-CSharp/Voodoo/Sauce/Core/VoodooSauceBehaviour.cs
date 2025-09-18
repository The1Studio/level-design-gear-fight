using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;
using Voodoo.Sauce.Common.Utils;
using Voodoo.Sauce.Internal.Ads;
using Voodoo.Sauce.Internal.AppRater;
using Voodoo.Sauce.Internal.CrossPromo;
using Voodoo.Sauce.Internal.CrossPromo.Models;
using Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter;
using Voodoo.Sauce.Privacy;
using Voodoo.Sauce.Privacy.UI;

namespace Voodoo.Sauce.Core
{
	internal class VoodooSauceBehaviour : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public VoodooSauceBehaviour _003C_003E4__this;

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

		[CompilerGenerated]
		private sealed class _003CCheckInternetAvailability_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private NetworkReachability _003Creachability_003E5__2;

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
			public _003CCheckInternetAvailability_003Ed__54(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CInvokeAfterCoroutine_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public Action methodToCall;

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
			public _003CInvokeAfterCoroutine_003Ed__60(int _003C_003E1__state)
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

		private const string TAG = "VoodooSauceBehaviour";

		private static VoodooSauceBehaviour _instance;

		[SerializeField]
		private AppRater _appRaterPrefab;

		[SerializeField]
		private PrivacyCanvas _privacyCanvasPrefab;

		[SerializeField]
		private BannerBackground _bannerBackgroundPrefab;

		[SerializeField]
		[FormerlySerializedAs("inEditorAdsPrefab")]
		private GameObject fakeAdsPrefab;

		[SerializeField]
		private GameObject _accessButton;

		[SerializeField]
		private AFPSCounter _performanceDisplayPrefab;

		[SerializeField]
		private AudioAdsPopupTrigger _audioAdsPopupTriggerPrefab;

		[SerializeField]
		private GameObject _canvasAdLoading;

		private VoodooSettings _settings;

		private PrivacyCanvas _privacyCanvas;

		private IRequest _request;

		private static bool _startCalled;

		private static bool _initStarted;

		private static bool _initFinished;

		private static string _mediationName;

		public static Action OnInternetConnect;

		public static Action OnPrivacyOpened;

		public static Action OnPrivacyClosed;

		public static Action onDeleteDataRequested;

		private static HandledAction<VoodooSauceInitCallbackResult> _initFinishedEvent;

		[CanBeNull]
		private static VoodooSauceInitCallbackResult _initCallbackResult;

		private PrivacyCanvas PrivacyCanvas => null;

		private static event Action<bool> OnAnalyticsConsentEvent
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

		[AsyncStateMachine(typeof(_003CAwake_003Ed__28))]
		private void Awake()
		{
		}

		private static void EnableUnityAnalytics()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void DisableUnityAnalytics()
		{
		}

		private static void SelectMediation()
		{
		}

		private void InitVoodooTune()
		{
		}

		private void InitVoodooSauce()
		{
		}

		internal static BannerBackground InstantiateBannerBackgroundPrefab()
		{
			return null;
		}

		private void Start()
		{
		}

		public static void SubscribeOnInitFinishedEvent(Action<VoodooSauceInitCallbackResult> onInitFinished)
		{
		}

		public static void UnSubscribeOnInitFinishedEvent(Action<VoodooSauceInitCallbackResult> onInitFinished)
		{
		}

		internal static bool IsInitFinished()
		{
			return false;
		}

		public static void ShowCrossPromo(Action<AssetModel> onSuccess = null, Action<CPShowFailType> onFailure = null)
		{
		}

		public static void HideCrossPromo()
		{
		}

		public static T AddComponent<T>(bool inNewGameObject = false) where T : MonoBehaviour
		{
			return null;
		}

		private static void InitAnalytics(PrivacyCore.GdprConsent consent)
		{
		}

		private void OnPrivacyConsent(PrivacyCore.GdprConsent gdpr)
		{
		}

		private static void OnPrivacyUpdate(PrivacyCore.GdprConsent gdpr)
		{
		}

		private static void OnPrivacyShown(bool isPrivacyShown)
		{
		}

		private void InitCrashReport()
		{
		}

		private void InitPrivacy()
		{
		}

		private void InitAppRater()
		{
		}

		private void InitPerformanceDisplay()
		{
		}

		private static void InitPromo()
		{
		}

		private void InitAudioAdsPopupTrigger()
		{
		}

		public static void OpenDebugger()
		{
		}

		public static void CloseDebugger()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckInternetAvailability_003Ed__54))]
		private static IEnumerator CheckInternetAvailability()
		{
			return null;
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		internal static void InvokeAfter(Action methodToCall, float duration)
		{
		}

		internal static Coroutine InvokeCoroutine(IEnumerator coroutine)
		{
			return null;
		}

		internal static void KillCoroutine(Coroutine coroutine)
		{
		}

		[IteratorStateMachine(typeof(_003CInvokeAfterCoroutine_003Ed__60))]
		private static IEnumerator InvokeAfterCoroutine(Action methodToCall, float duration)
		{
			return null;
		}

		private void InstantiateAccessButton()
		{
		}

		private static void DisposeAccessButton()
		{
		}

		private void OnDestroy()
		{
		}

		internal static void CallAfterInitialization(Action<VoodooSauceInitCallbackResult> action)
		{
		}

		internal static void ShowLoadingAdScreen()
		{
		}

		internal static void HideLoadingAdScreen()
		{
		}
	}
}
