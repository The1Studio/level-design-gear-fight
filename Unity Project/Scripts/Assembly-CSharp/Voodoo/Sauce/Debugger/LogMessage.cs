using UnityEngine;

namespace Voodoo.Sauce.Debugger
{
	public struct LogMessage
	{
		public LogType logType;

		public string time;

		public string message;

		public string stacktrace;

		public LogMessage(string message, string trace, LogType logType)
		{
			this.logType = default(LogType);
			time = null;
			this.message = null;
			stacktrace = null;
		}
	}
}
