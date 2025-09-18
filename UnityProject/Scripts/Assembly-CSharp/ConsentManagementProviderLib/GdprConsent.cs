using System.Collections.Generic;

namespace ConsentManagementProviderLib
{
	public class GdprConsent
	{
		public bool applies;

		public string uuid;

		public string webConsentPayload;

		public string euconsent;

		public Dictionary<string, object> TCData;

		public Dictionary<string, SpVendorGrant> grants;

		public List<string> acceptedCategories;

		public ConsentStatus consentStatus;

		public SPGCMData? googleConsentMode;

		public string ToFullString()
		{
			return null;
		}
	}
}
