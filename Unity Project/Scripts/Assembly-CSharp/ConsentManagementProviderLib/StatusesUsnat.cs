using System.Text;

namespace ConsentManagementProviderLib
{
	public class StatusesUsnat
	{
		public bool? rejectedAny;

		public bool? consentedToAll;

		public bool? consentedToAny;

		public bool? hasConsentData;

		public bool? sellStatus;

		public bool? shareStatus;

		public bool? sensitiveDataStatus;

		public bool? gpcStatus;

		internal static StatusesUsnat collectData(ConsentStatus status)
		{
			return null;
		}

		public StringBuilder ToFullString(StringBuilder sb)
		{
			return null;
		}
	}
}
