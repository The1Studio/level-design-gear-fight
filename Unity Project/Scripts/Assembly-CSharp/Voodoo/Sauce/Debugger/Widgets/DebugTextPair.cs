using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.DebugScreen;

namespace Voodoo.Sauce.Debugger.Widgets
{
	public class DebugTextPair : Widget, IDebugRefreshable
	{
		[SerializeField]
		private TextMeshProUGUI _key;

		[SerializeField]
		private TextMeshProUGUI _value;

		[SerializeField]
		private Button _copyButton;

		private string _valueToCopy;

		private Func<string> _refreshCallback;

		private Func<string> _refreshCopyCallback;

		private void Start()
		{
		}

		private void OnCopyButtonClicked()
		{
		}

		public void SetValueToCopy(string value)
		{
		}

		public void SetLabelBestFitTxt(bool bestFit)
		{
		}

		public void SetLabel(string label)
		{
		}

		public void SetValue(string value)
		{
		}

		public void SetStyle(Color color, FontStyles style)
		{
		}

		public void ShowCopyButton(bool value)
		{
		}

		public void SetRefreshFunc(Func<string> callback)
		{
		}

		public void SetRefreshToCopyFunc(Func<string> callback)
		{
		}

		public void Refresh()
		{
		}
	}
}
