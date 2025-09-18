using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class DebugToggleButton : Widget
	{
		[SerializeField]
		private Toggle _toggle;

		[SerializeField]
		private TextMeshProUGUI _label;

		[SerializeField]
		private Image _image;

		[SerializeField]
		private Sprite _toggleOn;

		[SerializeField]
		private Sprite _toggleOff;

		public void Initialize(string title, bool value, Action<bool> onValueChanged)
		{
		}

		public void SetTitle(string title)
		{
		}

		public void SetValue(bool isOn)
		{
		}

		private void ChangeUI(bool isOn)
		{
		}

		public void SetCallback(Action<bool> callback)
		{
		}
	}
}
