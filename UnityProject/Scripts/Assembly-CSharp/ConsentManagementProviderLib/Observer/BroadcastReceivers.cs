using System;
using System.Collections.Generic;
using ConsentManagementProviderLib.EventHandlerInterface;
using UnityEngine;

namespace ConsentManagementProviderLib.Observer
{
	internal static class BroadcastReceivers
	{
		private static readonly IDictionary<Type, IList<GameObject>> BroadcastsReceivers;

		public static GameObject[] GetHandlersForEvent<T>() where T : IConsentEventHandler
		{
			return null;
		}

		public static void RegisterBroadcastReceiver<T>(GameObject go) where T : IConsentEventHandler
		{
		}

		public static void UnregisterBroadcastReceiver<T>(GameObject go) where T : IConsentEventHandler
		{
		}
	}
}
