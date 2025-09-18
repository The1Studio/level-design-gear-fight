using System.Collections.Generic;
using Voodoo.Tune.Core;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	public class VoodooTuneAdsParameters : IVoodooTuneFilledVariables
	{
		private enum AdsParameter
		{
			watched_rv_last_1_month = 0,
			watched_rv_last_2_months = 1,
			watched_rv_last_3_months = 2,
			average_watched_rv_last_3_sessions = 3
		}

		public Dictionary<string, string> GetParameters()
		{
			return null;
		}
	}
}
