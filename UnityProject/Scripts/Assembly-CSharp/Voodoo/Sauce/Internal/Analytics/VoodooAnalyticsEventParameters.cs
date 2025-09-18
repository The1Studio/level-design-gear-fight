using JetBrains.Annotations;
using Voodoo.Analytics;
using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class VoodooAnalyticsEventParameters : VanEventBasicParameters
	{
		private const string FAKE_VALUE = "fake";

		private static readonly PrivacyCore Privacy;

		[CanBeNull]
		private string _vsVersion;

		[CanBeNull]
		private string _appBundleId;

		[CanBeNull]
		private string _appVersion;

		[CanBeNull]
		private string _platform;

		[CanBeNull]
		private string _developerDeviceId;

		[CanBeNull]
		private string _firstAppLaunchDate;

		[CanBeNull]
		private string _mediation;

		[CanBeNull]
		private string _segmentationUuid;

		[CanBeNull]
		private string _abTestUuid;

		[CanBeNull]
		private string _abTestCohortUuid;

		private string _abTestTreatmentUuid;

		[CanBeNull]
		private string _abTestVersionUuid;

		[CanBeNull]
		private AttributionData _attributionData;

		internal override void SetVsVersion(string vsVersion)
		{
		}

		internal override void SetAppVersion(string appVersion)
		{
		}

		internal override void SetAppBundleId(string appBundleId)
		{
		}

		internal override void SetMediation(string mediation)
		{
		}

		internal override void SetSegmentationUuid(string segmentationUuid)
		{
		}

		internal override void SetAbTestUuid(string abTestUuid)
		{
		}

		internal override void SetAbTestCohortUuid(string abTestCohortUuid)
		{
		}

		internal override void SetAbTestVersionUuid(string abTestVersionUuid)
		{
		}

		internal override void SetAbTestTreatmentUuid(string treatmentId)
		{
		}

		public override string GetPlatform()
		{
			return null;
		}

		public override string GetVSVersion()
		{
			return null;
		}

		public override string GetAppBundleId()
		{
			return null;
		}

		public override string GetAppVersion()
		{
			return null;
		}

		public override string GetScreenResolution()
		{
			return null;
		}

		public override string GetOSVersion()
		{
			return null;
		}

		public override string GetManufacturer()
		{
			return null;
		}

		public override string GetModel()
		{
			return null;
		}

		public override string GetUserId()
		{
			return null;
		}

		public override string GetLocale()
		{
			return null;
		}

		public override string GetConnectivity()
		{
			return null;
		}

		public override int GetAppLaunchCount()
		{
			return 0;
		}

		public override int GetGameCount()
		{
			return 0;
		}

		public override string GetDeveloperDeviceId()
		{
			return null;
		}

		public override bool GetAdsConsentGiven()
		{
			return false;
		}

		public override bool GetAnalyticsConsentGiven()
		{
			return false;
		}

		public override string GetAdvertisingId()
		{
			return null;
		}

		public override bool HasLimitAdTrackingEnabled()
		{
			return false;
		}

		public override string GetIdfaAuthorizationStatus()
		{
			return null;
		}

		public override string GetInstallStore()
		{
			return null;
		}

		public override string GetFirstAppLaunchDate()
		{
			return null;
		}

		public override string GetMediation()
		{
			return null;
		}

		public override string GetSegmentationUuid()
		{
			return null;
		}

		public override string GetAbTestUuid()
		{
			return null;
		}

		public override string GetAbTestCohortUuid()
		{
			return null;
		}

		public override string GetAbTestTreatmentUuid()
		{
			return null;
		}

		public override string GetAbTestVersionUuid()
		{
			return null;
		}

		public override string GetAttributionDataName()
		{
			return null;
		}

		public override string GetAttributionDataUserId()
		{
			return null;
		}

		public override string GetCurrentLevel()
		{
			return null;
		}
	}
}
