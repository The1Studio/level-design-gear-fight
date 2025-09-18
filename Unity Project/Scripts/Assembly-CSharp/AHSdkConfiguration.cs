public class AHSdkConfiguration
{
	public string AndroidApiKey { get; }

	public string IOSApiKey { get; }

	public AHAdSdk[] TargetedAdNetworks { get; }

	public AHSdkDebug AhSdkDebug { get; }

	public bool MuteAd { get; }

	public int InterstitialAdTimeLimit { get; }

	public AHAdSdk[] SpecificAdNetworkToLimitInterstitialTime { get; }

	public int RewardedAdTimeLimit { get; }

	public AHAdSdk[] SpecificAdNetworkToLimitRewardedTime { get; }

	public int LimitFullscreenAdsInSeconds { get; }

	public AHAdSdk[] SpecificAdNetworkToLimitTime { get; }

	public AHSdkConfiguration(string androidApiKey = null, string iOSApiKey = null, AHAdSdk[] targetedAdNetworks = null, AHSdkDebug ahSdkDebug = null, bool muteAd = false, int limitFullscreenAdsInSeconds = 0, AHAdSdk[] specificAdNetworkToLimitTime = null, int interstitialAdTimeLimit = 0, AHAdSdk[] specificAdNetworkToLimitInterstitialTime = null, int rewardedAdTimeLimit = 0, AHAdSdk[] specificAdNetworkToLimitRewardedTime = null)
	{
	}

	private void invokeFailCallback()
	{
	}

	public bool HasAndroidAPIKey()
	{
		return false;
	}

	public bool HasIOSAPIKey()
	{
		return false;
	}

	private void InitCallbacks()
	{
	}
}
