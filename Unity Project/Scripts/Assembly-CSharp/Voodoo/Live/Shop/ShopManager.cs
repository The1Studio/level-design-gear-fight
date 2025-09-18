using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Voodoo.Live.Shop.Data;
using Voodoo.Live.Utils;

namespace Voodoo.Live.Shop
{
	public class ShopManager : IShopClient, IClient
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInit_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ShopManager _003C_003E4__this;

			private TaskAwaiter<ConfigResponse> _003C_003Eu__1;

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

		private const string _cacheFileName = "voodoolive_local_shop_cache.json";

		private const string TAG = "ShopManager";

		private GameShop _gameShop;

		private ConfigResponse _configResponse;

		private CacheSystem _cache;

		private ShopUrlHandler _urlHandler;

		public IUrlHandler UrlHandler => null;

		public string RemoteConfig { get; private set; }

		public GameShop GameShop => null;

		public ConfigResponse ConfigResponse => null;

		public event Action<ConfigResponse> requestCompleted
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

		[AsyncStateMachine(typeof(_003CInit_003Ed__20))]
		public Task Init(ShopConfigSO shopConfigSO)
		{
			return null;
		}

		public Product GetProductByIapId(string iapId)
		{
			return null;
		}
	}
}
