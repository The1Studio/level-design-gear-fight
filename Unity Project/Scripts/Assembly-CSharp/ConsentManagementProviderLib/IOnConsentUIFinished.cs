using ConsentManagementProviderLib.EventHandlerInterface;
using UnityEngine.EventSystems;

namespace ConsentManagementProviderLib
{
	public interface IOnConsentUIFinished : IConsentEventHandler, IEventSystemHandler
	{
		void OnConsentUIFinished();
	}
}
