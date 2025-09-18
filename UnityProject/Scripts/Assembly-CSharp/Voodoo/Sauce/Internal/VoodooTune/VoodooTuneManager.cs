using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Voodoo.Sauce.Internal.Analytics;
using Voodoo.Tune.Core;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	public static class VoodooTuneManager
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass23_0
		{
			public Action initFinishedEvent;

			public string url;

			public HttpResponseMessage response;

			public Stopwatch watch;

			public bool initFinishedInvoked;

			internal void _003CLoadConfiguration_003Eb__1()
			{
			}

			internal void _003CLoadConfiguration_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadConfiguration_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Action initFinishedEvent;

			private _003C_003Ec__DisplayClass23_0 _003C_003E8__1;

			private HttpClient _003Cclient_003E5__2;

			private CancellationTokenSource _003Ccts_003E5__3;

			private Task _003CuiTimeoutTask_003E5__4;

			private Task<HttpResponseMessage> _003CresponseTask_003E5__5;

			private Task _003CcompletedTask_003E5__6;

			private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter _003C_003Eu__1;

			private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _003C_003Eu__2;

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

		private const string TAG = "VoodooTuneManager";

		private const int DEFAULT_INIT_TIMEOUT_IN_MILLISECONDS_WITHOUT_CACHE = 3000;

		private static readonly VoodooTuneConfigurationManager _configurationManager;

		private static string _initError;

		private static bool _isTimeout;

		private static string _initFinishedMessage;

		private static bool _initCalled;

		private static bool _initFinished;

		internal static VoodooTuneInitAnalyticsInfoLog LastVoodooTuneInitInfo;

		private static VoodooTuneAbTestsTracker abTestTracker;

		private static VoodooTuneSegmentationManager segmentationManager;

		private static bool HasCache => false;

		private static bool IsAbTestValid => false;

		public static int CurrentTimeoutInMilliseconds { get; private set; }

		private static double CurrentTimeoutInSeconds => 0.0;

		public static void Initialize(Action initFinishedEvent)
		{
		}

		private static void SetTimeout()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadConfiguration_003Ed__23))]
		private static Task LoadConfiguration(Action initFinishedEvent)
		{
			return null;
		}

		private static void NoInternetInitRequest()
		{
		}

		private static void CancelInitRequest()
		{
		}

		private static void SaveConfiguration(ConfigResponse config)
		{
		}

		private static void SaveConfiguration(string url, string response, string error, long responseCode, double durationInMilliseconds, ulong payloadSize)
		{
		}

		private static (string, long?) ManageResponse(string response, long responseCode, string error)
		{
			return default((string, long?));
		}

		private static void TrackAbTestModifications(string response)
		{
		}

		private static void UpdateLastInitInfoAsTimeout()
		{
		}

		public static List<T> GetSubclassesItems<T>() where T : class, new()
		{
			return null;
		}

		public static List<T> GetItems<T>() where T : class, new()
		{
			return null;
		}

		public static List<T> GetItemsOrDefaults<T>() where T : class, new()
		{
			return null;
		}

		public static T GetItem<T>() where T : class, new()
		{
			return null;
		}

		public static T GetItemOrDefault<T>() where T : class, new()
		{
			return null;
		}

		public static string GetConfigurationId()
		{
			return null;
		}

		public static string GetSegmentationUuid()
		{
			return null;
		}

		public static List<string> GetSegmentationUuidsAsList()
		{
			return null;
		}

		public static string GetMainAbTestUuid()
		{
			return null;
		}

		public static List<string> GetAbTestUuidsAsList()
		{
			return null;
		}

		public static string GetAbTestUuids()
		{
			return null;
		}

		public static string GetMainAbTestCohortName()
		{
			return null;
		}

		public static string GetMainAbTestCohortUuid()
		{
			return null;
		}

		public static List<string> GetAbTestCohortUuidsAsList()
		{
			return null;
		}

		public static string GetAbTestCohortUuids()
		{
			return null;
		}

		public static string GetAbTestTreatmentUuids()
		{
			return null;
		}

		public static List<string> GetAbTestTreatmentUuidsAsList()
		{
			return null;
		}

		public static List<string> GetAbTestCohortNamesAsList()
		{
			return null;
		}

		public static string GetAbTestCohortNames()
		{
			return null;
		}

		public static string GetAbTestVersionUuid()
		{
			return null;
		}

		public static bool GetDebuggerAuthorization()
		{
			return false;
		}

		public static string GetRawConfiguration()
		{
			return null;
		}

		public static Dictionary<string, string> GetItemsJson()
		{
			return null;
		}
	}
}
