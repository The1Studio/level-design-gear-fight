using System;
using System.Collections.Generic;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.CrashReport
{
	[Preserve]
	internal class CrashReportManager : CrashReportCore
	{
		private const string TAG = "CrashReportManager";

		private const string PLAYER_PREF_CRASH_REPORTER_V1 = "PLAYER_PREF_CRASHLYTICSVoodoo.Sauce.CrashReport.CrashReporter";

		private const string PLAYER_PREF_CRASH_REPORTER_V2 = "PLAYER_PREF_CRASHLYTICSVoodoo.Sauce.CrashReport.CrashReporter.v2";

		private VoodooSettings _voodooSettings;

		private ICrashlyticsProvider _crashReporter;

		private readonly Dictionary<CrashReporter, float> _crashReporterPercentages;

		public override void Initialize(CrashReportManagerParameters parameters)
		{
		}

		public override CrashReporter GetCrashReporter()
		{
			return default(CrashReporter);
		}

		internal override void ForceCrashReporter(CrashReporter crashReporter)
		{
		}

		public override void LogLevelStart(string level)
		{
		}

		public override void LogLevelFinish(string level)
		{
		}

		public override void LogException(Exception exception)
		{
		}

		public override void SetCustomData(string key, string value)
		{
		}

		public override void Log(string message)
		{
		}

		public override void LogAdEvent(string eventName, AdEventParams adEventParams)
		{
		}

		public override void SetUserId(string userId)
		{
		}

		public override void SetUserProfile(string profile)
		{
		}

		public override float GetUserPercentage(CrashReporter crashReporter)
		{
			return 0f;
		}

		private static void RemoveOutdatedSavedConfigurations()
		{
		}

		private ICrashlyticsProvider SelectCrashReporter()
		{
			return null;
		}
	}
}
