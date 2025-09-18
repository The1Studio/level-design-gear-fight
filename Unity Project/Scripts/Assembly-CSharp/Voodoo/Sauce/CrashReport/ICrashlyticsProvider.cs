using System;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.CrashReport
{
	public interface ICrashlyticsProvider
	{
		void Configure(VoodooSettings settings);

		void Initialize(ref Action<bool> analyticsConsentEvent);

		internal CrashReportCore.CrashReporter CrashReporterType();

		internal float UserPercentage();

		void LogLevelStart(string level);

		void LogLevelFinish(string level);

		void LogException(Exception exception);

		void SetCustomData(string key, string value);

		void SetUserId(string userId);

		void SetUserProfile(string profile);

		void Log(string message);

		void LogAdEvent(string eventName, AdEventParams adEventParams);
	}
}
