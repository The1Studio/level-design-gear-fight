namespace Voodoo.Live.Analytics
{
	public class OfferConfigStatus : ConfigStatus, IAnalyticsRequest
	{
		private const string OFFER_LIST = "offer_list";

		private const string EVENT_NAME = "voodoolive_offer_config_status";

		private readonly string _offerList;

		public OfferConfigStatus(ConfigResponse config, string offerList)
			: base(null)
		{
		}

		public void Track()
		{
		}
	}
}
