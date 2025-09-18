using JetBrains.Annotations;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class AdEventAnalyticsInfo : AdAnalyticsInfo
	{
		[CanBeNull]
		public string AdUnit;

		public int? GameCount;

		public double? InterstitialCpm;

		public double? RewardedVideoCpm;
	}
}
