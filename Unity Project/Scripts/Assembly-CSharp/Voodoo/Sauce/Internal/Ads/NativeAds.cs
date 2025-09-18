using System;
using UnityEngine;
using Voodoo.Sauce.Ads;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	internal class NativeAds : BaseAd
	{
		private enum InternalAdState
		{
			NOT_INITIALIZED_YET = 0,
			AD_NOT_LOADED_YET = 1,
			CAN_NOT_SHOW = 2,
			CAN_SHOW = 3
		}

		private const string TAG = "AdsManager.NativeAd";

		private Guid? _currentNativeAd;

		private Action _autoShowAfterLoadAction;

		private Action _callback;

		public NativeAds(IMediationAdapter adapter)
			: base(null)
		{
		}

		internal override void Initialize()
		{
		}

		private InternalAdState CanShow()
		{
			return default(InternalAdState);
		}

		internal void Show(NativeAdLayout layout, Rect adScreenBounds, string tag, Guid id)
		{
		}

		internal void Hide(Guid? id = null)
		{
		}

		public override void Enable()
		{
		}

		public override void Disable()
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

		private void TriggerCallback()
		{
		}

		private void TriggerAutoShowActionIfNeeded()
		{
		}

		public override void OnLoadFailed()
		{
		}

		public override void OnLoadSuccess()
		{
		}

		public void OnShown()
		{
		}

		public void OnFailedToShow(VoodooErrorAdInfo errorAdInfo)
		{
		}

		public void OnClicked()
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
