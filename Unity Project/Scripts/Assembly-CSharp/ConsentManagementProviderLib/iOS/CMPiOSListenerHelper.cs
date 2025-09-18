using System;
using AOT;
using UnityEngine;

namespace ConsentManagementProviderLib.iOS
{
	internal class CMPiOSListenerHelper : MonoBehaviour
	{
		public static CMPiOSListenerHelper self;

		private Action<GdprConsent> onCustomConsentsGDPRSuccessAction;

		internal GdprConsent customGdprConsent;

		internal SpConsents _spConsents;

		private void Awake()
		{
		}

		internal void SetBridgeCallbacks()
		{
		}

		internal void SetCustomConsentsGDPRSuccessAction(Action<GdprConsent> action)
		{
		}

		[MonoPInvokeCallback(typeof(Action<string>))]
		private static void Callback(string message)
		{
		}

		[MonoPInvokeCallback(typeof(Action<string>))]
		private static void OnConsentReady(string message)
		{
		}

		private void SaveConsent(SpConsents consent)
		{
		}

		[MonoPInvokeCallback(typeof(Action<string>))]
		private static void OnConsentUIReady(string message)
		{
		}

		[MonoPInvokeCallback(typeof(Action<string>))]
		private static void OnConsentAction(string message)
		{
		}

		[MonoPInvokeCallback(typeof(Action<string>))]
		private static void OnConsentUIFinished(string message)
		{
		}

		[MonoPInvokeCallback(typeof(Action<string>))]
		private static void OnErrorCallback(string jsonError)
		{
		}

		[MonoPInvokeCallback(typeof(Action<string>))]
		private static void OnCustomConsentGDPRCallback(string jsonSPGDPRConsent)
		{
		}

		public void Dispose()
		{
		}
	}
}
