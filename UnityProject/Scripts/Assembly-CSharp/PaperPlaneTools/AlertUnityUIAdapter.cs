using System;
using UnityEngine;
using UnityEngine.UI;

namespace PaperPlaneTools
{
	public class AlertUnityUIAdapter : MonoBehaviour, IAlertPlatformAdapter
	{
		[Tooltip("Text component to set alert title. If null title isn't presented.")]
		public Text titleText;

		[Tooltip("Text component to set alert message. If null message isn't presented.")]
		public Text messageText;

		[Tooltip("Button component to set alert positive button text and callback. If null no button is presented.")]
		public Button positiveButton;

		[Tooltip("Button component to set alert neutral button text and callback. If null no button is presented.")]
		public Button neutralButton;

		[Tooltip("Button component to set alert negative button text and callback. If null no button is presented.")]
		public Button negativeButton;

		[Tooltip("Backgroud panel which dismisses the dialog when clicked. If null, dialog doesn't dismiss when click/tap background.")]
		public GameObject dismissPanel;

		private Action onDismiss;

		void IAlertPlatformAdapter.SetOnDismiss(Action action)
		{
		}

		void IAlertPlatformAdapter.Dismiss()
		{
		}

		void IAlertPlatformAdapter.Show(Alert alert)
		{
		}

		void IAlertPlatformAdapter.HandleEvent(string name, string value)
		{
		}

		private void SetButton(Button uiButton, AlertButton alertButton)
		{
		}
	}
}
