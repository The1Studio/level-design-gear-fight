using System;
using PaperPlaneTools;
using UnityEngine;

namespace Voodoo.Sauce.Internal.AppRater
{
	public class AndroidAppRater : MonoBehaviour, IAlertPlatformAdapter
	{
		private const string TAG = "AndroidAppRater";

		private const string UNITY_ACTIVITY_CLASS = "com.unity3d.player.UnityPlayer";

		private const string VOODOO_APP_RATER_CLASS = "io.voodoo.voodooapprater.AppRater";

		private const string VOODOO_EMAIL_ADDRESS = "support@voodoo.io";

		private Action _positiveCallback;

		private Action _neutralCallback;

		private Action _negativeCallback;

		private Action _dismissCallback;

		private void Awake()
		{
		}

		public void SetOnDismiss(Action action)
		{
		}

		public void Show(Alert alert)
		{
		}

		public void Dismiss()
		{
		}

		public void HandleEvent(string eventName, string value)
		{
		}

		private static void ShowNativeAlertDialog()
		{
		}

		public void OnPositiveButtonClick(string ratingString)
		{
		}

		public void OnNeutralButtonClick()
		{
		}
	}
}
