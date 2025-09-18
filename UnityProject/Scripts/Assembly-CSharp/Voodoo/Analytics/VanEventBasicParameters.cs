using JetBrains.Annotations;

namespace Voodoo.Analytics
{
	public abstract class VanEventBasicParameters
	{
		public abstract string GetPlatform();

		public abstract string GetAppBundleId();

		public abstract string GetAppVersion();

		public abstract string GetScreenResolution();

		public abstract string GetOSVersion();

		public abstract string GetManufacturer();

		public abstract string GetModel();

		public abstract string GetUserId();

		public abstract string GetLocale();

		public abstract string GetConnectivity();

		public abstract int GetAppLaunchCount();

		public abstract int GetGameCount();

		public abstract string GetDeveloperDeviceId();

		public abstract bool GetAdsConsentGiven();

		public abstract bool GetAnalyticsConsentGiven();

		public abstract string GetAdvertisingId();

		public abstract bool HasLimitAdTrackingEnabled();

		[CanBeNull]
		public abstract string GetVSVersion();

		[CanBeNull]
		public abstract string GetIdfaAuthorizationStatus();

		[CanBeNull]
		public abstract string GetInstallStore();

		[CanBeNull]
		public abstract string GetFirstAppLaunchDate();

		[CanBeNull]
		public abstract string GetMediation();

		[CanBeNull]
		public abstract string GetSegmentationUuid();

		[CanBeNull]
		public abstract string GetAbTestUuid();

		[CanBeNull]
		public abstract string GetAbTestCohortUuid();

		public abstract string GetAbTestTreatmentUuid();

		[CanBeNull]
		public abstract string GetAbTestVersionUuid();

		[CanBeNull]
		public abstract string GetAttributionDataName();

		[CanBeNull]
		public abstract string GetAttributionDataUserId();

		[CanBeNull]
		public abstract string GetCurrentLevel();

		internal abstract void SetAppBundleId([CanBeNull] string appBundleId);

		internal abstract void SetAppVersion([CanBeNull] string appVersion);

		internal abstract void SetVsVersion([CanBeNull] string vsVersion);

		internal abstract void SetMediation([CanBeNull] string mediation);

		internal abstract void SetSegmentationUuid([CanBeNull] string segmentationUuid);

		internal abstract void SetAbTestUuid([CanBeNull] string abTestUuid);

		internal abstract void SetAbTestCohortUuid([CanBeNull] string abTestCohortUuid);

		internal abstract void SetAbTestTreatmentUuid(string abTestTreatmentUuid);

		internal abstract void SetAbTestVersionUuid([CanBeNull] string abTestVersionUuid);
	}
}
