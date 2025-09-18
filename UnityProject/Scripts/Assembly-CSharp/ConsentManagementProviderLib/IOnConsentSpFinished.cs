using ConsentManagementProviderLib.EventHandlerInterface;
using UnityEngine.EventSystems;

namespace ConsentManagementProviderLib
{
	public interface IOnConsentSpFinished : IConsentEventHandler, IEventSystemHandler
	{
		void OnConsentSpFinished(SpConsents spConsent);
	}
}
