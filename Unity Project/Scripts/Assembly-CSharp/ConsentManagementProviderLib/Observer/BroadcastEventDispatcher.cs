using System;
using System.Collections.Concurrent;
using ConsentManagementProviderLib.EventHandlerInterface;
using UnityEngine.EventSystems;

namespace ConsentManagementProviderLib.Observer
{
	internal static class BroadcastEventDispatcher
	{
		public static ConcurrentQueue<Action> actions;

		public static void Execute<T>(BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) where T : IConsentEventHandler
		{
		}

		public static void Execute(Action action)
		{
		}
	}
}
