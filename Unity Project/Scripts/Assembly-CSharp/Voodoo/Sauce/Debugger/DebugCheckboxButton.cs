using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class DebugCheckboxButton : Widget
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
	}
}
