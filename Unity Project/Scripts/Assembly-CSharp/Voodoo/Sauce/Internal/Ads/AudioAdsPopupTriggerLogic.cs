namespace Voodoo.Sauce.Internal.Ads
{
	public class AudioAdsPopupTriggerLogic
	{
		private int _totalPopupDisplayed;

		private int _totalImpressions;

		private int _closePopupCappingPerSession;

		private int _closePopupFrequencyPerImpression;

		public int TotalPopupDisplayed => 0;

		public int TotalImpressions => 0;

		public int ClosePopupCappingPerSession => 0;

		public int ClosePopupFrequencyPerImpression => 0;

		public AudioAdsPopupTriggerLogic(int closePopupCappingPerSession, int closePopupFrequencyPerImpression)
		{
		}

		public void Reset()
		{
		}

		public void AudioAdsImpressionTriggered()
		{
		}

		public bool ResolvePopup()
		{
			return false;
		}

		private bool IsCappingPerSessionReached(int closePopupCappingPerSession)
		{
			return false;
		}

		private bool IsRequiredImpressionReached(int closePopupFrequencyPerImpression)
		{
			return false;
		}
	}
}
