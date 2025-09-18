using System;
using Voodoo.Sauce.CrashReport;

namespace Voodoo.Sauce.IAP
{
	public class IAPCrashReporter : ICrashReporter
	{
		public void SetCrashReportingCustomData(string key, string value)
		{
		}

		public void LogCrashReportingMessage(string message)
		{
		}

		public void LogException(Exception exception)
		{
		}
	}
}
