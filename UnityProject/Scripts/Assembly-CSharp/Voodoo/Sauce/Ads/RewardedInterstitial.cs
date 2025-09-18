using System;

namespace Voodoo.Sauce.Ads
{
	[Serializable]
	public class RewardedInterstitial
	{
		public int frequency;

		public int capping;

		public int absoluteRewardSoftCurrency;

		public int absoluteRewardHardCurrency;

		public float relativeRewardSoftCurrency;

		public float relativeRewardHardCurrency;

		public int bypassAfterPopUpCount;

		public string rewardSchedule;

		public InterstitialRewardType GetCurrentRewardType(int index)
		{
			return default(InterstitialRewardType);
		}

		public InterstitialCurrencyType GetCurrentCurrencyType(int index)
		{
			return default(InterstitialCurrencyType);
		}
	}
}
