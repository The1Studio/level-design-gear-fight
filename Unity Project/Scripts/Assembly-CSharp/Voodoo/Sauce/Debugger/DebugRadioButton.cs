using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class DebugRadioButton : Widget
	{
		[SerializeField]
		private Toggle toggle;

		[SerializeField]
		private TextMeshProUGUI label;

		[SerializeField]
		private Image backgroundImage;

		[SerializeField]
		private Color defaultColor;

		[SerializeField]
		private Color checkedColor;

		private Action<bool> _callback;

		private Action<bool, DebugRadioButton> _groupCallback;

		public bool Toggled => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetCallback(Action<bool> callback)
		{
		}

		public void SetGroupCallback(Action<bool, DebugRadioButton> callback)
		{
		}

		public void SetValue(bool value)
		{
		}

		public void SetValueWithoutCallingCallback(bool value)
		{
		}

		internal void SetValueAndCallCallback(bool value, bool callCallback)
		{
		}

		public void SetLabel(string text)
		{
		}

		public void CallCallbackFromGroup(bool value)
		{
		}
	}
}
