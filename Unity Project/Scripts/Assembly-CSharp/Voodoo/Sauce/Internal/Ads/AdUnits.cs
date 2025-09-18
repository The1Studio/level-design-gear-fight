using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads
{
	[Serializable]
	public class AdUnits
	{
		public enum AdUnit
		{
			Banner = 0,
			Interstitial = 1,
			RewardedVideo = 2,
			Mrec = 3,
			NativeAds = 4,
			AppOpen = 5
		}

		[Tooltip("Leave blank if you don't want banner ads in your game")]
		public string bannerAdUnit;

		[Tooltip("Leave blank if you don't want interstitial ads in your game")]
		public string interstitialAdUnit;

		[Tooltip("Leave blank if you don't want rewarded video ads in your game")]
		public string rewardedVideoAdUnit;

		[Tooltip("Leave blank if you don't want Mrec ads in your game")]
		public string mrecAdUnit;

		[Tooltip("Leave blank if you don't want Native ads in your game")]
		public string nativeAdsAdUnit;

		[Tooltip("Leave blank if you don't want AppOpen ads in your game")]
		public string appOpenAdUnit;

		public string[] ExportToStringList(bool isPremium)
		{
			return null;
		}

		public bool IsEmpty()
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
