using System.Threading.Tasks;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Privacy
{
	public interface IPrivacyAPI
	{
		void Initialize(IRequest request);

		Task<NeedConsent> NeedConsent(NeedConsentParams data);

		Task<bool> ConsentInsights(ConsentInsightsParams data);

		Task<PrivacyRequest> DeleteDataRequest(DeleteDataParameters p);

		Task<PrivacyRequest> AccessDataRequest(AccessDataParameters p);
	}
}
