namespace Voodoo.Nakama.Server
{
	public static class NakamaLog
	{
		public enum LogLevel
		{
			Info = 0,
			Warning = 1,
			Error = 2,
			None = 3
		}

		public static LogLevel logLevel;

		public static void LogInfo(string message)
		{
		}

		public static void LogWarning(string message)
		{
		}

		public static void LogError(string message)
		{
		}

		public static string GetColoredText(string text, string color)
		{
			return null;
		}
	}
}
