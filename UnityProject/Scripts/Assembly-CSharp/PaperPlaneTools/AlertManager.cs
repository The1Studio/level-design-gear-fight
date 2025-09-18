using System;
using System.Collections.Generic;

namespace PaperPlaneTools
{
	public class AlertManager
	{
		private IAlertPlatformAdapter currentAdapter;

		private Alert currentAlert;

		private List<Alert> queue;

		private static AlertManager instance;

		public static AlertManager Instance => null;

		public Func<IAlertPlatformAdapter> AlertFactory { get; set; }

		private AlertManager()
		{
		}

		public void Show(Alert alert)
		{
		}

		public void Dismiss(Alert alert)
		{
		}

		public void HandleEvent(string eventName, string value)
		{
		}

		private IAlertPlatformAdapter CreateAdapter()
		{
			return null;
		}

		private void OnDismiss()
		{
		}

		private void ShowNext()
		{
		}
	}
}
