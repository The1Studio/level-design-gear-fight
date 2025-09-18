using System.Collections.Generic;

namespace ConsentManagementProviderLib
{
	public class UsnatConsent
	{
		public string? uuid;

		public bool applies;

		public List<ConsentString> consentStrings;

		public List<Consentable> vendors;

		public List<Consentable> categories;

		public StatusesUsnat statuses;

		public UsnatConsent(string? uuid, bool applies, List<ConsentString> consentStrings, List<Consentable> vendors, List<Consentable> categories, ConsentStatus consentStatus)
		{
		}

		public UsnatConsent(string? uuid, bool applies, List<ConsentString> consentStrings, List<Consentable> vendors, List<Consentable> categories, StatusesUsnat statuses)
		{
		}

		public string ToFullString()
		{
			return null;
		}
	}
}
