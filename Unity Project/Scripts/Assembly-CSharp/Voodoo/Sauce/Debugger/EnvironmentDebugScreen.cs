using System.Collections.Generic;
using UnityEngine;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Internal.DebugScreen;
using Voodoo.Tune.Core;

namespace Voodoo.Sauce.Debugger
{
	public class EnvironmentDebugScreen : Screen, IConditionalScreen
	{
		private const string NEW_SERVER_MESSAGE = "Your {0} server is set to {1}, restart the application to apply the modifications.";

		private const string NEW_VOODOO_TUNE_VERSION_MESSAGE = "Your VoodooTune version is set to {0}, restart the application to apply the modifications.";

		[SerializeField]
		private DebugPopup _debugPopup;

		private readonly Dictionary<EnvironmentSettings.Server, string> _server;

		private VoodooTuneServerType _voodooTuneServer;

		private Dictionary<VoodooTuneServerType, DebugToggleButton> _vtToggle;

		private Status _voodooTuneVersion;

		private Dictionary<Status, DebugToggleButton> _versionToggle;

		private EnvironmentSettings.Server _analyticsServer;

		private Dictionary<EnvironmentSettings.Server, DebugToggleButton> _analyticsToggle;

		public bool CanDisplay => false;

		private string VtNewVersion => null;

		private void Start()
		{
		}

		private void InitProxyServerSection(VoodooSettings settings)
		{
		}

		private void InitVoodooTune(VoodooSettings settings)
		{
		}

		private void InitVoodooTuneServerButtons()
		{
		}

		private void InitVoodooTuneVersionButtons()
		{
		}

		private void VoodooTuneServerSwitch(bool isOn, VoodooTuneServerType server)
		{
		}

		private void VoodooTuneSwitchVersion(bool isOn, Status version)
		{
		}

		private void InitAnalytics(VoodooSettings settings)
		{
		}

		private void InitAnalyticsServerButtons()
		{
		}

		private void AnalyticsServerSwitch(bool isOn, EnvironmentSettings.Server server)
		{
		}

		private void DisplayPopup(string message)
		{
		}
	}
}
