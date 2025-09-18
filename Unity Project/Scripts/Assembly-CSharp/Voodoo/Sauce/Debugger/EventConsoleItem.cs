using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Debugger
{
	public class EventConsoleItem : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI eventNameText;

		[SerializeField]
		private TextMeshProUGUI details;

		[SerializeField]
		private TextMeshProUGUI timestamp;

		[SerializeField]
		private GameObject sendingStatus;

		[SerializeField]
		private GameObject sentStatus;

		[SerializeField]
		private GameObject errorStatus;

		[SerializeField]
		private Button infoButton;

		internal void UpdateData(DebugAnalyticsLog log, UnityAction infoAction)
		{
		}
	}
}
