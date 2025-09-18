using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Voodoo.Sauce.Ads;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	public class RewardedVideo : BaseAd
	{
		private enum InternalAdState
		{
			GRANT_REWARDS = 0,
			SHOW_INTERSTITIAL = 1,
			NOT_AVAILABLE = 2,
			CAN_SHOW = 3
		}

		[CompilerGenerated]
		private sealed class _003CMeasureRVDismissDelay_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardedVideo _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CMeasureRVDismissDelay_003Ed__39(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CStartSecondRV_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardedVideo _003C_003E4__this;

			private float _003CloadingTime_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CStartSecondRV_003Ed__38(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const string TAG = "AdsManager.RewardedVideo";

		private Action<bool> _callback;

		private TwoAdsInARow _twoAdsConfig;

		private int _rvTriggered;

		private bool _isSecondRv;

		private float _dismissDelay;

		internal event Action<bool> OnRewardedVideoAvailabilityChangeEvent
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

		internal event Action OnRewardedVideoNotAvailableEvent
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

		public event Action OnShow
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

		public event Action OnRewardShowed
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

		internal RewardedVideo(IMediationAdapter adapter)
			: base(null)
		{
		}

		internal override void Initialize()
		{
		}

		internal bool IsAvailable(bool showLogs = true)
		{
			return false;
		}

		private InternalAdState CanShow()
		{
			return default(InternalAdState);
		}

		internal void Show(Action<bool> onComplete, string tag = null)
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

		private static int WatchedAdCount()
		{
			return 0;
		}

		private static int IncrementWatchedAdCount()
		{
			return 0;
		}

		private void TriggerCallback(bool watched)
		{
		}

		internal void AvailabilityUpdateFromRewardedInterstitial()
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

		public void OnDismissed(bool rewardedReceived)
		{
		}

		public void OnImpression(ImpressionInfoType type)
		{
		}

		internal void OnButtonShown(string rewardedType)
		{
		}

		[IteratorStateMachine(typeof(_003CStartSecondRV_003Ed__38))]
		private IEnumerator StartSecondRV()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CMeasureRVDismissDelay_003Ed__39))]
		private IEnumerator MeasureRVDismissDelay()
		{
			return null;
		}

		public static bool ShowTwoRvInARow(TwoAdsInARow twoAdsConfig, int rvTriggered, bool isSecondRv, bool rewardedReceived)
		{
			return false;
		}

		public void OnAdReview(AdReviewAnalyticsInfo adInfo)
		{
		}
	}
}
