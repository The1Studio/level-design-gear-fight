using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads
{
	public class MaxNativeAdsSdkCallbacks : MonoBehaviour
	{
		private const string TAG = "MaxNativeAdsSdkCallbacks";

		private static Action<string, MaxSdkBase.AdInfo> _onNativeAdLoadedEvent;

		private static Action<string, MaxSdkBase.ErrorInfo> _onNativeAdAdLoadFailedEvent;

		private static Action<string, MaxSdkBase.AdInfo> _onNativeAdDisplayedEvent;

		private static Action<string, MaxSdkBase.ErrorInfo> _onNativeAdFailedToDisplayEvent;

		private static Action<string, MaxSdkBase.AdInfo> _onNativeAdClickedEvent;

		private static Action<string, MaxSdkBase.AdInfo> _onNativeAdRevenuePaidEvent;

		private static Action<string, MaxSdkBase.AdInfo> _onNativeAdHiddenEvent;

		public static MaxNativeAdsSdkCallbacks Instance { get; private set; }

		public static event Action<string, MaxSdkBase.AdInfo> OnAdLoadedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo> OnAdLoadFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdDisplayedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo> OnAdFailedToDisplayEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdClickedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdRevenuePaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdHiddenEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static void ForwardEvent(string eventPropsStr)
		{
		}

		private static void InvokeEvent<T1, T2>(Action<T1, T2> evt, T1 param1, T2 param2)
		{
		}

		private static bool CanInvokeEvent(Delegate evt)
		{
			return false;
		}

		private void Awake()
		{
		}
	}
}
