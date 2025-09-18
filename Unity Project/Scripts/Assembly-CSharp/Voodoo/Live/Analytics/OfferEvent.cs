using System.Collections.Generic;

namespace Voodoo.Live.Analytics
{
	public class OfferEvent : IAnalyticsRequest
	{
		private const string OFFER_ID = "offer_id";

		private const string OFFER_NAME = "offer_name";

		public string OfferId { get; }

		public string OfferName { get; }

		public string EventName { get; }

		public OfferEvent(string eventName, string offerId, string offerName)
		{
		}

		public void Track()
		{
		}

		protected virtual void AddParameters(Dictionary<string, object> parameters)
		{
		}
	}
}
