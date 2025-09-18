namespace PaperPlaneTools
{
	public class RateBoxConditions
	{
		public bool RequireInternetConnection { get; set; }

		public int MinSessionCount { get; set; }

		public int MinCustomEventsCount { get; set; }

		public int DelayAfterInstallInSeconds { get; set; }

		public int DelayAfterLaunchInSeconds { get; set; }

		public int PostponeCooldownInSeconds { get; set; }
	}
}
