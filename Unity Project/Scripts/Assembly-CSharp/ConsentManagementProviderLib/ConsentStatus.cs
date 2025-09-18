using System.Text;

namespace ConsentManagementProviderLib
{
	public class ConsentStatus
	{
		public bool? rejectedAny;

		public bool? rejectedLI;

		public bool? consentedAll;

		public bool? consentedToAll;

		public bool? consentedToAny;

		public bool? rejectedAll;

		public bool? vendorListAdditions;

		public bool? legalBasisChanges;

		public GranularStatus? granularStatus;

		public bool hasConsentData;

		public object rejectedVendors;

		public object rejectedCategories;

		public StringBuilder ToFullString(StringBuilder sb)
		{
			return null;
		}
	}
}
