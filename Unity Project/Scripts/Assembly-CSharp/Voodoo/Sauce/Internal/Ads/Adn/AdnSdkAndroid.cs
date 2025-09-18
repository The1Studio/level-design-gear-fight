using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads.Adn
{
	public class AdnSdkAndroid : IAdnSdk
	{
		private class InitCallbackProxy : AndroidJavaProxy
		{
			public Action OnSdkInitializedEvent;

			public InitCallbackProxy()
				: base((string)null)
			{
			}

			public void onComplete()
			{
			}
		}

		private const string TAG = "AdnSdk";

		private const string ADN_SDK_PACKAGE = "io.voodoo.adn.sdk.open";

		private readonly AndroidJavaClass adnSdkClass;

		private readonly InitCallbackProxy initCallbackProxy;

		public void SubscribeOnSdkInitializedEvent(Action sdkInitializedEvent)
		{
		}

		public bool IsSdkInitialized()
		{
			return false;
		}

		public void SetBidTokenExtraParams(string extraParamsJson)
		{
		}

		public string LogBidTokenExtraParams()
		{
			return null;
		}

		public void SetTestMode(bool enabled)
		{
		}

		private AndroidJavaClass AdnSdkClassInstance()
		{
			return null;
		}

		private InitCallbackProxy InitCallbackProxyInstance()
		{
			return null;
		}
	}
}
