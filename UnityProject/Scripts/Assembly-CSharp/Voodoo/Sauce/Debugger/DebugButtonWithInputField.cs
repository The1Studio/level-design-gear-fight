using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.DebugScreen;

namespace Voodoo.Sauce.Debugger
{
	public class DebugButtonWithInputField : Widget, IDebugRefreshable
	{
		[SerializeField]
		private Button _button;

		[SerializeField]
		private TextMeshProUGUI _buttonText;

		[SerializeField]
		private TMP_InputField _inputField;

		[SerializeField]
		private TextMeshProUGUI _inputFieldPlaceholderText;

		private Action _callback;

		private Action<string> _callbackWithText;

		private Action<string> _inputCallback;

		private Func<string> _refreshFunc;

		public bool Interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnButtonClick()
		{
		}

		private void OnEndEdit(string value)
		{
		}

		public void SetTitle(string title)
		{
		}

		public void SetColor(Color color)
		{
		}

		public void SetButtonCallback(Action callback)
		{
		}

		public void SetButtonCallback(Action<string> callback)
		{
		}

		public void SetInputCallback(Action<string> callback)
		{
		}

		public void SetInputField(bool active, string placeholder = "")
		{
		}

		public void SetRefreshFunc(Func<string> func)
		{
		}

		public void SetEnable(bool enable)
		{
		}

		public void Refresh()
		{
		}

		private void SetCurrentText(string text)
		{
		}
	}
}
