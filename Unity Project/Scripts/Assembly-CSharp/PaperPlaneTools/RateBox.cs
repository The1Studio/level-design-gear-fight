namespace PaperPlaneTools
{
	public class RateBox
	{
		private static string statisticsPath;

		private static RateBox instance;

		public static RateBox Instance => null;

		public bool DebugMode { get; set; }

		public string RateUrl { get; set; }

		public RateBoxConditions Conditions { get; set; }

		public RateBoxSettings Settings { get; set; }

		public RateBoxStatistics Statistics { get; private set; }

		public RateBoxTextSettings DefaultTextSettings { get; set; }

		public IAlertPlatformAdapter AlertAdapter { get; set; }

		private RateBox(RateBoxStatistics stat)
		{
		}

		public static string GetStoreUrl(string iTunesAppId, string googlePlayMarketAppBundleId)
		{
			return null;
		}

		public void Init(string rateUrl, RateBoxConditions conditions = null, RateBoxTextSettings textSettings = null, RateBoxSettings settings = null)
		{
		}

		public void Show(string title, string message, string rateButtonTitle, string postponeButtonTilte, string rejectButtonTitle = null)
		{
		}

		public void Show()
		{
		}

		public void ForceShow(string title, string message, string rateButtonTitle, string postponeButtonTilte, string rejectButtonTitle = null)
		{
		}

		public void ForceShow()
		{
		}

		public void IncrementCustomCounter(int value = 1)
		{
		}

		public bool CheckConditionsAreMet()
		{
			return false;
		}

		public void ClearStatistics()
		{
		}

		public bool SaveStatistics()
		{
			return false;
		}

		private int Time()
		{
			return 0;
		}

		private void GoToRateUrl()
		{
		}

		private void DebugLog(string str)
		{
		}
	}
}
