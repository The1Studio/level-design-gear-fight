using System.Collections.Generic;

namespace Voodoo.Live.Analytics
{
	public class OfferClickedEvent : OfferEvent
	{
		private const string Offer_Type = "offer_type";

		private const string Feature_Id = "feature_id";

		private const string Feature_Type = "feature_type";

		public readonly string offerType;

		public readonly string featureId;

		public readonly string featureType;

		private static string eventName;

		public OfferClickedEvent(string offerId, string offerName, string offerType, string featureId, string featureType)
			: base(null, null, null)
		{
		}

		protected override void AddParameters(Dictionary<string, object> parameters)
		{
		}
	}
}
