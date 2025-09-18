using System;

namespace Voodoo.Sauce.Internal.Ads
{
	[Serializable]
	public class AdFrequencyConfiguration
	{
		public int cumulativeDelayInSecondsBeforeFirstInterstitialAd;

		public int delayInSecondsBeforeFirstInterstitialAd;

		public int delayInSecondsBeforeSessionFirstInterstitialAd;

		public int delayInSecondsBetweenInterstitialAds;

		public int maxGamesBetweenInterstitialAds;

		public int delayInSecondsBetweenRewardedVideoAndInterstitial;

		public bool enableReplaceRewardedIfInterstitialCpmHigher;

		public bool enableReplaceRewardedIfNotLoaded;

		public override string ToString()
		{
			return null;
		}
	}
}
