namespace Voodoo.Live.Offers
{
	public abstract class ServerFeature : IServerFeature
	{
		public OfferConditions offerConditions { get; set; }

		public string id { get; set; }

		public string name { get; set; }

		public string techName { get; set; }

		public string[] triggers { get; set; }

		public int multiplier { get; set; }

		public string campaign { get; set; }

		public bool showCountdown { get; set; }

		public string badgeIcon { get; set; }

		public bool displayMenuBadge { get; set; }

		public string offerImage { get; set; }

		public string title { get; set; }

		public bool showBadgeCountdown { get; set; }

		public string[] highlightTexts { get; set; }

		public string type { get; set; }

		public abstract IFeature ToValidFormat();

		public void ConvertToValidFormat(Feature feature)
		{
		}
	}
}
