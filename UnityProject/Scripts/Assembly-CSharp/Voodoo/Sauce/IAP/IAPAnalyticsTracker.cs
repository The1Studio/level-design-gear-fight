using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.IAP
{
	public class IAPAnalyticsTracker : IAnalyticsTracker
	{
		public void TrackPurchaseStarted(IIAPStartInfo payload)
		{
		}

		public void TrackPurchaseFailed(IIAPFailedInfo payload)
		{
		}

		public void TrackPurchaseProcessing(IIAPProcessingInfo payload)
		{
		}

		public void TrackPurchaseValidated(IIAPValidatedInfo payload)
		{
		}

		public void TrackIAPRevenues(IIAPTrackingInfo payload)
		{
		}

		public void TrackPurchaseRewarded(IIAPRewardedInfo payload)
		{
		}

		public void TrackPurchaseServerError(IIAPServerErrorInfo payload)
		{
		}

		public void TrackIAPInitializationStarted()
		{
		}

		public void TrackIAPInitialization(IIAPInitializationInfo payload)
		{
		}

		public void TrackNoAdsClick()
		{
		}
	}
}
