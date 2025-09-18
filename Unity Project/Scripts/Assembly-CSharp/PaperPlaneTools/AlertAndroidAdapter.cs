using System;
using UnityEngine;

namespace PaperPlaneTools
{
	public class AlertAndroidAdapter : IAlertPlatformAdapter
	{
		private AlertAndroid alertAndroid;

		private Action onDismiss;

		private GameObject gameObject;

		void IAlertPlatformAdapter.SetOnDismiss(Action action)
		{
		}

		void IAlertPlatformAdapter.Show(Alert alert)
		{
		}

		void IAlertPlatformAdapter.Dismiss()
		{
		}

		void IAlertPlatformAdapter.HandleEvent(string eventName, string value)
		{
		}

		private void onDismissCallback()
		{
		}
	}
}
