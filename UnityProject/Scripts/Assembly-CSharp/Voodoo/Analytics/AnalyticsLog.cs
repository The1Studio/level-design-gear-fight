using System;

namespace Voodoo.Analytics
{
	public static class AnalyticsLog
	{
		public enum AnalyticsLogLevel
		{
			DISABLED = 0,
			ERROR = 1,
			WARNING = 2,
			DEBUG = 3
		}

		private const string TAG = "AnalyticsLog";

		private static AnalyticsLogLevel _logLevel;

		private static IVanCustomLog _customLogger;

		public static void SetLogLevel(AnalyticsLogLevel level)
		{
		}

		public static void SetCustomLogger(IVanCustomLog vanCustomLogger)
		{
		}

		public static void Log(string tag, string message)
		{
		}

		public static void LogE(string tag, string message)
		{
		}

		public static void CustomLoggerLogE(string tag, Exception exception)
		{
		}

		public static void CustomLoggerReportE(Exception exception)
		{
		}

		public static void LogW(string tag, string message)
		{
		}

		private static string Format(string tag, string message)
		{
			return null;
		}
	}
}
