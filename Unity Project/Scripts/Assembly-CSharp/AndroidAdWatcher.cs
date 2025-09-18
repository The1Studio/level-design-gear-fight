using UnityEngine;

public abstract class AndroidAdWatcher : AndroidAdState
{
	protected static string APPHARBR_GATEWAY_CLASS;

	protected static AndroidJavaClass ahUnityMediatorsClass;

	public static void WatchBanner(string adUnitId)
	{
	}

	public static void WatchInterstitial(string adUnitId)
	{
	}

	public static void WatchRewarded(string adUnitId)
	{
	}

	public static void WatchRewardedInterstitial(string adUnitId)
	{
	}

	public static void WatchBanner(string adUnitId, string bannerPosition)
	{
	}

	public static void WatchMRec(string adUnitId, string mrecPosition)
	{
	}

	public static void WatchBanner(string adUnitId, float x, float y)
	{
	}

	public static void WatchMRec(string adUnitId, float x, float y)
	{
	}

	private static void WatchAd(string adFormat, string adUnitId, string position = null)
	{
	}

	private static void WatchAdWithPosition(string adFormat, string adUnitId, float x, float y)
	{
	}

	public static void UnwatchBanner(string adUnitId)
	{
	}

	public static void UnwatchInterstitial(string adUnitId)
	{
	}

	public static void UnwatchRewarded(string adUnitId)
	{
	}

	public static void UnwatchRewardedInterstitial(string adUnitId)
	{
	}

	public static void Unwatch(AHAdFormat adFormat, string adUnitId)
	{
	}
}
