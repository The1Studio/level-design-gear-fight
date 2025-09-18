using System.Collections.Generic;
using UnityEngine;
using Voodoo.Sauce.CrashReport;
using Voodoo.Sauce.Internal.DebugScreen;

namespace Voodoo.Sauce.Debugger
{
	public class CrashReporterDebugScreen : Screen
	{
		private const string CRASH_REPORTER_CHOSEN_MESSAGE = "The crash reporter is set to {0}, restart the application to apply the modifications.";

		private const string CRASH_REPORTER_UNAVAILABILITY_MESSAGE = "The crash reporter is not available in the Unity Editor.";

		private const string CRASH_REPORTER_UPDATE_MESSAGE = "Changing the crash reporter will affect error reporting.";

		[SerializeField]
		private DebugPopup debugPopup;

		private CrashReportCore.CrashReporter _crashReporter;

		private readonly Dictionary<CrashReportCore.CrashReporter, Widget> _crashReportersToggle;

		private void Start()
		{
		}

		private void CrashReporterSwitch(bool isOn, CrashReportCore.CrashReporter crashReporter)
		{
		}

		private void DisplayPopup(string message)
		{
		}
	}
}
