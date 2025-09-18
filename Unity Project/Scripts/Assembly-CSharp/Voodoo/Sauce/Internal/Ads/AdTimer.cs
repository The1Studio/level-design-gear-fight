using System;

namespace Voodoo.Sauce.Internal.Ads
{
	public class AdTimer
	{
		private DateTime _startLoadingTime;

		private TimeSpan _loadingTime;

		public double TotalMilliseconds => 0.0;

		public double TotalSeconds => 0.0;

		public void Start()
		{
		}

		public void Stop()
		{
		}

		public void Restart()
		{
		}

		private TimeSpan GetTime()
		{
			return default(TimeSpan);
		}
	}
}
