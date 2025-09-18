using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal
{
	public static class VoodooLog
	{
		private const string TAG = "VoodooSauce";

		public const string LOG_LEVEL_PLAYER_PREFS_KEY = "VoodooLogLevel2";

		public const string FILTER_PLAYER_PREFS_KEY = "VoodooLogFilter";

		private static ILogger _logger;

		public static bool IsDebugLogsEnabled => false;

		internal static LogType GetLogLevel => default(LogType);

		internal static int ModuleFilter => 0;

		public static event Action<string, string, LogType> logReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		static VoodooLog()
		{
		}

		public static void LogDebug(Module module, string tag, string message)
		{
		}

		public static void LogError(Module module, string tag, string message)
		{
		}

		public static void LogWarning(Module module, string tag, string message)
		{
		}

		private static void Log(Module module, string tag, string message, LogType logType)
		{
		}

		private static string Format(Module module, string tag, string message)
		{
			return null;
		}

		public static void EnableDebugLogs(bool enable)
		{
		}

		internal static void SetLogLevel(LogType logType)
		{
		}

		internal static void SetLogLevel(int value)
		{
		}

		internal static void ToggleModule(int value)
		{
		}

		private static void UpdateAnalyticsLogLevel()
		{
		}
	}
}
