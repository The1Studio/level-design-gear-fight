namespace Voodoo.Sauce.Internal.Ads
{
	public enum AudioAdState
	{
		Disabled = 0,
		ShowingAd = 1,
		PositionConfigMissing = 2,
		LoadingAd = 3,
		TooEarly = 4,
		Ready = 5,
		Misconfigured = 6,
		SilentOrBelowVolumeThreshold = 7
	}
}
