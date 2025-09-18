using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Serialization;

namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	public class FakeMediationBehaviour : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CShowBanner_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public FakeMediationBehaviour _003C_003E4__this;

			public CancellationTokenSource token;

			private TaskAwaiter _003C_003Eu__1;

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

		[SerializeField]
		[FormerlySerializedAs("_bannerVideoAd")]
		private FakeBannerAd bannerAd;

		[SerializeField]
		[FormerlySerializedAs("_interstitialAd")]
		private FakeInterstitialAd interstitialAd;

		[SerializeField]
		[FormerlySerializedAs("_rewardedAd")]
		private FakeRewardedVideoAd rewardedAd;

		[SerializeField]
		private FakeAppOpenAd appOpenAd;

		[SerializeField]
		private FakeNativeAd nativeAd;

		[SerializeField]
		private FakeMrecAd mrecAd;

		private float _prevTimeScale;

		private CancellationTokenSource _refreshBannerCancellationToken;

		public FakeMediationCallbacks Callbacks { get; private set; }

		private void Awake()
		{
		}

		public void CreateBanner()
		{
		}

		public void ShowBanner()
		{
		}

		[AsyncStateMachine(typeof(_003CShowBanner_003Ed__15))]
		private Task ShowBanner(CancellationTokenSource token)
		{
			return null;
		}

		public void HideBanner()
		{
		}

		public void LoadInterstitial()
		{
		}

		public void ShowInterstitial()
		{
		}

		public void LoadRewarded()
		{
		}

		public void ShowRewarded()
		{
		}

		public void LoadAppOpen()
		{
		}

		public void ShowAppOpen()
		{
		}

		public void LoadNativeAd()
		{
		}

		public void ShowNativeAd(string layoutName, float x, float y, float width, float height)
		{
		}

		public void HideNative()
		{
		}

		public void CreateMRec()
		{
		}

		public void ShowMrec(float x, float y)
		{
		}

		public void HideMrec()
		{
		}

		private void PauseTime()
		{
		}

		private void ResumeTime()
		{
		}
	}
}
