using ConsentManagementProviderLib.EventHandlerInterface;
using UnityEngine;

namespace ConsentManagementProviderLib
{
	public static class ConsentMessenger
	{
		public static void AddListener<T>(GameObject go) where T : IConsentEventHandler
		{
		}

		public static void RemoveListener<T>(GameObject go) where T : IConsentEventHandler
		{
		}

		public static void Broadcast<T>(params object[] list) where T : IConsentEventHandler
		{
		}
	}
}
