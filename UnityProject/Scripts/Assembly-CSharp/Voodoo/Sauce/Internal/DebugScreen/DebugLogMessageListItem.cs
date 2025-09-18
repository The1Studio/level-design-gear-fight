using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Debugger;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugLogMessageListItem : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _headerText;

		[SerializeField]
		private TextMeshProUGUI _bodyText;

		[SerializeField]
		private Button _button;

		[SerializeField]
		private Image _image;

		private Action<LogMessage> _callback;

		public LogMessage LogMessage { get; private set; }

		public void Initialize(Color color, LogMessage logMessage, Action<LogMessage> callback)
		{
		}

		private void OnButtonClick()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
