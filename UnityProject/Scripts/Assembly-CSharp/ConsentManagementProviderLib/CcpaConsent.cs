using System.Collections.Generic;

namespace ConsentManagementProviderLib
{
	public class CcpaConsent
	{
		public string uuid;

		public string status;

		public string uspstring;

		public List<string> rejectedVendors;

		public List<string> rejectedCategories;

		public string childPmId;

		public bool applies;

		public bool? signedLspa;

		public string webConsentPayload;

		public ConsentStatus? consentStatus;

		public CcpaConsent(string uuid, string status, string uspstring, List<string> rejectedVendors, List<string> rejectedCategories, string childPmId, bool applies, bool? signedLspa, string webConsentPayload, ConsentStatus? consentStatus)
		{
		}

		public CcpaConsent(string uuid, string status, string uspstring, string[] rejectedVendors, string[] rejectedCategories, string childPmId, bool applies, bool? signedLspa, string webConsentPayload, ConsentStatus consentStatus)
		{
		}
	}
}
