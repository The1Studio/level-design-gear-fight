using System;
using System.Collections.Generic;

namespace PaperPlaneTools
{
	public class Alert
	{
		public enum ButtonType
		{
			Positive = 0,
			Negative = 1,
			Neutral = 2
		}

		public string Title { get; private set; }

		public string Message { get; private set; }

		public AlertButton PositiveButton { get; private set; }

		public AlertButton NegativeButton { get; private set; }

		public AlertButton NeutralButton { get; private set; }

		public List<object> Options { get; private set; }

		public Action OnDismiss { get; private set; }

		public IAlertPlatformAdapter Adapter { get; private set; }

		public Alert(string title = null, string message = null)
		{
		}

		public Alert SetTitle(string title)
		{
			return null;
		}

		public Alert SetMessage(string title)
		{
			return null;
		}

		public Alert SetPositiveButton(string title, Action handler = null)
		{
			return null;
		}

		public Alert SetNegativeButton(string title, Action handler = null)
		{
			return null;
		}

		public Alert SetNeutralButton(string title, Action handler = null)
		{
			return null;
		}

		public Alert AddOptions(object opt)
		{
			return null;
		}

		public Alert SetOptions(List<object> options)
		{
			return null;
		}

		public Alert SetOnDismiss(Action handler)
		{
			return null;
		}

		public Alert SetAdapter(IAlertPlatformAdapter adaper)
		{
			return null;
		}

		public void Show()
		{
		}

		public void Dismiss()
		{
		}
	}
}
