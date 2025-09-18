using System;
using JetBrains.Annotations;
using UnityEngine;

namespace ConsentManagementProviderLib.Android
{
	internal class CustomConsentClient : AndroidJavaProxy
	{
		private static readonly string NativeJavaInterfaceName;

		private Action<GdprConsent> callback;

		internal GdprConsent customGdprConsent;

		public CustomConsentClient(Action<GdprConsent> callback)
			: base((string)null)
		{
		}

		[UsedImplicitly]
		private void transferCustomConsentToUnity(string spConsentsJson)
		{
		}
	}
}
