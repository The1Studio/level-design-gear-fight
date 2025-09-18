using System;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	internal class Mrec : BaseAd
	{
		private enum InternalAdState
		{
			NOT_INITIALIZED_YET = 0,
			CAN_NOT_SHOW = 1,
			CAN_SHOW = 2
		}

		private const string TAG = "AdsManager.Mrec";

		private Action _autoShowAfterInitAction;

		public Mrec(IMediationAdapter adapter)
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

		internal void Show(float x, float y, string tag)
		{
		}

		internal void Hide()
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
