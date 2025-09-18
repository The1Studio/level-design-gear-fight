using System;
using System.Collections.Generic;

namespace PaperPlaneTools
{
	public class AlertAndroid
	{
		public enum ButtonType
		{
			POSITIVE = -1,
			NEGATIVE = -2,
			NEUTRAL = -3
		}

		private Dictionary<int, AlertButton> buttons;

		public Action OnDismiss;

		public string Title { get; set; }

		public string Message { get; set; }

		public bool Cancelable { get; set; }

		public AlertAndroid(string title = null, string message = null)
		{
		}

		public void SetPositiveButton(string title, Action handler)
		{
		}

		public void SetNegativeButton(string title, Action handler)
		{
		}

		public void SetNeutralButton(string title, Action handler)
		{
		}

		public void SetButton(ButtonType whichButton, string title, Action handler)
		{
		}

		public void Show(string gameObjectName)
		{
		}

		public void Dismiss()
		{
		}

		public void HandleButtonClick(int whichButton)
		{
		}

		public void HandleCancel()
		{
		}

		public void HandleDismiss()
		{
		}
	}
}
