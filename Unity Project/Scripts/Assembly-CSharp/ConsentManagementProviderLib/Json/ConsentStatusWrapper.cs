namespace ConsentManagementProviderLib.Json
{
	internal class ConsentStatusWrapper
	{
		public bool? rejectedAny;

		public bool? rejectedLI;

		public bool? consentedAll;

		public bool? consentedToAll;

		public bool? consentedToAny;

		public bool? rejectedAll;

		public bool? vendorListAdditions;

		public bool? legalBasisChanges;

		public GranularStatusWrapper? granularStatus;

		public object? rejectedVendors;

		public object? rejectedCategories;

		public bool hasConsentData;
	}
}
