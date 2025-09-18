namespace Voodoo.Sauce.Internal.Ads
{
	public abstract class BaseAd
	{
		protected readonly IMediationAdapter MediationAdapter;

		protected readonly string AppVersion;

		public AdDisplayConditions AdDisplayConditions;

		protected string Type;

		public AdLoadingState State { get; protected set; }

		protected string LoadedAdId { get; private set; }

		protected string DisplayedAdId { get; private set; }

		public AdTimer LoadingTime { get; }

		protected BaseAd(IMediationAdapter adapter)
		{
		}

		internal abstract void Initialize();

		internal bool IsLoaded()
		{
			return false;
		}

		internal bool IsEnabled()
		{
			return false;
		}

		public virtual void Enable()
		{
		}

		public virtual void Disable()
		{
		}

		internal int LoadingTimeMilliseconds()
		{
			return 0;
		}

		protected string GenerateAdId()
		{
			return null;
		}

		protected virtual void OnAdShowLifecycleStart()
		{
		}

		protected virtual void OnAdShowLifecycleEnd()
		{
		}

		public bool IsShowing()
		{
			return false;
		}

		internal virtual void OnInitialized(bool success)
		{
		}

		public virtual void OnLoading()
		{
		}

		public virtual void OnLoadSuccess()
		{
		}

		public virtual void OnLoadFailed()
		{
		}
	}
}
