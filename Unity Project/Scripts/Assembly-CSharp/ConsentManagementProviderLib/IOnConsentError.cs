using System;
using ConsentManagementProviderLib.EventHandlerInterface;
using UnityEngine.EventSystems;

namespace ConsentManagementProviderLib
{
	public interface IOnConsentError : IConsentEventHandler, IEventSystemHandler
	{
		void OnConsentError(Exception exception);
	}
}
