using Voodoo.Sauce.Internal.Ads;

namespace Voodoo.Sauce.Ads.Internal
{
	public class AppHarbrMaxWrapper : AppHarbrWrapper
	{
		private static AppHarbrMaxWrapper _instance;

		public static AppHarbrMaxWrapper Instance => null;

		public void Initialize()
		{
		}

		public void Watch(AdUnits adUnits)
		{
		}

		private new void OnInitializationComplete(string error)
		{
		}

		private bool InterstitialCheck(string adUnit)
		{
			return false;
		}

		private bool RewardedVideoCheck(string adUnit)
		{
			return false;
		}
	}
}
