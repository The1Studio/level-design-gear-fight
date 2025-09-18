namespace ConsentManagementProviderLib
{
	public class SpGdprConsent
	{
		public bool applies;

		public GdprConsent consents;

		public SpGdprConsent(bool applies, GdprConsent consents)
		{
		}

		public SpGdprConsent(GdprConsent consents)
		{
		}
	}
}
