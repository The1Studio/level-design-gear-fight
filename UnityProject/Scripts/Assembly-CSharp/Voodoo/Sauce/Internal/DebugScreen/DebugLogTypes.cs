using System.Collections.Generic;
using UnityEngine;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public static class DebugLogTypes
	{
		private const string DEBUG_LOG_TYPES_KEY = "Voodoo_DebuggerLogTypes";

		private static readonly Dictionary<LogType, bool> EnabledLogTypes;

		private static bool _isInitialized;

		public static bool IsEnabled(LogType type)
		{
			return false;
		}

		public static void Update(LogType type, bool isEnabled)
		{
		}

		public static void Reset()
		{
		}

		private static void Load()
		{
		}

		private static void Save()
		{
		}
	}
}
