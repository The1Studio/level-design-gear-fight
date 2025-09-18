using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Debugger
{
	public class EventConsoleErrorScreen : Screen
	{
		[SerializeField]
		private Button errorCopyButton;

		[SerializeField]
		private TextMeshProUGUI errorMessage;

		public void ShowErrorMessage(DebugAnalyticsLog log)
		{
		}
	}
}
