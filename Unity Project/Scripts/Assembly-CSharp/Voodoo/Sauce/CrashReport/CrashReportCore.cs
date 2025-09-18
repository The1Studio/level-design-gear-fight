using System;
using System.Collections.Generic;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Internal.IntegrationCheck;

namespace Voodoo.Sauce.CrashReport
{
	internal class CrashReportCore : IModule
	{
		public enum CrashReporter
		{
			None = 0,
			Firebase = 1,
			Embrace = 2
		}

		public class CrashReportManagerParameters
		{
			internal VoodooSettings VoodooSettings;

			internal Action<bool> AnalyticsConsentEvent;
		}

		private const CrashReporter DEFAULT_CRASH_REPORTER = CrashReporter.Firebase;

		public virtual void Initialize(CrashReportManagerParameters parameters)
		{
		}

		public virtual CrashReporter GetCrashReporter()
		{
			return default(CrashReporter);
		}

		internal virtual void ForceCrashReporter(CrashReporter crashReporter)
		{
		}

		public virtual void LogLevelStart(string level)
		{
		}

		public virtual void LogLevelFinish(string level)
		{
		}

		public virtual void LogException(Exception exception)
		{
		}

		public virtual void SetCustomData(string key, string value)
		{
		}

		public virtual void Log(string message)
		{
		}

		public virtual void LogAdEvent(string eventName, AdEventParams adEventParams)
		{
		}

		public virtual void SetUserId(string userId)
		{
		}

		public virtual void SetUserProfile(string profile)
		{
		}

		public virtual float GetUserPercentage(CrashReporter crashReporter)
		{
			return 0f;
		}

		public virtual List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings)
		{
			return null;
		}
	}
}
