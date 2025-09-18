using ConsentManagementProviderLib.EventHandlerInterface;
using UnityEngine.EventSystems;

namespace ConsentManagementProviderLib
{
	public interface IOnConsentAction : IConsentEventHandler, IEventSystemHandler
	{
		void OnConsentAction(SpAction action);
	}
}
