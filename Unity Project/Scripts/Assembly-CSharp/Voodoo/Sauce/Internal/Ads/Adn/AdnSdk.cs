using System;
using UnityEngine.Scripting;

namespace Voodoo.Sauce.Internal.Ads.Adn
{
	[UnityEngine.Scripting.Preserve]
	public class AdnSdk
	{
		private static IAdnSdk Instance;

		static AdnSdk()
		{
		}

		public static void SubscribeOnSdkInitializedEvent(Action sdkInitializedEvent)
		{
		}

		public static void SetBidTokenExtraParams(string extraParamsJson)
		{
		}

		public static string LogBidTokenExtraParams()
		{
			return null;
		}

		public static bool IsSdkInitialized()
		{
			return false;
		}

		public static void SetTestMode(bool enabled)
		{
		}
	}
}
