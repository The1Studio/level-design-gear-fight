using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;

namespace Voodoo.Analytics
{
	internal static class Tracker
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSaveEvent_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public VanEvent vanEvent;

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
		private struct _003CTrackEvent_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public VanEvent vanEvent;

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

		private const string TAG = "Tracker";

		private const int MAX_SUSPEND_SENDING_COUNT = 16;

		private static readonly string SaveFolder;

		private static readonly object CurrentFileLock;

		private static string _currentFilePath;

		private static int _currentFileTimeStamp;

		private static int _currentFileEventCount;

		private static string _bundleId;

		private static IConfig _config;

		private static Timer _sendEventsTimer;

		private static ConcurrentQueue<string> _eventFilesToSend;

		private static int _currentSendingCount;

		private static int _suspendSending;

		internal static void Initialise(IConfig config, string proxyServer, string gatewayUrl)
		{
		}

		private static void StartSendEventsTimer()
		{
		}

		internal static void Start()
		{
		}

		internal static void Stop()
		{
		}

		private static void EnqueueEventFilesToSend()
		{
		}

		private static void SendEvents()
		{
		}

		private static void SendFile(string filePath)
		{
		}

		private static void DeleteFile(string filePath)
		{
		}

		private static void CreateNewFile()
		{
		}

		[AsyncStateMachine(typeof(_003CTrackEvent_003Ed__22))]
		internal static Task TrackEvent(VanEvent vanEvent)
		{
			return null;
		}

		private static bool IsEventAuthorised(VanEvent vanEvent)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CSaveEvent_003Ed__24))]
		private static Task SaveEvent(VanEvent vanEvent)
		{
			return null;
		}
	}
}
