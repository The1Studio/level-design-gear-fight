using ConsentManagementProviderLib.EventHandlerInterface;
using UnityEngine.EventSystems;

namespace ConsentManagementProviderLib
{
	public interface IOnConsentReady : IConsentEventHandler, IEventSystemHandler
	{
		void OnConsentReady(SpConsents consents);
	}
}
