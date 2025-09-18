using UnityEngine;

namespace ConsentManagementProviderLib.Android
{
	internal class SpClientProxy : AndroidJavaProxy
	{
		private static readonly string NativeJavaInterfaceName;

		internal SpConsents _spConsents;

		public SpClientProxy()
			: base((string)null)
		{
		}

		private void onUIReady(AndroidJavaObject view)
		{
		}

		private void onUIFinished(AndroidJavaObject view)
		{
		}

		private AndroidJavaObject onAction(AndroidJavaObject view, AndroidJavaObject actionType)
		{
			return null;
		}

		private void onConsentReady(string spConsents)
		{
		}

		private void onSpFinished(string spConsents)
		{
		}

		private void onError(AndroidJavaObject rawThrowableObject)
		{
		}

		private void onConsentReady(AndroidJavaObject spConsents)
		{
		}

		private void onSpFinished(AndroidJavaObject spConsents)
		{
		}

		private void onMessageReady(AndroidJavaObject spMessage)
		{
		}
	}
}
