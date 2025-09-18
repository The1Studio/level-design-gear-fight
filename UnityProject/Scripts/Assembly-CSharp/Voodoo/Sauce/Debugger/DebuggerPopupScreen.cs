using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class DebuggerPopupScreen : MonoBehaviour
	{
		private const string PREFIX_IDFV = "Idfv: ";

		private const string PREFIX_IDFA = "Idfa: ";

		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private TextMeshProUGUI message;

		[SerializeField]
		private IdSectionDebugger idfvSectionDebugger;

		[SerializeField]
		private IdSectionDebugger idfaSectionDebugger;

		[SerializeField]
		private Button cancelButton;

		[SerializeField]
		private Button confirmButton;

		private DebuggerPopupConfig _currentConfig;

		private Action _closeCallback;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Show(DebuggerPopupConfig config, Action closeCallback = null)
		{
		}

		private void OnCancelButtonClicked()
		{
		}

		private void OnConfirmButtonClicked()
		{
		}

		private void Open()
		{
		}

		private void Close()
		{
		}
	}
}
