using System;
using Voodoo.Analytics;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class AnalyticsConfig : IConfig
	{
		private int waitIntervalSeconds;

		private int maxNumberOfEventsPerFile;

		private string enabledEvents;

		private int sessionIdRenewalIntervalInSeconds;

		private int eventLifeTimeInDays;

		private int fileIntervalInSeconds;

		public void SetSenderWaitIntervalSeconds(int seconds)
		{
		}

		public int GetSenderWaitIntervalSeconds()
		{
			return 0;
		}

		public int GetMaxNumberOfEventsPerFile()
		{
			return 0;
		}

		public string[] EnabledEvents()
		{
			return null;
		}

		public int GetSessionIdRenewalIntervalInSeconds()
		{
			return 0;
		}

		public int GetEventLifeTimeInDays()
		{
			return 0;
		}

		public int GetFileIntervalInSeconds()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
