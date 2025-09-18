using System;

namespace Voodoo.Sauce.Ads.AdDataPassing
{
	[Preserve]
	public class MaxAdsAdDataPassingNetwork : IAdDataPassingNetwork
	{
		public void SetGender(AdDataType adType, string adUnit, GenderType gender)
		{
		}

		public void SetCallbacks(Action<string> banner, Action<string> interstitial, Action<string> rewarded)
		{
		}
	}
}
