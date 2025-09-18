namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	public class FakeAdsManager : IFakeAdsManager
	{
		private const string ENABLE_FAKE_ADS_KEY = "Voodoo_FakeAdsEnabled";

		private const string TAG = "FakeAds";

		private bool _isEnabled;

		public bool IsEnabled()
		{
			return false;
		}

		public void SetEnabled(bool isEnabled)
		{
		}

		public void Initialize()
		{
		}

		private void UpdateEnabledValue(bool isEnabled)
		{
		}
	}
}
