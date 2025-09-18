namespace Voodoo.Sauce.CrashReport
{
	internal struct CrashReporterProviderBucket
	{
		internal readonly double Percentage;

		internal readonly ICrashlyticsProvider CrashReporterProvider;

		public CrashReporterProviderBucket(double percentage, ICrashlyticsProvider crashReporterProvider)
		{
			Percentage = 0.0;
			CrashReporterProvider = null;
		}
	}
}
