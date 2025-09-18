using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Voodoo.Live.Debugger;
using Voodoo.Live.Offers;
using Voodoo.Live.Shop;

namespace Voodoo.Live
{
	public static class VoodooLive
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitialize_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public IVoodooLiveBridge bridge;

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
		private struct _003CInitialize_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Func<string, int, bool> currencyAvailability;

			public Action<string, int> currencyDebit;

			public Action<string> purchaseIAP;

			public Func<Transaction, bool> rewardingMethod;

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

		private static FeatureClient _featureClient;

		private static TransactionRegistry _transactionRegistry;

		private static FeatureQueue _featureQueue;

		private static VoodooLiveSettings _settings;

		private static VoodooLiveDebuggerManager _voodooLiveDebuggerManager;

		private static ShopManager _shopManager;

		private static bool _isInitialized;

		public static ShopManager ShopManager => null;

		public static FeatureClient FeatureClient => null;

		public static TransactionRegistry TransactionRegistry => null;

		public static VoodooLiveSettings Settings => null;

		public static VoodooLiveDebuggerManager VoodooLiveDebuggerManager => null;

		public static FeatureQueue FeatureQueue => null;

		public static bool IsInitialized => false;

		private static event Action OnVoodooLiveInitialized
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

		static VoodooLive()
		{
		}

		public static void SubscribeOnInitFinishedEvent(Action onInitFinished)
		{
		}

		public static void UnSubscribeOnInitFinishedEvent(Action onInitFinished)
		{
		}

		[AsyncStateMachine(typeof(_003CInitialize_003Ed__27))]
		public static Task Initialize(IVoodooLiveBridge bridge)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInitialize_003Ed__28))]
		public static Task Initialize(Func<string, int, bool> currencyAvailability, Action<string, int> currencyDebit, Action<string> purchaseIAP, Func<Transaction, bool> rewardingMethod)
		{
			return null;
		}
	}
}
