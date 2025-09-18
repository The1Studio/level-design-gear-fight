using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Voodoo.Sauce.Ads;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Ads
{
	public class Interstitial : BaseAd
	{
		private enum InternalAdState
		{
			CAN_NOT_SHOW = 0,
			CAN_SHOW = 1,
			NOT_AVAILABLE = 2
		}

		[CompilerGenerated]
		private sealed class _003CMeasureFsDismissDelay_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Interstitial _003C_003E4__this;

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
			public _003CMeasureFsDismissDelay_003Ed__31(int _003C_003E1__state)
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
		private sealed class _003CStartSecondFs_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Interstitial _003C_003E4__this;

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
			public _003CStartSecondFs_003Ed__30(int _003C_003E1__state)
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

		private const string TAG = "AdsManager.Interstitial";

		private Action<bool> _callback;

		private TwoAdsInARow _twoAdsConfig;

		private int _fsTriggered;

		private bool _isSecondFs;

		private float _dismissDelay;

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

		public event Action OnClosed
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

		internal Interstitial(IMediationAdapter adapter)
			: base(null)
		{
		}

		internal override void Initialize()
		{
		}

		internal bool IsLoaded(bool showLogs = true)
		{
			return false;
		}

		internal bool ReadyToShow()
		{
			return false;
		}

		private InternalAdState GetShowStatus(bool ignoreConditions = false)
		{
			return default(InternalAdState);
		}

		internal void Show(Action<bool> onComplete, bool ignoreConditions = false, string tag = null)
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

		private void TriggerCallback(bool shown)
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

		[IteratorStateMachine(typeof(_003CStartSecondFs_003Ed__30))]
		private IEnumerator StartSecondFs()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CMeasureFsDismissDelay_003Ed__31))]
		private IEnumerator MeasureFsDismissDelay()
		{
			return null;
		}

		public void OnImpression(ImpressionInfoType type)
		{
		}

		public void OnAdReview(AdReviewAnalyticsInfo adInfo)
		{
		}

		public static bool ShowTwoFsInARow(TwoAdsInARow twoAdsConfig, int fsTriggered, bool isSecondFs, bool isBeforeShowing)
		{
			return false;
		}
	}
}
