using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Ads
{
	public class AdTimers
	{
		private Dictionary<string, DateTime> _startLoadingTimes;

		private Dictionary<string, TimeSpan> _loadingTimes;

		public void SetStartLoadingTime(AdUnit adUnit, bool isPrimary = true)
		{
		}

		public void SetEndLoadingTime(AdUnit adUnit, bool isPrimary = true)
		{
		}

		public void SetRestartLoadingTime(AdUnit adUnit, bool isPrimary = true)
		{
		}

		public TimeSpan GetLoadingTime(AdUnit adUnit, bool isPrimary = true)
		{
			return default(TimeSpan);
		}
	}
}
