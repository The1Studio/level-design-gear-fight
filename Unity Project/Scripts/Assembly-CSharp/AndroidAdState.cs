using UnityEngine;

public abstract class AndroidAdState
{
	protected static string APPHARBR_CLASS_NAME;

	protected static AndroidJavaClass appHarbrClass;

	public static AHAdStateResult GetInterstitialState(string adUnitId)
	{
		return default(AHAdStateResult);
	}

	public static AHAdStateResult GetRewardedState(string adUnitId)
	{
		return default(AHAdStateResult);
	}

	public static AHAdStateResult GetRewardedInterstitialState(string adUnitId)
	{
		return default(AHAdStateResult);
	}

	private static AHAdStateResult GetAdState(string adFormat, string adUnitId)
	{
		return default(AHAdStateResult);
	}
}
