using System;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	internal class Banner : BaseAd
	{
		private enum InternalAdState
		{
			NOT_INITIALIZED_YET = 0,
			CAN_NOT_SHOW = 1,
			CAN_SHOW = 2
		}

		private const string TAG = "AdsManager.Banner";

		private const int BANNER_HEIGHT = 50;

		private float _bannerHeightCachedValue;

		private bool _haveBannerHeightCachedValue;

		private Action _autoShowAfterInitAction;

		private Action<float> _callback;

		public Banner(IMediationAdapter adapter)
			: base(null)
		{
		}

		internal override void Initialize()
		{
		}

		internal bool IsAvailable()
		{
			return false;
		}

		internal float GetNativeBannerHeightInDp()
		{
			return 0f;
		}

		internal float GetNativeBannerHeightInPx()
		{
			return 0f;
		}

		internal float GetMediationScreenDensity()
		{
			return 0f;
		}

		private InternalAdState CanShow()
		{
			return default(InternalAdState);
		}

		public void Show(Action<float> onBannerDisplayed)
		{
		}

		public void Hide()
		{
		}

		public override void Enable()
		{
		}

		public override void Disable()
		{
		}

		private void TriggerCallback()
		{
		}

		private void TriggerAutoShowActionIfNeeded()
		{
		}

		internal override void OnInitialized(bool success)
		{
		}

		public override void OnLoadSuccess()
		{
		}

		public override void OnLoadFailed()
		{
		}

		public void OnClicked()
		{
		}

		public void OnImpression(ImpressionInfoType type)
		{
		}
	}
}
