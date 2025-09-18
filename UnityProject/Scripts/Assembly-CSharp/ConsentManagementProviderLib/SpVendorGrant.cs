using System.Collections.Generic;

namespace ConsentManagementProviderLib
{
	public class SpVendorGrant
	{
		public bool vendorGrant;

		public Dictionary<string, bool> purposeGrants;

		public SpVendorGrant(bool vendorGrant, Dictionary<string, bool> purposeGrants)
		{
		}
	}
}
