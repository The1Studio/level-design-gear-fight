using System.Collections.Generic;

namespace Voodoo.Live.Analytics
{
	public class OfferTryShowEvent : OfferEvent
	{
		private const string Offer_Type = "offer_type";

		private const string Offer_Source = "offer_open_source";

		private const string Trigger_Source = "trigger_source";

		public readonly string type;

		public readonly string source;

		public readonly string trigger;

		private static string eventName;

		public OfferTryShowEvent(string offerId, string offerName, string offerType, string trigger)
			: base(null, null, null)
		{
		}

		protected override void AddParameters(Dictionary<string, object> parameters)
		{
		}
	}
}
