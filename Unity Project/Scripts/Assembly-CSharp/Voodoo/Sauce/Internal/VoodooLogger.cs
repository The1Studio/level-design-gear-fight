using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voodoo.Sauce.Internal
{
	public class VoodooLogger : ILogger
	{
		private readonly bool _addTimestamp;

		public int ModuleFilter { get; set; }

		public LogType LogLevel { get; set; }

		public event Action<string, string, LogType> logReceived
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

		private void ApplicationLogReceived(string message, string stackTrace, LogType type)
		{
		}

		public void Log(string message, Module module, LogType logType)
		{
		}
	}
}
