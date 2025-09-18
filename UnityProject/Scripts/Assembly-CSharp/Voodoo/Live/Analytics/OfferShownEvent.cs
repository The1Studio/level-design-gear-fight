using System.Collections.Generic;

namespace Voodoo.Live.Analytics
{
	public class OfferShownEvent : OfferEvent
	{
		private const string Feature_Id_List = "feature_id_list";

		private const string Offer_Type = "offer_type";

		private const string Campaign_Name = "offer_campaign_name";

		private const string Offer_Source = "offer_open_source";

		private const string Trigger_Source = "trigger_source";

		public readonly string featureIds;

		public readonly string type;

		public readonly string campaign;

		public readonly string source;

		public readonly string trigger;

		private static string eventName;

		public OfferShownEvent(string offerId, string offerName, string featureIds, string campaign, string offerType, string trigger)
			: base(null, null, null)
		{
		}

		protected override void AddParameters(Dictionary<string, object> parameters)
		{
		}
	}
}
