using System;
using UnityEngine;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Ads
{
	public class AppOpenRewardedInterstitialWrapper : MonoBehaviour
	{
		private const string TAG = "AppOpenRewardedInterstitialWrapper";

		private const string FS_TYPE = "app_open_rewarded_interstitial";

		private const string POST_AD_SCREEN_COUNT_KEY = "post_ad_screen_count";

		private static AppOpenRewardedInterstitialWrapper Instance;

		private static Func<int> _getCurrencyAmount;

		private static Action<int> _giveReward;

		[SerializeField]
		private AppOpenRewardedInterstitialCanvas canvas;

		[SerializeField]
		private float waitDuration;

		private AppOpenRewardedInterstitial _config;

		private float _lastTimeBackground;

		private bool _initialized;

		private int _rewardAmount;

		private static int PostAdScreenCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static void SetAppOpenRewardedInterstitial(Func<int> getCurrencyAmount, Action<int> giveReward)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Initialize(VoodooSauceInitCallbackResult obj)
		{
		}

		public void OnApplicationFocus(bool hasFocus)
		{
		}

		private void TryShowing()
		{
		}

		private void ShowInterstitial()
		{
		}

		private void TryShowPostAdScreen(bool adWatched)
		{
		}

		private int GetReward()
		{
			return 0;
		}

		private void GiveReward()
		{
		}
	}
}
