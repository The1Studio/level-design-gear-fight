using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Voodoo.Live.Utils;

namespace Voodoo.Live.Offers
{
	public class FeatureClient : IFeatureClient, IClient
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitialize_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public FeatureClient _003C_003E4__this;

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

		private const string _cacheFileName = "voodoolive_local_offers_cache.json";

		private FeatureConfig _featureConfig;

		private readonly List<IFeature> _activeFeatures;

		private readonly List<IFeature> _invalidFeatures;

		private CacheSystem _cache;

		private OfferUrlHandler _urlHandler;

		public IUrlHandler UrlHandler => null;

		public string payload { get; private set; }

		public ConfigResponse ConfigResponse { get; private set; }

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

		public event Action<string> eventFired
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

		[AsyncStateMachine(typeof(_003CInitialize_003Ed__23))]
		public Task Initialize()
		{
			return null;
		}

		private void AddHeaders()
		{
		}

		private void TrackInitFinished(ConfigResponse config)
		{
		}

		public void Trigger(string trigger)
		{
		}

		public List<IFeature> GetActiveFeatures()
		{
			return null;
		}

		public List<IFeature> GetInvalidFeatures()
		{
			return null;
		}

		public Item GetItemById(string id)
		{
			return null;
		}
	}
}
