using System;
using System.Runtime.CompilerServices;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	public class RewardedInterstitialVideo : BaseAd
	{
		private const string TAG = "AdsManager.RewardedInterstitialVideo";

		private Action<bool> _callback;

		private RewardedReplaceState _currentShowingRewardReplaceState;

		internal event Action OnShow
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

		public RewardedInterstitialVideo(IMediationAdapter adapter)
			: base(null)
		{
		}

		internal override void Initialize()
		{
		}

		internal void Show(Action<bool> onComplete, RewardedReplaceState rewardedReplaceState, string tag = null)
		{
		}

		public override void Enable()
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

		private void TriggerCallback(bool isAdsDisplayed)
		{
		}

		public RewardedReplaceState GetRewardedReplaceState()
		{
			return default(RewardedReplaceState);
		}

		private void AddRvReplaceStateToAnalyticsInfo(AdAnalyticsInfo analyticsInfo)
		{
		}

		public override void OnLoadFailed()
		{
		}

		public override void OnLoadSuccess()
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
