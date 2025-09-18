using System.Collections.Generic;

namespace Comscore
{
	public abstract class Analytics
	{
		private static BridgedAnalytics bridgedAnalytics;

		private static BridgedAnalytics BridgedAnalytics => null;

		public static Configuration Configuration => null;

		public static string Version => null;

		public static LogLevel LogLevel
		{
			get
			{
				return default(LogLevel);
			}
			set
			{
			}
		}

		public static void Start()
		{
		}

		public static void NotifyViewEvent()
		{
		}

		public static void NotifyViewEvent(EventInfo eventInfo)
		{
		}

		public static void NotifyViewEvent(Dictionary<string, string> labels)
		{
		}

		public static void NotifyHiddenEvent()
		{
		}

		public static void NotifyHiddenEvent(EventInfo eventInfo)
		{
		}

		public static void NotifyHiddenEvent(Dictionary<string, string> labels)
		{
		}

		public static void NotifyEnterForeground()
		{
		}

		public static void NotifyExitForeground()
		{
		}

		public static void NotifyUxActive()
		{
		}

		public static void NotifyUxInactive()
		{
		}

		public static void FlushOfflineCache()
		{
		}

		public static void ClearOfflineCache()
		{
		}

		public static void ClearInternalData()
		{
		}
	}
}
