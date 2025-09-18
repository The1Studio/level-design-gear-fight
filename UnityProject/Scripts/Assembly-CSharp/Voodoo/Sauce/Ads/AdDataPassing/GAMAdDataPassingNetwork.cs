using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Ads.AdDataPassing
{
	[Preserve]
	public class GAMAdDataPassingNetwork : IAdDataPassingNetwork
	{
		private enum GAMGenderType
		{
			NS = 0,
			M = 1,
			F = 2,
			O = 3
		}

		private const string CUSTOM_TARGETING = "custom_targeting";

		private const string GAM_GENDER_KEY = "gen";

		public void SetGender(AdDataType adType, string adUnit, GenderType gender)
		{
		}

		public void SetCallbacks(Action<string> banner, Action<string> interstitial, Action<string> rewarded)
		{
		}

		private Dictionary<string, object> GetGAMKeywordsDict(GenderType gender)
		{
			return null;
		}

		private string GetGAMGenderType(GenderType type)
		{
			return null;
		}
	}
}
