using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voodoo.Sauce.Debugger
{
	public static class LogsTracker
	{
		private static Queue<LogMessage> _issuesQueue;

		public static IReadOnlyCollection<LogMessage> Issues => null;

		public static int Count => 0;

		public static event Action<LogMessage> OnLogReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}

		private static void LogReceived(string message, string trace, LogType logType)
		{
		}

		public static void Clear()
		{
		}

		public static int CountFor(LogType logType)
		{
			return 0;
		}
	}
}
