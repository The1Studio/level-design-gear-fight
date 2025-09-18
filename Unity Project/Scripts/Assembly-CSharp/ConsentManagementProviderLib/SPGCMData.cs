namespace ConsentManagementProviderLib
{
	public class SPGCMData
	{
		public enum Status
		{
			granted = 0,
			denied = 1
		}

		public Status? adStorage;

		public Status? analyticsStorage;

		public Status? adUserData;

		public Status? adPersonalization;

		public SPGCMData(Status? adStorage, Status? analyticsStorage, Status? adUserData, Status? adPersonalization)
		{
		}
	}
}
