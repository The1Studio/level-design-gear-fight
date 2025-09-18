using System.Collections.Generic;
using UnityEngine;

namespace Comscore
{
	internal class BridgedAnalytics : IAnalytics<Configuration, ClientConfiguration, PublisherConfiguration, PartnerConfiguration, EventInfo>
	{
		private AndroidJavaClass javaClass;

		private const string className = "com.comscore.Analytics";

		private Configuration configuration;

		private AndroidJavaClass AnalyticsJavaClass => null;

		public Configuration Configuration => null;

		public string Version => null;

		public LogLevel LogLevel
		{
			get
			{
				return default(LogLevel);
			}
			set
			{
			}
		}

		public void Start()
		{
		}

		public void NotifyViewEvent()
		{
		}

		public void NotifyViewEvent(EventInfo eventInfo)
		{
		}

		public void NotifyViewEvent(Dictionary<string, string> labels)
		{
		}

		public void NotifyHiddenEvent()
		{
		}

		public void NotifyHiddenEvent(EventInfo eventInfo)
		{
		}

		public void NotifyHiddenEvent(Dictionary<string, string> labels)
		{
		}

		public void NotifyEnterForeground()
		{
		}

		public void NotifyExitForeground()
		{
		}

		public void NotifyUxActive()
		{
		}

		public void NotifyUxInactive()
		{
		}

		public void FlushOfflineCache()
		{
		}

		public void ClearOfflineCache()
		{
		}

		public void ClearInternalData()
		{
		}
	}
}
