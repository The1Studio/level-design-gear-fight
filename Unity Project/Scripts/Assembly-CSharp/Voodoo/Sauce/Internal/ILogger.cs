using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal
{
	public interface ILogger
	{
		int ModuleFilter { get; set; }

		LogType LogLevel { get; set; }

		event Action<string, string, LogType> logReceived;

		void Log(string message, Module module, LogType logType);
	}
}
