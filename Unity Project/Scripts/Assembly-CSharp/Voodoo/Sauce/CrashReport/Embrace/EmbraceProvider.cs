using System;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.CrashReport.Embrace
{
	public class EmbraceProvider : ICrashlyticsProvider
	{
		private const string TAG = "EmbraceProvider";

		private const string AD_INFO_EVENT_NAME = "ad_info";

		private readonly EmbraceConfiguration _configuration;

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
