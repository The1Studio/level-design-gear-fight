using System;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	internal class AppOpen : BaseAd
	{
		public enum AdType
		{
			soft_launch = 0
		}

		private enum InternalAdState
		{
			CAN_NOT_SHOW = 0,
			CAN_SHOW = 1,
			NOT_AVAILABLE = 2,
			NOT_LOADED = 3
		}

		private const string TAG = "AdsManager.AppOpen";

		private Action _callback;

		internal AppOpen(IMediationAdapter adapter)
			: base(null)
		{
		}

		internal override void Initialize()
		{
		}

		private InternalAdState CanShow(bool ignoreConditions = false)
		{
			return default(InternalAdState);
		}

		internal void Show(Action onComplete = null, bool ignoreConditions = false)
		{
		}

		public override void Enable()
		{
		}

		protected override void OnAdShowLifecycleStart()
		{
		}

		private static int AdCount()
		{
			return 0;
		}

		private static int IncrementAdCount()
		{
			return 0;
		}

		private static int IncrementWatchedAdCount()
		{
			return 0;
		}

		private void TriggerCallback()
		{
		}

		public override void OnLoading()
		{
		}

		public override void OnLoadFailed()
		{
		}

		public override void OnLoadSuccess()
		{
		}

		public void OnClicked()
		{
		}

		public void OnFailedToShow(VoodooErrorAdInfo errorAdInfo)
		{
		}

		public void OnDismissed()
		{
		}

		public void OnImpression(ImpressionInfoType type)
		{
		}
	}
}
