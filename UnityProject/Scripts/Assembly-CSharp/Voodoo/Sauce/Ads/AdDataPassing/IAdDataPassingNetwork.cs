using System;

namespace Voodoo.Sauce.Ads.AdDataPassing
{
	public interface IAdDataPassingNetwork
	{
		void SetGender(AdDataType banner, string adUnit, GenderType gender);

		void SetCallbacks(Action<string> banner, Action<string> interstitial, Action<string> rewarded);
	}
}
