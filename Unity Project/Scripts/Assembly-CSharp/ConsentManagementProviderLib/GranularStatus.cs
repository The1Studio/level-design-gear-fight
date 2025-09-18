using System.Text;

namespace ConsentManagementProviderLib
{
	public class GranularStatus
	{
		public string? vendorConsent;

		public string? vendorLegInt;

		public string? purposeConsent;

		public string? purposeLegInt;

		public bool? previousOptInAll;

		public bool? defaultConsent;

		public bool? sellStatus;

		public bool? shareStatus;

		public bool? sensitiveDataStatus;

		public bool? gpcStatus;

		public GranularStatus(string? vendorConsent, string? vendorLegInt, string? purposeConsent, string? purposeLegInt, bool? previousOptInAll, bool? defaultConsent, bool? sellStatus, bool? shareStatus, bool? sensitiveDataStatus, bool? gpcStatus)
		{
		}

		public StringBuilder ToFullString(StringBuilder sb)
		{
			return null;
		}
	}
}
