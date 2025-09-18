using Firebase.Messaging;
using UnityEngine;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class FirebaseMessagingWrapper : MonoBehaviour
	{
		private const string TAG = "FirebaseMessagingWrapper";

		private const string PUSH_NOTIFICATION_PERMISSION = "android.permission.POST_NOTIFICATIONS";

		private void Start()
		{
		}

		private void OnFirebaseInitialized(bool success)
		{
		}

		private void InitializeFirebaseMessaging()
		{
		}

		public static void RequestPushPermissions()
		{
		}

		private void OnTokenReceived(object sender, TokenReceivedEventArgs args)
		{
		}
	}
}
