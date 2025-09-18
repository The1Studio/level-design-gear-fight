using System;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.CrashReport;

namespace Voodoo.Sauce.Firebase
{
	public class FirebaseCrashlyticsProvider : ICrashlyticsProvider
	{
		private const string TAG = "FirebaseCrashlyticsProvider";

		public void Configure(VoodooSettings settings)
		{
		}

		public void Initialize(ref Action<bool> analyticsConsentEvent)
		{
		}

		CrashReportCore.CrashReporter ICrashlyticsProvider.CrashReporterType()
		{
			return default(CrashReportCore.CrashReporter);
		}

		float ICrashlyticsProvider.UserPercentage()
		{
			return 0f;
		}

		public void LogLevelStart(string level)
		{
		}

		public void LogLevelFinish(string level)
		{
		}

		public void LogException(Exception exception)
		{
		}

		public void SetCustomData(string key, string value)
		{
		}

		public void SetUserId(string userId)
		{
		}

		public void SetUserProfile(string profile)
		{
		}

		public void Log(string message)
		{
		}

		public void LogAdEvent(string eventName, AdEventParams adEventParams)
		{
		}
	}
}
