namespace Voodoo.Sauce.Ads.Internal
{
	public abstract class AppHarbrWrapper
	{
		public enum AppHarbrStatus
		{
			NotEnabled = 0,
			NotInitialized = 1,
			Initialized = 2,
			FailedInitialization = 3
		}

		protected AppHarbrSettings _settings;

		protected const string TAG = "AppHarbrWrapper";

		protected AppHarbrConfig _config;

		protected string _iosAppKey;

		protected string _androidAppKey;

		public AppHarbrSettings Settings => null;

		public AppHarbrStatus Status { get; protected set; }

		protected bool Initialize(AHAdSdk mediation)
		{
			return false;
		}

		protected string ConfigToString(AHSdkConfiguration configuration)
		{
			return null;
		}

		protected void OnInitializationComplete(string error)
		{
		}

		protected void OnInterstitialLoadAttempt(string adUnit)
		{
		}

		protected void OnRewardedVideoLoadAttempt(string adUnit)
		{
		}

		private void OnAdIncident(AHIncidentData incidentData)
		{
		}

		private void OnAdBlocked(AHIncidentData incidentData)
		{
		}

		private void OnAdAnalyzed(AHIncidentData incidentData)
		{
		}
	}
}
