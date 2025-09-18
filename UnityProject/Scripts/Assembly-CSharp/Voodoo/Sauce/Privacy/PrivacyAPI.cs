using System.Threading.Tasks;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Privacy
{
	public class PrivacyAPI : IPrivacyAPI
	{
		private static readonly string BaseUrl;

		private const string NEED_CONSENT = "need_consent";

		private const string CONSENT_INSIGHTS = "consent_insights";

		private const string PRIVACY_REQUEST = "privacy_request";

		private IRequest _request;

		public void Initialize(IRequest request)
		{
		}

		public Task<NeedConsent> NeedConsent(NeedConsentParams data)
		{
			return null;
		}

		public Task<bool> ConsentInsights(ConsentInsightsParams data)
		{
			return null;
		}

		public Task<PrivacyRequest> DeleteDataRequest(DeleteDataParameters p)
		{
			return null;
		}

		public Task<PrivacyRequest> AccessDataRequest(AccessDataParameters p)
		{
			return null;
		}
	}
}
