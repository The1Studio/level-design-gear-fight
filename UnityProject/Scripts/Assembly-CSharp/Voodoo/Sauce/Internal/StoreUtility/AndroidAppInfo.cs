using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Voodoo.Sauce.Internal.StoreUtility
{
	internal static class AndroidAppInfo
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAppUpdateStatus_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Action<AppUpdateStatus> onAppUpdateStatusRetrieved;

			private TaskAwaiter<int> _003C_003Eu__1;

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
		private struct _003CGetStoreVersion_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			private int _003CmaxIteration_003E5__2;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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

		private static AppUpdateCallback _appUpdateCallback;

		private static int _storeVersion;

		private static AppUpdateStatus _appUpdateStatus;

		private static PackageInfo _packageInfo;

		public static int StoreVersion => 0;

		[AsyncStateMachine(typeof(_003CGetStoreVersion_003Ed__6))]
		private static Task<int> GetStoreVersion()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetAppUpdateStatus_003Ed__7))]
		public static void GetAppUpdateStatus(Action<AppUpdateStatus> onAppUpdateStatusRetrieved)
		{
		}

		private static void OnStoreVersionRetrieved()
		{
		}

		public static void OpenStore()
		{
		}

		internal static int GetBundleVersionCode()
		{
			return 0;
		}

		private static PackageInfo GetPackageInfo()
		{
			return null;
		}

		private static void GetAppUpdateCallback()
		{
		}
	}
}
